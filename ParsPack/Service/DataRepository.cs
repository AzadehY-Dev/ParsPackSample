using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ParsPack.Model;
using ParsPack.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParsPack.Service
{
    public class DataRepository : IDataRepository
    {
        private static string databaseName = "mydatabase.db";
        private string tableName = "mytable";
        private string connectionString = "Data Source=" + databaseName + ";Version=3;";
        private HttpClient httpClient;

        public async Task ClearTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = $"DELETE FROM {tableName}";

                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

        }
        public async Task Create()
        {
            await CreateAndFetchDBAsync();
        }
        public async Task<DataTable> Search(string search)
        {
            DataTable dataTable = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                await connection.OpenAsync();
                string selectQuery = $"SELECT * FROM {tableName} WHERE id LIKE @search OR name LIKE @search OR date LIKE @search OR comment LIKE @search";
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@search", $"%{search}%");
                    using (SQLiteDataReader reader = (SQLiteDataReader)await command.ExecuteReaderAsync())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }
        public async Task<DataTable> SelectAll(int page, int pageSize)
        {
            DataTable dataTable = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                await connection.OpenAsync();
                int offset = (page - 1) * pageSize;
                string selectQuery = $"SELECT * FROM {tableName} LIMIT {pageSize} OFFSET {offset}";
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = (SQLiteDataReader)await command.ExecuteReaderAsync())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }
        public async Task<DataTable> SelectFromAPI()
        {
            DataTable dataTable = new DataTable();

          
            string apiUrl = "http://tasks.cloudsite.ir/api/";
            string json = string.Empty;

            try
            {
                HttpClient client = new HttpClient();
                json = await client.GetStringAsync(apiUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error from API: " + ex.Message);
                return dataTable;
            }

            DataModel[] data = JsonConvert.DeserializeObject<DataModel[]>(json);

            dataTable.Columns.Add("id", typeof(string));
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("date", typeof(string));
            dataTable.Columns.Add("comment", typeof(string));

            foreach (DataModel item in data)
            {
                dataTable.Rows.Add(item.id, item.name, item.date, item.comment);
            }
            return dataTable;
        }
        private async Task CreateAndFetchDBAsync()
        {
            await Task.Run(() =>
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string createTableQuery = $"CREATE TABLE IF NOT EXISTS {tableName} (id INTEGER PRIMARY KEY, name TEXT, date TEXT, comment TEXT)";
                    using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }



                    string apiUrl = "http://tasks.cloudsite.ir/api/";
                    string jsonData = string.Empty;



                    using (WebClient client = new WebClient())
                    {
                        jsonData = client.DownloadString(apiUrl);
                    }

                    JArray data = JArray.Parse(jsonData);
                    using (SQLiteTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            foreach (JObject item in data)
                            {
                                int id = Convert.ToInt32(item.GetValue("id"));
                                string name = item.GetValue("name").ToString();
                                string date = item.GetValue("date").ToString();
                                string comment = item.GetValue("comment").ToString();

                                string replaceQuery = $"REPLACE INTO {tableName} (id, name, date, comment) VALUES (@id, @name, @date, @comment)";
                                using (SQLiteCommand replaceCommand = new SQLiteCommand(replaceQuery, connection))
                                {
                                    replaceCommand.Parameters.AddWithValue("@id", id);
                                    replaceCommand.Parameters.AddWithValue("@name", name);
                                    replaceCommand.Parameters.AddWithValue("@date", date);
                                    replaceCommand.Parameters.AddWithValue("@comment", comment);
                                    replaceCommand.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit(); 
                            MessageBox.Show("Data successfully added to DataBase.");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback(); 
                            MessageBox.Show("Error from API: " + ex.Message);
                        }
                    }
                }

            });

        }
        public async Task AddRecord(DataModel dataModel)
        {
            httpClient = new HttpClient();
            string apiUrl = "http://tasks.cloudsite.ir/api/";

            var formData = new MultipartFormDataContent();
            formData.Add(new StringContent(dataModel.name), "name");
            formData.Add(new StringContent(dataModel.date), "date");
            formData.Add(new StringContent(dataModel.comment), "comment");
            try
            {
                HttpResponseMessage response = await httpClient.PostAsync(apiUrl, formData);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("New record added successfully.");
                }
                else
                {
                    MessageBox.Show("Error adding the new record. Status code: " + response.StatusCode);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occurred: " + ex.Message);
            }
        }
    }
}

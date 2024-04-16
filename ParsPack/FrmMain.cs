using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SQLite;
using Newtonsoft.Json.Linq;
using ParsPack.Repository;
using ParsPack.Service;

namespace ParsPack
{
    public partial class FrmMain : Form
    {
        IDataRepository repository;
        public FrmMain()
        {
            InitializeComponent();
            repository= new DataRepository();
        }
        private int currentPage = 1; 
        private async void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();


        }


        private async void PreviousPageButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--; 
                int pageSize = 10; 
                DataTable data = await repository.SelectAll(currentPage, pageSize);
                DGdata.DataSource = data;
            }
        }

        private async void NextPageButton_Click(object sender, EventArgs e)
        {
            currentPage++; 
            int pageSize = 10; 
            DataTable data = await repository.SelectAll(currentPage, pageSize);
            DGdata.DataSource = data;
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable data = await repository.Search(txtSearch.Text);
            DGdata.DataSource = data;
        }
        private async void CreateDb_Click(object sender, EventArgs e)
        {
            repository.Create();
            BindGrid();
        }
        private async void ClearDb_Click(object sender, EventArgs e)
        {
           
            repository.ClearTable();
            BindGrid();
        }
        private async void fillFromAPI_Click(object sender, EventArgs e)
        {
            DataTable data = await repository.SelectFromAPI();
            DGdata.DataSource = data;
        }
        private async void FillFromLocalDB_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
        public async void BindGrid()
        {
            int pageSize = 10; 
            DataTable data = await repository.SelectAll(currentPage, pageSize);
            DGdata.DataSource = data;
        }
        private void AddNewRecord_Click(object sender, EventArgs e)
        {
            FrmNewRecord frmNewRecord = new FrmNewRecord();
            frmNewRecord.ShowDialog();
           // repository.AddRecord();
        }

    }
        
}

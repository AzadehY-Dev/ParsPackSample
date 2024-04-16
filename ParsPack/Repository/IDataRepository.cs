using ParsPack.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ParsPack.Repository
{
    public interface IDataRepository
    {
        Task Create();
        Task ClearTable();
        Task<DataTable> SelectAll(int page, int pageSize);
        Task<DataTable> SelectFromAPI();
        Task<DataTable> Search(string search);
        Task AddRecord(DataModel dataModel);
    }
}

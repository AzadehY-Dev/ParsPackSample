using ParsPack.Model;
using ParsPack.Repository;
using ParsPack.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParsPack
{
    public partial class FrmNewRecord : Form
    {
        IDataRepository _dataRepository;
        public FrmNewRecord()
        {
            InitializeComponent();
            _dataRepository= new DataRepository();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(isValid())
            {
                DataModel dataModel= new DataModel()
                {
                    name= txtName.Text.ToString(),
                    comment = txtComment.Text.ToString(),
                    date = txtDate.Text.ToString(),
                };
                _dataRepository.AddRecord(dataModel);
            }
        }
        bool isValid()
        {
            bool IsValid = true;
            if (txtName.Text == "" || txtName.Text.Length > 250)
            {
                IsValid = false;
                MessageBox.Show("please Enter Name Correctly", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return IsValid;
            }
            if (txtDate.Text == "" || txtDate.Text.Length > 11)
            {
                IsValid = false;
                MessageBox.Show("please Enter Date Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return IsValid;
            }
            if (txtComment.Text == "" || txtComment.Text.Length > 250)
            {
                IsValid = false;
                MessageBox.Show("please Enter Comment Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return IsValid;
            }
            return IsValid;
        }
    }
}

using followUp.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace followUp.view
{
    public partial class FrmManageAssignedGroup : Form
    {
        public FrmManageAssignedGroup()
        {
            InitializeComponent();
            updateDGV();
        }

        private void updateDGV()
        {
            string search;
            GroupDAO operations;
            DataTable result;
            try
            {
                search = txtSearchName.Text.Trim();
                operations = new GroupDAO();
                result = operations.searchByName(search);
                if (result.Rows.Count > 0)
                {
                    dgvGroups.DataSource = result;
                    dgvGroups.Show();
                }
                else
                    dgvGroups.Hide();
            }
            catch (Exception ex)
            {
                throw new Exception("Error when updating list of groups shown: " + ex.Message);
            }
        }
    }
}

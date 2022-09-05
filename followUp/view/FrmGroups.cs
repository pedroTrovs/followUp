using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using followUp.controller;
using followUp.model;

namespace followUp.view
{
    public partial class FrmGroups : Form
    {
        public FrmGroups()
        {
            InitializeComponent();
            updateDGV();
            updateCBOBook();
        }
        private void updateCBOBook()
        {
            BookDAO operations;
            DataTable result;
            try
            {
                operations = new BookDAO();
                result = operations.SelectOnlyNames();
                foreach (DataRow item in result.Rows)
                {
                    cboBook.Items.Add(item[0]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error when updating list of books: " + ex.Message);
            }
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
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Group g;
            GroupDAO operationsG;
            BookDAO operationsB;
            try
            {
                g = new Group();
                g.setName(txtGroupName.Text);
                g.setDay(cboClassDay.SelectedIndex);
                g.setTime(dtpClassTIme.Value);
                operationsB = new BookDAO();
                g.setBookId(operationsB.getIdFromName(cboBook.SelectedItem.ToString()));
                operationsG = new GroupDAO();
                operationsG.createGetId(g);
                txtGroupId.Text = g.id.ToString();
                updateDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at creation event: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Group g;
            GroupDAO operations;
            int aux = 0;
            try
            {
                g = new Group();
                g.setId(txtGroupId.Text);
                g.setName(txtGroupName.Text);
                g.setDay(cboClassDay.SelectedIndex);
                g.setTime(dtpClassTIme.Value);
                operations = new GroupDAO();
                aux = operations.update(g);
                if (aux == 0)
                {
                    throw new Exception("Change not detected");
                }
                updateDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at updating event: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            GroupDAO operations;
            int aux = 0;
            try
            {
                operations = new GroupDAO();
                aux = operations.remove(Convert.ToInt32(txtGroupId.Text));
                if (aux == 0)
                {
                    throw new Exception("Change not detected");
                }
                updateDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at removal event: " + ex.Message);
            }
        }

        private void txtSearchName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                updateDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when searching by name: " + ex.Message);
            }
        }

        private void FrmGroups_Enter(object sender, EventArgs e)
        {
            updateCBOBook();
        }

        private void dgvGroups_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection c;
            try
            {
                c = dgvGroups.SelectedCells;
                txtGroupId.Text = c[0].Value.ToString();
                txtGroupName.Text = c[1].Value.ToString();
                cboClassDay.SelectedItem = c[2].Value.ToString();
                dtpClassTIme.Value = Convert.ToDateTime(c[3].Value);
                cboBook.SelectedItem = c[4].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at selecting group from list: " + ex.Message);
            }
        }
    }
}

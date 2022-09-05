using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using followUp.model;
using followUp.controller;

namespace followUp.view
{
    public partial class FrmBooks : Form
    {
        public FrmBooks()
        {
            InitializeComponent();
            updateDGV();
        }
        private void updateDGV()
        {
            string search;
            BookDAO operations;
            DataTable result;
            try
            {
                search = txtSearchName.Text.Trim();
                operations = new BookDAO();
                result = operations.searchByName(search);
                if (result.Rows.Count > 0)
                {
                    dgvBooks.DataSource = result;
                    dgvBooks.Show();
                }
                else
                    dgvBooks.Hide();
            }
            catch (Exception ex)
            {
                throw new Exception("Error when updating list of books shown: " + ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Book b;
            BookDAO operations;
            try
            {
                b = new Book();
                b.setName(txtBookName.Text);
                operations = new BookDAO();
                operations.createGetId(b);
                txtBookId.Text = b.id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at creation event: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Book b;
            BookDAO operations;
            int aux = 0;
            try
            {
                b = new Book();
                b.setId(txtBookId.Text);
                b.setName(txtBookName.Text);
                operations = new BookDAO();
                aux = operations.update(b);
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
            BookDAO operations;
            int aux = 0;
            try
            {
                operations = new BookDAO();
                aux = operations.remove(Convert.ToInt32(txtBookId.Text));
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

        private void dgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection c;
            try
            {
                c = dgvBooks.SelectedCells;
                txtBookId.Text = c[0].Value.ToString();
                txtBookName.Text = c[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at selecting book from list: " + ex.Message);
            }
        }
    }
}

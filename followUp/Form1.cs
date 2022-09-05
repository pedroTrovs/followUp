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
using followUp.view;

namespace followUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                updateDGV();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error at form initialization: " + ex.Message);
            }
        }

        private void updateDGV()
        {
            string search;
            StudentDAO operations;
            DataTable result;
            try
            {
                search = txtSearchName.Text.Trim();
                operations = new StudentDAO();
                result = operations.searchByName(search);
                if (result.Rows.Count > 0)
                {
                    dgvStudents.DataSource = result;
                    dgvStudents.Show();
                }
                else
                    dgvStudents.Hide();
            }
            catch (Exception ex)
            {
                throw new Exception("Error when updating list of students shown: " + ex.Message);
            }
        }
        private void txtAssignedGroup_Click(object sender, EventArgs e)
        {
            FrmManageAssignedGroup f;

            try
            {
                if(Application.OpenForms.OfType<FrmManageAssignedGroup>().Count()>0)
                {
                    Application.OpenForms.OfType<FrmManageAssignedGroup>().First().Focus();
                }
                else
                {
                    f = new FrmManageAssignedGroup();
                    f.Show();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when opening form for managing student's assigned group: " + ex.Message);
            }
        }

        private void txtAssignedGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if(k == 13)
            {
                txtAssignedGroup_Click(sender, e);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Student s;
            StudentDAO operations;
            try
            {
                s = new Student();
                s.setName(txtStudName.Text);
                s.setGroupId(txtGroupId.Text);
                operations = new StudentDAO();
                operations.createGetId(s);
                txtGroupId.Text = s.id.ToString();
                updateDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at creation event: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student s;
            StudentDAO operations;
            int aux = 0;
            try
            {
                s = new Student();
                s.setId(txtStudId.Text);
                s.setName(txtStudName.Text);
                s.setGroupId(txtGroupId.Text);
                operations = new StudentDAO();
                aux = operations.update(s);
                if(aux == 0)
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
            StudentDAO operations;
            int aux = 0;
            try
            {
                operations = new StudentDAO();
                aux = operations.remove(Convert.ToInt32(txtStudId.Text));
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

        private void dgvStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection c;
            try
            {
                c = dgvStudents.SelectedCells;
                txtStudId.Text = c[0].Value.ToString();
                txtStudName.Text = c[1].Value.ToString();
                txtAssignedGroup.Text = c[2].Value.ToString();
                txtGroupId.Text = c[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at selecting student from list: " + ex.Message);
            }
        }
    }
}

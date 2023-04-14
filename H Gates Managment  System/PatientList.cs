using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using MySql.Data.MySqlClient;
using RestSharp.Extensions;

namespace H_Gates_Managment__System
{
    public partial class PatientList : Form
    {
        private MainPage mainPage;
         private readonly HGatesDesktopAppEntities _db;
      //  private readonly HGatesDesktopAppEntities1 _db;
       

        public PatientList()
        {
            InitializeComponent();
            _db = new HGatesDesktopAppEntities();
            //_db = new HGatesDesktopAppEntities1();
            
        }

        public PatientList(MainPage _mainPage)
        {
            InitializeComponent();
            mainPage = _mainPage;
            
        
        }


        private void PatientsManagement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void PatientList_Load(object sender, EventArgs e)
        {

            try
            {
                RefreshGridView();





                dgvPatients.Columns["Id"].HeaderText = "ID";
                dgvPatients.Columns["FirstName"].HeaderText = "First Name";
                dgvPatients.Columns["LastName"].HeaderText = "Last Name";
                dgvPatients.Columns["DateOfBirth"].HeaderText = "Date of Birth";
                dgvPatients.Columns["GenderID"].HeaderText = "Gender";
                dgvPatients.Columns["StreetAddress"].HeaderText = "Street Address";
                dgvPatients.Columns["ParishID"].HeaderText = "Parish";
                dgvPatients.Columns[0].Visible= false;
                dgvPatients.Rows[0].Selected = true;
                
            }
            catch (Exception ex)
            {

                throw;
            }
           
            

            
            void RefreshGridView()
            {
                
                while (dgvPatients.Rows.Count<10)
                {
                    var Patient = _db.Patients.Select(q => new
                    { q.Id, q.FirstName, q.LastName, q.DateOfBirth, q.GenderID,q.StreetAddress,q.ParishID }).ToList();

                    dgvPatients.DataSource = Patient;
                }
                
            }
   

        }

        int GetSelectedRow()
        {
            int selected = (int)dgvPatients.SelectedRows[0].Cells[0].Value;
            return selected;
           

        }






        private void dgvPatients_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var selected = dgvPatients.SelectedRows[0];


                tbIDNo.Text = selected.Cells["Id"].Value.ToString();


                //dgvPatients.SelectedRows[0].Cells[0].Value.ToString();
                tbFirstName.Text = selected.Cells["FirstName"].Value.ToString();
                tbLastName.Text = selected.Cells["LastName"].Value.ToString();

                tbDateOFBirth.Text = selected.Cells["DateOfBirth"].Value.ToString();
                tbGender.Text = selected.Cells["GenderID"].Value.ToString();
                tbStreetAddress.Text = selected.Cells["StreetAddress"].Value.ToString();
                tbParish.Text = selected.Cells["ParishID"].Value.ToString();
                
                
                
            }
            catch(Exception) 
            { 
            
            
            }




        }

        private void BtNext_Click(object sender, EventArgs e)
        {

           
            


            
        }







        /* int GetSelectedRow()
         {
             int selected = (int)dgvPatients.SelectedRows[0].Cells[0].Value;
             return selected;

         }*/


















        private void button1_Click(object sender, EventArgs e)
        {
           
        }


        

        private void PatientList_FormClosing(object sender, FormClosingEventArgs e)
        {
            var MainPage = new MainPage();
            MainPage.Show();
            Hide();
        }

        private void PbSearch_Click(object sender, EventArgs e)
        {
            var searchValue = tbSearch.Text;
            int rowIndex = 1;
            dgvPatients.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = true;
                foreach (DataGridViewRow row in dgvPatients.Rows)
                {
                    if (row.Cells[rowIndex].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        dgvPatients.Rows[rowIndex].Selected = true;
                        valueResult= false;
                       
                    }
                    if (valueResult != false)
                    {
                        MessageBox.Show("Record is not avalable for this Name " + tbSearch.Text, "Not Found");
                        return;
                    }




                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                //throw;
            }
        }

    }
}


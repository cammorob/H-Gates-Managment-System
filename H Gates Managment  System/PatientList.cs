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
using System.Windows.Forms.VisualStyles;
using System.Runtime.Remoting.Contexts;

namespace H_Gates_Managment__System
{
    public partial class PatientList : Form
    {
        private MainPage mainPage;
        private readonly HGatesDesktopAppEntities _db;

        //private readonly HGatesDesktopApp _db;

        public PatientList()
        {
            InitializeComponent();
            _db = new HGatesDesktopAppEntities();
          // _db = new HGatesDesktopApp();
            
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

        }

        Patient GetSelectedRow(int Id)
        {
            var patient = _db.Patients.Find(Id);
            return patient;

        }
        void RefreshGridView()
        {

          //  while (dgvPatients.Rows.Count ==100)
            {
                var Patient = _db.Patients.Select(q => new
                { q.Id, q.FirstName, q.LastName, q.DateOfBirth, q.GenderID, q.StreetAddress, q.ParishID }).ToList();

                dgvPatients.DataSource = Patient;
            }

        }




        public static int rowid;
        
        private void dgvPatients_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var selected = dgvPatients.SelectedRows[0];

               
                tbIDNo.Text = selected.Cells["Id"].Value.ToString();

               rowid = Convert.ToInt32(tbIDNo.Text);
              

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

        Patient GetPatientByID(int Id)
        {
            var patient = _db.Patients.Find(Id);
            return patient;
        }


        private void btUpDateDetails_Click(object sender, EventArgs e)
        {
            try { 
            var patient = GetSelectedRow(rowid);
            patient.FirstName = tbFirstName.Text;
            patient.LastName = tbLastName.Text;
            patient.GenderID=Convert.ToInt32(tbGender.Text);
            patient.DateOfBirth=Convert.ToDateTime(tbDateOFBirth.Text);
            patient.StreetAddress=tbStreetAddress.Text;
            patient.ParishID=Convert.ToInt32(tbParish.Text);

                _db.SaveChanges();
                MessageBox.Show("Patient successfully updated.");

                RefreshGridView();







            }
            catch(Exception) 
            
            {

                MessageBox.Show( "Server Unreachable, Please contact Administrator.");
            }




        }




        private void BtNext_Click(object sender, EventArgs e)
        {

           
            


            
        }

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
            string searchValue =  tbSearch.Text;
            var rowIndex=0;
            dgvPatients.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = true;
                foreach (DataGridViewRow row in dgvPatients.Rows)
                {
                    for (int i = 1; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString()== (searchValue))
                        {
                           //rowIndex = row.Index;
                            dgvPatients.Rows[rowIndex].Selected = true;
                            
                            valueResult = false;
                            rowIndex++;
                        }
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

        private void btAddPatient_Click(object sender, EventArgs e)
        {
            var PatientsEntry = new PatientsEntry();
            PatientsEntry.Show();
            Hide();
        }

        private void btViewEContact_Click(object sender, EventArgs e)
        {
            var View_Emergency_Contact = new View_Emergency_contact();
            View_Emergency_Contact.Show();
        }

        private void btDeletePatient_Click(object sender, EventArgs e)
        {
            int rowid = PatientList.rowid;

            try
            {
                if (MessageBox.Show("Do You Want To Remove This Record", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var patient = GetPatientByID(rowid);
                    _db.Patients.Remove(patient);
                    _db.SaveChanges();
                    MessageBox.Show("Record Delete Successfully.");
                    dgvPatients.Refresh();

                }
            }

            catch (Exception exc) 
            { 
            
            
            
            
            }
            
        }
    }
}


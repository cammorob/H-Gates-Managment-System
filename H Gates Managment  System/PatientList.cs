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
using Mysqlx.Crud;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Web.UI.Design.WebControls;
using System.Web.Services.Protocols;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Crypto.Engines;

namespace H_Gates_Managment__System
{
    public partial class PatientList : Form
    {
        private MainPage mainPage;
        private readonly HGatesDesktopAppEntities2 _db;

        //private readonly HGatesDesktopApp _db;

        public PatientList()
        {
            InitializeComponent();
            _db = new HGatesDesktopAppEntities2();
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

            var par = _db.Parishes.ToList();
            tbdropParish.Text= "ParishName";
            tbdropParish.ValueMember = "ParishName";
            tbdropParish.DataSource = par;

            var gen =_db.Genders.ToList();
            cbListGender.Text = "GenderName";
            cbListGender.ValueMember = "GenderName";
            cbListGender.DataSource = gen;


            if (loginPage.CurrentUser != null)
            {
                C_UserLabel.Text = loginPage.CurrentUser;
            }


            RefreshGridView();









        }

        Patient GetSelectedRow(int Id)
        {
            var patient = _db.Patients.Find(Id);
            return patient;

        }
        void RefreshGridView()
        {



            {


                
                
                

                    var patients = _db.Patients.Select(q => new { q.Id, q.FirstName, q.LastName,
                      q.DateOfBirth,q.Gender.GenderName,q.StreetAddress,q.City,q.Parish.ParishName,q.ContactName,
                    ContactAddress=q.ContactAddress,q.EContactNo,q.EmergencyRelationship.RelationshipType});
                   GridViewPatients.DataSource = patients.ToList();
                        

                    GridViewPatients.Columns["Id"].HeaderText = "ID";
                    GridViewPatients.Columns["FirstName"].HeaderText = "First Name";
                    GridViewPatients.Columns["LastName"].HeaderText = "Last Name";
                    GridViewPatients.Columns["DateOfBirth"].HeaderText = "Date of Birth";
                    GridViewPatients.Columns["GenderName"].HeaderText = "Gender";
                    GridViewPatients.Columns["StreetAddress"].HeaderText = "Street Address";
                    GridViewPatients.Columns["City"].HeaderText = "City";
                    GridViewPatients.Columns["ParishName"].HeaderText = "Parish";
                    GridViewPatients.Columns["ContactName"].HeaderText = "Contact Name";
                    GridViewPatients.Columns["ContactAddress"].HeaderText = "Contact Address";
                    GridViewPatients.Columns["EContactNo"].HeaderText = "Phone Number";
                    GridViewPatients.Columns["RelationshipType"].HeaderText = "Relationship";
                    GridViewPatients.Columns[0].Visible = false;
                    GridViewPatients.Rows[0].Selected = true;
                    GridViewPatients.Columns["ContactName"].Visible = false;
                    GridViewPatients.Columns["ContactAddress"].Visible = false;
                    GridViewPatients.Columns["EContactNo"].Visible = false;
                    GridViewPatients.Columns["RelationshipType"].Visible = false;





            }

        }




        public static int rowid;


        Patient GetPatientByID(int Id)
        {
            var patient = _db.Patients.Find(Id);
            return patient;
        }


        private void btUpDateDetails_Click(object sender, EventArgs e)
        {
            try
            {
                var patient = GetSelectedRow(rowid);
                patient.FirstName = tbFirstName.Text;
                patient.LastName = tbLastName.Text;
                cbListGender.ValueMember = "Id";
                // patient.GenderID= Convert.ToInt32(cbListGender);
                patient.GenderID = (int)cbListGender.SelectedValue;
                patient.DateOfBirth = tbDatePick.Value;
                patient.StreetAddress = tbStreetAddress.Text;
                tbdropParish.ValueMember = "Id";
                patient.ParishID = (int)tbdropParish.SelectedValue;

                _db.SaveChanges();
                MessageBox.Show("Patient successfully updated.");

                GridViewPatients.Refresh();







            }
            catch (Exception)

            {

                MessageBox.Show("Server Unreachable, Please contact Administrator.");
            }




        }




        private void BtNext_Click(object sender, EventArgs e)
        {






        }

        private void button1_Click(object sender, EventArgs e)
        {

        }




       /* private void PatientList_FormClosing(object sender, FormClosingEventArgs e)
        {
            var MainPage = new MainPage();
            MainPage.Show();
            Hide();
        }*/

        private void PbSearch_Click(object sender, EventArgs e)
        {
            string searchValue = tbSearch.Text;
            var rowIndex = 0;
            GridViewPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = true;
                foreach (DataGridViewRow row in GridViewPatients.Rows)
                {
                    for (int i = 1; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString() == (searchValue))
                        {
                            //rowIndex = row.Index;
                            GridViewPatients.Rows[rowIndex].Selected = true;

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



            var Emr = GridViewPatients.SelectedRows[0];
            tbshowRelation VE_Con = new tbshowRelation();
            VE_Con.MdiParent = this.MdiParent;







            try
            {



                VE_Con.tbDisplayEname.Text = Emr.Cells["ContactName"].Value.ToString();
                VE_Con.tbContactAddress.Text = Emr.Cells["ContactAddress"].Value.ToString();
                VE_Con.tbContactNumber.Text = Emr.Cells["EContactNo"].Value.ToString();
                VE_Con.tbERelation.Text = Emr.Cells["RelationshipType"].Value.ToString();
                VE_Con.ShowDialog();

                


            }
            catch
            {
                MessageBox.Show("No Emergency Contact Found, Please Update Record");
                UpDateEmergencyContact upDateEmergencyContact = new UpDateEmergencyContact();
                upDateEmergencyContact.Show();
            }


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
                    GridViewPatients.Refresh();

                }
            }

            catch (Exception exc)
            {




            }

        }

        private void BTHome_Click(object sender, EventArgs e)
        {
           
            //var OpenForms = Application.OpenForms.Cast<Form>();
            //var isOpen = OpenForms.Any(q => q.Name == "MainPage");
            //if (isOpen)
            //{
                var MainPage = new MainPage();
                this.Close();

                MainPage.Show();
                
            //}

        }
        
        public void GridViewPatients_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
               

                var selected = GridViewPatients.SelectedRows[0];

                tbIDNo.Text = selected.Cells["Id"].Value.ToString();

                rowid = Convert.ToInt32(tbIDNo.Text);



                tbFirstName.Text = selected.Cells["FirstName"].Value.ToString();
                tbLastName.Text = selected.Cells["LastName"].Value.ToString();
                //tbDateOFBirth.Text = selected.Cells["DateOfBirth"].Value.ToString();
                tbDatePick.Text = selected.Cells["DateofBirth"].Value.ToString();
                   


                cbListGender.Text = selected.Cells["GenderName"].Value.ToString();
                tbStreetAddress.Text = selected.Cells["StreetAddress"].Value.ToString();
                tbCity.Text = selected.Cells["City"].Value.ToString();
                tbdropParish.Text = selected.Cells["ParishName"].Value.ToString();
               
                
                GridViewPatients.SelectedRows[0].Cells[0].Value.ToString();
                
                int CalulateAge()
                {
                    var today = DateTime.Now;
                    int dob = Convert.ToInt32(tbDatePick.Value);
                    int age = today.Year - dob;
                   
                    tbAge.Text = age.ToString();    
                    return age;
                }
               

               

                
              
            }
            catch (Exception)
            {

            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            var loginPage = new loginPage();
            loginPage.Show();
            Hide();
        }
    }
}


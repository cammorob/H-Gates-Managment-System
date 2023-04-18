using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Gates_Managment__System
{
    

    //private readonly HGatesDesktopApp _db;

    public partial class View_Emergency_contact : Form
        

    {
        private readonly HGatesDesktopAppEntities2 _db;

        //private readonly HGatesDesktopApp _db;
        public View_Emergency_contact()
        {
            
            InitializeComponent();
            _db = new HGatesDesktopAppEntities2();
            // _db = new HGatesDesktopApp();
            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Emergencydgv.Refresh();
            
            Hide();
        }
       
        private void View_Emergency_contact_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hGatesDesktopAppDataSet.ViewEmergencyContact' table. You can move, or remove it, as needed.
            this.viewEmergencyContactTableAdapter.Fill(this.hGatesDesktopAppDataSet.ViewEmergencyContact);
            //populate address and Relationship list for update when necessary
            var addr = _db.Parishes.ToList();
            tbEAddress.DisplayMember = "ParishName";
            tbEAddress.ValueMember = "Id";
            tbEAddress.DataSource = addr;

            var relation =_db.EmergencyRelationships.ToList();
            tbERelationship.DisplayMember = "RelationshipType";
            tbERelationship.ValueMember = "Id";
            tbERelationship.DataSource = relation;
                


            //PatientList patientList = new PatientList();
            var patient = _db.Patients.FirstOrDefault(x => x.Id == PatientList.rowid);
            var Contactname = patient.ContactName;
            var Erelation = _db.EmergencyRelationships.FirstOrDefault(r => r.Id == r.Id);
            var erelation = Erelation.RelationshipType;
            var PName = _db.Parishes.FirstOrDefault(p=>p.Id == p.Id);
            var pName = PName.ParishName;

            try
            {
            RefreshGrid();
                



            }
            catch (Exception)
            {

                throw;
            }
        }


        void RefreshGrid()
        {

            try
            {
                /* // var connstring = "Server= DESKTOP-CVIOCU7\\SQLEXPRESS; Initial Catalog=HGateDesktopAdd;Intergrated Security=true";
                 //var connstring = "data source=DESKTOP-CVIOCU7\\SQLEXPRESS;initial catalog=HGatesDesktopApp;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                 SqlConnection conn = new SqlConnection(connstring);
                 conn.Open();




                 SqlCommand cmd = new SqlCommand("Select Patients.ContactName, Patients.ContactAddress,EmergencyRelationships.RelationshipType,Patients.EContactNo from [dbo].[Patients]" +
                    " inner join [dbo].EmergencyRelationships  on Patients.Id =EmergencyRelationships.Id", conn);
                 //"inner join [dbo].Parishes on [dbo].Patients.Id=Parishes.Id", conn);
                 SqlDataAdapter adapter = new SqlDataAdapter();
                 adapter.SelectCommand = cmd;
                 DataTable dataTable = new DataTable();
                 adapter.Fill(dataTable);

                 */
                _db.
                Emergencydgv.Refresh();
                





                
            }
            catch (Exception ex) 
            {
            
            
            
            
            }
           
        }

        int GetSelectedRow()
        {
            int row = (int)Emergencydgv.SelectedRows[0].Cells[0].Value;
            return row;
        }
        Patient GetPatientByID(int Id)
        {
            var patient = _db.Patients.Find(Id);
            return patient;
        }
        EmergencyRelationship GetEID(int Id)
        {
            var erelation = _db.EmergencyRelationships.Find(Id);
            return erelation;

        }

        Parish GetPID(int Id)
        {
            var pName = _db.Parishes.Find(Id);
            return pName;


        }



        //Update Emergency Contact
        private void btUpDateEmergency_Click(object sender, EventArgs e)
        {

            int rowid = PatientList.rowid;
            try
            {
                {
                    var patient = GetPatientByID(rowid);
                    var erelation = GetEID(rowid);
                    var pName = GetPID(rowid);
                    patient.ContactName = tbEName.Text;
                    patient.EContactNo = tbENumber.Text;
                    patient.ContactAddress =tbEAddress.SelectedValue.ToString() ;
                    patient.ERelationshipID = (int)tbERelationship.SelectedValue;
                    // patient.


                    _db.SaveChanges();
                    RefreshGrid();
                    MessageBox.Show("Patient successfully updated.");

                    RefreshGrid();







                }
            }
            catch (Exception)

            {

                MessageBox.Show("Server Unreachable, Please contact Administrator.");
            }


        }

        private void TbEDelete_Click(object sender, EventArgs e)
        {

            int rowid = PatientList.rowid;
            
            try
            {
                var patient = GetPatientByID(rowid);
                patient.ContactName = tbEName.Text;
                patient.EContactNo = tbENumber.Text;
                patient.ContactName = tbEAddress.Text;
                
                _db.SaveChanges();
                MessageBox.Show("Record Delete Successfully.");
                RefreshGrid();









            }
            catch (Exception)

            {

                MessageBox.Show("Server Unreachable, Please contact Administrator.");
            }










        }
    }
}

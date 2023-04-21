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

    public partial class tbshowRelation : Form
        

    {
        private readonly HGatesDesktopAppEntities2 _db;

        //private readonly HGatesDesktopApp _db;
        
        public tbshowRelation()
        {
            
            InitializeComponent();
            
            _db = new HGatesDesktopAppEntities2();
            // _db = new HGatesDesktopApp();
           
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            tbERelation.Clear();
            tbDisplayEname.Clear(); 
            tbContactAddress.Clear();
            tbContactNumber.Clear();    
            
            Hide();
        }
       
        private void View_Emergency_contact_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hGatesDesktopAppDataSet.ViewEmergencyContact' table. You can move, or remove it, as needed.
            //populate address and Relationship list for update when necessary
            var addr = _db.Parishes.ToList();
            tbEAddress.DisplayMember = "ParishName";
            tbEAddress.ValueMember = "Id";
            tbEAddress.DataSource = addr;

            var relation =_db.EmergencyRelationships.ToList();
            tbERelationship.DisplayMember = "RelationshipType";
            tbERelationship.ValueMember = "Id";
            tbERelationship.DataSource = relation;



            


      
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

            UpDateEmergencyContact upDateEmergencyContact = new UpDateEmergencyContact();
            upDateEmergencyContact.Show();

            /*
                    var patient = GetPatientByID(rowid);
                    var erelation = GetEID(rowid);
                    var pName = GetPID(rowid);
                    patient.ContactName = tbEName.Text;
                    patient.EContactNo = tbENumber.Text;
                    patient.ContactAddress =tbEAddress.SelectedValue.ToString() ;
                    patient.ERelationshipID = (int)tbERelationship.SelectedValue;
                    // patient.


                    _db.SaveChanges();
                   
                    MessageBox.Show("Patient successfully updated.");
            */



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
              









            }
            catch (Exception)

            {

                MessageBox.Show("Server Unreachable, Please contact Administrator.");
            }










        }

        
    }
}

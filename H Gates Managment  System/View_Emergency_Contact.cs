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
            Hide();
           


        }





        

        
    }
}

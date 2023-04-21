using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Gates_Managment__System
{
    public partial class UpDateEmergencyContact : Form
    {
        private readonly HGatesDesktopAppEntities2 _db;
        public UpDateEmergencyContact()
        {
            _db = new HGatesDesktopAppEntities2();
            InitializeComponent();
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


        private void UpDateEmergencyContact_Load(object sender, EventArgs e)
        {
            var addr = _db.Parishes.ToList();
            tbEAddress.DisplayMember = "ParishName";
            tbEAddress.ValueMember = "Id";
            tbEAddress.DataSource = addr;

            var relation = _db.EmergencyRelationships.ToList();
            tbERelationship.DisplayMember = "RelationshipType";
            tbERelationship.ValueMember = "Id";
            tbERelationship.DataSource = relation;
        }

        private void btUpDateEmergency_Click_1(object sender, EventArgs e)
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
                    patient.ContactAddress = tbEAddress.SelectedValue.ToString();
                    patient.ERelationshipID = (int)tbERelationship.SelectedValue;
                    // patient.


                    _db.SaveChanges();

                    MessageBox.Show("Patient successfully updated.");
                }
            }
            catch { }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Gates_Managment__System
{
    

    //private readonly HGatesDesktopApp _db;

    public partial class View_Emergency_contact : Form
        

    {
        private readonly HGatesDesktopAppEntities _db;

        //private readonly HGatesDesktopApp _db;
        public View_Emergency_contact()
        {
            InitializeComponent();
            _db = new HGatesDesktopAppEntities();
            // _db = new HGatesDesktopApp();

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Hide();
        }
        //public static int Rowid;
        private void View_Emergency_contact_Load(object sender, EventArgs e)
        {

            //PatientList patientList = new PatientList();
            var patient = _db.Patients.FirstOrDefault(x => x.Id == PatientList.rowid);
            var Contactname = patient.ContactName;
           
            try
            {
            RefreshGrid();
                



            }
            catch (Exception)
            {

                throw;
            }
        }
       /* Patient GetSelectedRow(int Id)
        {
            var patient = _db.Patients.Find(Id);
            return patient;

        }*/



        void RefreshGrid()
        {


            try
            {
                var pd = _db.Patients.FirstOrDefault(x => x.Id == PatientList.rowid);
                var emergency = _db.Patients.Where(x => x.Id == PatientList.rowid).Select(q => new

                {
                    q.ContactName,
                    q.EmergencyRelationship,
                    q.ERelationshipID,
                    q.EContactNo
                }
                 ).ToList();
                Emergencydgv.DataSource = emergency;
            }
            catch (Exception)
            {

                throw;
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



        private void btUpDateEmergency_Click(object sender, EventArgs e)
        {
            
            int rowid=PatientList.rowid;
            try
            {
                var patient = GetPatientByID(rowid);
                patient.ContactName = tbEName.Text;
                patient.EContactNo=tbENumber.Text;
                patient.ContactName =tbEAddress.Text ;
                patient.
              

                _db.SaveChanges();
                RefreshGrid();
                MessageBox.Show("Patient successfully updated.");

           // RefreshGridView();







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

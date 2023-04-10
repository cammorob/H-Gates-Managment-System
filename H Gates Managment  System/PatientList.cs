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

namespace H_Gates_Managment__System
{
    public partial class PatientList : Form
    {
        private MainPage mainPage;
        private readonly HGatesDesktopAppEntities _db;
        public PatientList()
        {
            InitializeComponent();
            _db = new HGatesDesktopAppEntities();
        }

        public PatientList(MainPage _mainPage)
        {
            InitializeComponent();
            mainPage = _mainPage;
            
        
        }


        private void PatientsManagement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PatientList_Load(object sender, EventArgs e)
        {

            var Patient = _db.Patients.Select(q => new {q.Id,q.FirstName,q.LastName,q.DateOfBirth, q.GenderID}).ToList();
            
            dgvPatients.DataSource = Patient;
             
;            

           /* dgvPatients.Columns[0].HeaderText = "ID" ;
            dgvPatients.Columns[1].HeaderText = "First Name";
            dgvPatients.Columns[2].HeaderText = "Last Name";
            dgvPatients.Columns[3].HeaderText = "Date of Birth";
            dgvPatients.Columns[4].HeaderText = "Gender";*/
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
    }
}

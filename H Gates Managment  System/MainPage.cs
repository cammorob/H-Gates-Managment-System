using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Gates_Managment__System
{
    public partial class MainPage : Form
    {

        private readonly HGatesDesktopAppEntities2 _db;
        private loginPage _LoginPage;
        public string _RoleName;
        public User _user;

        public MainPage()
        {
            InitializeComponent();
            _db = new HGatesDesktopAppEntities2();

        }

        public MainPage(loginPage LoginPage, User user )
        {
            InitializeComponent();
            _LoginPage = LoginPage;
            _user = user;

            _RoleName= user.UserRoles.FirstOrDefault().Role.ShortName;
            


        }



        private void BtViewPatients_Click(object sender, EventArgs e)
        {

            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "PatientList");
            if (!isOpen)
            {
                var Patientlist = new PatientList();

                Patientlist.Show();
                Hide();
            }
        }


        public void ShowUser()
        {

            var username = _user.User1;
            stripstatuslabel.Text = $"Logged in As: {username}";

        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            try
            {
               ShowUser();
                if (_RoleName.Trim() != "admin")
                {

                    btAdminstration.Enabled = false;


                }
            } catch
            {
                
            } 
          
           




        }



        private void btLogout_Click(object sender, EventArgs e)
        {
            _LoginPage = new loginPage();
            _LoginPage.Show();
            Hide();
        }

        private void bAddPatients_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "PatientEntry");
            if (!isOpen)
            {
                var PatientEntry = new PatientsEntry();

                PatientEntry.Show();
                Hide();
            }
        }

        private void LabelAddPatients_Click(object sender, EventArgs e)
        {

            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "PatientEntry");
            if (!isOpen)
            {
                var PatientEntry = new PatientsEntry();

                PatientEntry.Show();
                Hide();
            }
        }

        private void Intake_Pagebt_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "IntakePage");
            if (!isOpen)
            {
                var Intake_Page = new IntakePage();

                Intake_Page.Show();
                Hide();
            }


        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            _LoginPage.Close();
        }

        private void btAdminstration_Click(object sender, EventArgs e)
        {
            try
            {
                var OpenForms = Application.OpenForms.Cast<Form>();
                var isOpen = OpenForms.Any(q => q.Name == "Administration");
                if (!isOpen)
                {
                    
                    var Administration = new Administration();
                    Administration.MdiParent = MdiParent;
                    Administration.Show();
                    Hide();
                    
                }
            }
            catch
            { 
            
            
            
            
            }

           
        }
    }
}
    

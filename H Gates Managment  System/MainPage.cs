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
        private loginPage _LoginPage;
        

        public MainPage()
        {
            InitializeComponent();
           
        }

        public MainPage(loginPage LoginPage )
        { 
        
        InitializeComponent( );
            _LoginPage = LoginPage;
            
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            _LoginPage.Show();
            Hide();
        }

        private void BtViewPatients_Click(object sender, EventArgs e)
        {
           
            var PatientList=new PatientList();
            PatientList.Show();
            Hide();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            if(loginPage.CurrentUser!= null)
            {
                C_UserLabel.Text = loginPage.CurrentUser;
            }
        }
       
       

        private void btLogout_Click(object sender, EventArgs e)
        {
            var loginPage =new loginPage(); 
            loginPage.Show();
            Hide();
        }

        private void bAddPatients_Click(object sender, EventArgs e)
        {
            var PatientsEntry = new PatientsEntry();
            PatientsEntry.Show();
            Hide();
        }

        private void LabelAddPatients_Click(object sender, EventArgs e)
        {
            var PatientsEntry = new PatientsEntry();
            PatientsEntry.Show();
            Hide();
        }

        private void Intake_Pagebt_Click(object sender, EventArgs e)
        {
            var Intake_Page = new IntakePage();
            Intake_Page.Show();
            Hide();


        }
    }
    }
    

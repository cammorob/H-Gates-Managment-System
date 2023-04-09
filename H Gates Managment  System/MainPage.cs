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
        private void label3_Click(object sender, EventArgs e)
        {
            var patientList = new PatientList();
            patientList.Show();

        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            _LoginPage.Close();
        }
    }
}

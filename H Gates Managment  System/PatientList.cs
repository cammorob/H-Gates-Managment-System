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
    public partial class PatientList : Form
    {
        private MainPage mainPage; 
        public PatientList()
        {
            InitializeComponent();
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

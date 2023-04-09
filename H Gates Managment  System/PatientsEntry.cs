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
    public partial class PatientsEntry : Form
    {
        public PatientsEntry()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void PatientsEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            var MainPage = new MainPage();
            MainPage.Show();
            Hide();
        }
    }
}

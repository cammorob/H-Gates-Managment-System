using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Gates_Managment__System
{
    public partial class Administration : Form
    {
        public string label;
        private readonly HGatesDesktopAppEntities2 _db;
        public Administration()
        {
            InitializeComponent();
            _db = new HGatesDesktopAppEntities2();
            
        }

        private void BtAddNewUser_Click(object sender, EventArgs e)
        {

        }

        private void BtEditUser_Click(object sender, EventArgs e)
        {

        }

        private void btDeactivate_Click(object sender, EventArgs e)
        {

        }

        private void doctorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label = "Doctors List";
            HeaderLabel();
            var doctors = _db.Doctors.Select(q => new { Name = q.FirstName + " " + q.LastName, Specialization = q.Specialization.SpecializationName, q.LicensureDate }).ToList();
            dgvUsers.DataSource = doctors;
        }

        private void nursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            label = "Nurse List";
            HeaderLabel();
            var nurses = _db.Nurses.Select(q => new { Name = q.FirstName + " " + q.LastName, q.LicensureDate, Assign_Doctor = q.Doctor.LastName }).ToList();
            dgvUsers.DataSource = nurses;


        }

        public void HeaderLabel()
        {
            lblHeader.Text = label.ToString();
        
        }
    }
}

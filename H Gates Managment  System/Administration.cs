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
            var AddNurse = new AddNurse();
            AddNurse.MdiParent = MdiParent;
            AddNurse.ShowDialog();
        }

        private void BtEditUser_Click(object sender, EventArgs e)
        {

        }

        private void btDeactivate_Click(object sender, EventArgs e)
        {

        }

        private void doctorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label = "Manage Doctors";
            HeaderLabel();
            var doctors = _db.Doctors.Select(q => new { Name = q.FirstName + " " + q.LastName, Specialization = q.Specialization.SpecializationName, q.LicensureDate }).ToList();
            dgvUsers.DataSource = doctors;
        }

        private void nursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
          GetNurses();


        }

        public void HeaderLabel()
        {
            lblHeader.Text = label.ToString();
        
        }

        private void otherUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Users_Administration = new Users_Administration();
            Users_Administration.MdiParent = MdiParent;
            Users_Administration.ShowDialog();
            
        }

        private void Administration_Load(object sender, EventArgs e)
        {

        }

        public void GetNurses()
        {

            label = "Manage Nurses";
            HeaderLabel();
            var nurses = _db.Nurses.Select(q => new { q.Id, Name = q.FirstName + " " + q.LastName, q.LicensureDate, Assign_Doctor = q.Doctor.LastName }).ToList();
            dgvUsers.DataSource = nurses;
            dgvUsers.Columns ["Id"].Visible = false;


        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvUsers.SelectedRows[0].Cells["Id"].Value;
                var nurse = _db.Nurses.FirstOrDefault(q => q.Id == id);
                var AddNurse = new AddNurse(nurse);
                AddNurse.MdiParent = (this.MdiParent);
                AddNurse.Show();
            }
            catch { }
            }

        private void Administration_FormClosing(object sender, FormClosingEventArgs e)
        {
            var MainPage=new MainPage();
            MainPage.Show();

        }
    }
}

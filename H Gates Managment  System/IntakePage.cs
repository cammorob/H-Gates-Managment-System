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
    public partial class IntakePage : Form
    {
        //private readonly HGatesDesktopApp _db;

        private readonly HGatesDesktopAppEntities2 _db;
        public IntakePage()
        {
           // _db = new HGatesDesktopApp();
           _db = new HGatesDesktopAppEntities2();


            InitializeComponent();

            if (loginPage.CurrentUser != null)
            {
                C_UserLabel.Text = loginPage.CurrentUser;
            }
        }

        private void intakeListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var IntakeList = new AdmitToIntake();
            
            IntakeList.Show();


        }

       /* private void intakeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var IntakeManagement  = new IntakeManagement();
            IntakeManagement.MdiParent = this.MdiParent;
            IntakeManagement.Show();


        }*/

        private void IntakePage_Load(object sender, EventArgs e)
        {
            var Intake = _db.Intakes.Select(w => new {w.Id,
                Name = w.Patient.FirstName + " " + w.Patient.LastName,
                Intake_Date = w.IntakeDate,
                Condition = w.Condition.ConditionName,
                Procedure = w.Procedure.ProcedureName,
                Doctor = w.Doctor.LastName,
                Room = w.Room.RoomNumber,
            }).ToList();
            dgvIntakelist.DataSource = Intake;
            dgvIntakelist.Columns["Id"].Visible = false;
        }

        private void BTHome_Click(object sender, EventArgs e)
        {
            var MainPage = new MainPage();
            MainPage.Show();
            Hide();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            var loginPage = new loginPage();
            loginPage.Show();
            Hide();
        }

        private void addRecord_Click(object sender, EventArgs e)
        {
            AdmitToIntake admitToIntake = new AdmitToIntake();
            admitToIntake.MdiParent = this.MdiParent;
            admitToIntake.Show();

        }

        private void editRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvIntakelist.SelectedRows[0].Cells["Id"].Value;
                var patients = _db.Intakes.FirstOrDefault(q => q.Id == id);
                var AdmitToIntake = new AdmitToIntake(patients);
                AdmitToIntake.MdiParent = (this.MdiParent);
                AdmitToIntake.Show();
            }
            catch { }   
        }

        private void deleteRecord_Click(object sender, EventArgs e)
        {
            var id = (int)dgvIntakelist.SelectedRows[0].Cells["Id"].Value;
            var patients = _db.Intakes.FirstOrDefault(q => q.Id == id);
            _db.Intakes.Remove(patients);
            _db.SaveChanges();
            dgvIntakelist.Refresh();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            var id = (int)dgvIntakelist.SelectedRows[0].Cells["Id"].Value;
            var patients = _db.Intakes.FirstOrDefault(q => q.Id == id);
            _db.Intakes.Remove(patients);
            _db.SaveChanges();
            dgvIntakelist.Refresh();

        }

       
    }
    }

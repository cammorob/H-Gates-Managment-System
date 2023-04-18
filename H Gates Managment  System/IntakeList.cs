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
    public partial class IntakeList : Form
    {
        //private readonly HGatesDesktopApp _db;

        private readonly HGatesDesktopAppEntities2 _db;
        public IntakeList()
        {
            _db = new HGatesDesktopAppEntities2 ();
            //_db = new HGatesDesktopApp();   
            InitializeComponent();
        }

        private void IntakeList_Load(object sender, EventArgs e)
        {


            

            var Patient_First_Name = _db.Patients.ToList();
            cbPatient_First_Name.DisplayMember = "FirstName";
            cbPatient_First_Name.ValueMember = "Id";
            cbPatient_First_Name.DataSource = Patient_First_Name;

            var Condition = _db.Conditions.ToList();
            cbCondition.DisplayMember = "ConditionName";
            cbCondition.ValueMember = "Id";
            cbCondition.DataSource = Condition;

            var Procedure = _db.Procedures.ToList();
            cbProcedure.DisplayMember = "ProcedureName";
            cbProcedure.ValueMember = "Id";
            cbProcedure.DataSource = Procedure;

            var Doctors_Last_Name = _db.Doctors.ToList();
            cbDoctors_Last_Name.DisplayMember = "LastName";
            cbDoctors_Last_Name.ValueMember = "Id";
            cbDoctors_Last_Name.DataSource = Doctors_Last_Name;

            var Room = _db.Rooms.ToList();
            cbRoom.DisplayMember = "RoomNumber";
            cbRoom.ValueMember = "Id";
            cbRoom.DataSource = Room;

        }

        private void Intake_Submitbt_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Submition Complete");
            var Intake_Date = dpIntake_Date.Value;
            var IntakeList = new Intake();
            IntakeList.PatientID = (int)cbPatient_First_Name.SelectedValue;
            IntakeList.ConditionID = (int)cbCondition.SelectedValue;
            IntakeList.ProcedureID = (int)cbProcedure.SelectedValue;
            IntakeList.DoctorID = (int)cbDoctors_Last_Name.SelectedValue;
            IntakeList.RoomID = (int)cbRoom.SelectedValue;
            IntakeList.IntakeDate = Intake_Date; 


            _db.Intakes.Add(IntakeList);
            _db.SaveChanges();







        }
    }
}

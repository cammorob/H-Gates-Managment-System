using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Gates_Managment__System
{
    public partial class AdmitToIntake : Form
    {
        //private readonly HGatesDesktopApp _db;
        private bool isEditMode;
        private readonly HGatesDesktopAppEntities2 _db;
        public AdmitToIntake()
        {
            _db = new HGatesDesktopAppEntities2();
            //_db = new HGatesDesktopApp();   
            InitializeComponent();
            IdLblL.Text = "Admit to Intake";
               
            isEditMode = false;

        }
        //Constructure Overloaded 
        public AdmitToIntake(Intake IntakeEdit)
        {
            _db = new HGatesDesktopAppEntities2();
            //_db = new HGatesDesktopApp();   
            InitializeComponent();
           
            IdLblL.Text = "Edit Record";
            PopulateTable(IntakeEdit);
            isEditMode = true;

        }

        private void PopulateTable(Intake IntakeEdit)
        {
            lblID.Text = IntakeEdit.Id.ToString();
            cbPatient_First_Name.Text = IntakeEdit.Patient.FirstName;
            dpIntake_Date.Value = IntakeEdit.IntakeDate;
            cbCondition.Text = IntakeEdit.Condition.ConditionName;
            cbProcedure.Text = IntakeEdit.Procedure.ProcedureName;
            cbDoctors_Last_Name.Text = IntakeEdit.Doctor.LastName;
            cbRoom.Text = IntakeEdit.Room.RoomNumber;
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

            try {
                if (isEditMode)

                {
                    if (MessageBox.Show("Do You Want To edit This Record", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var id = int.Parse(lblID.Text);
                        var IntakeList = _db.Intakes.FirstOrDefault(q => q.Id == id);
                        var Intake_Date = dpIntake_Date.Value;

                        IntakeList.PatientID = (int)cbPatient_First_Name.SelectedValue;
                        IntakeList.ConditionID = (int)cbCondition.SelectedValue;
                        IntakeList.ProcedureID = (int)cbProcedure.SelectedValue;
                        IntakeList.DoctorID = (int)cbDoctors_Last_Name.SelectedValue;
                        IntakeList.RoomID = (int)cbRoom.SelectedValue;
                        IntakeList.IntakeDate = Intake_Date;
                        _db.SaveChanges();
                        IntakePage intakePage = new IntakePage();
                        intakePage.Refresh();
                    }
                }
                else
                {

                    var newIntake = new Intake();
                    newIntake.PatientID = (int)cbPatient_First_Name.SelectedValue;
                    newIntake.ConditionID = (int)cbCondition.SelectedValue;
                    newIntake.ProcedureID = (int)cbProcedure.SelectedValue;
                    newIntake.DoctorID = (int)cbDoctors_Last_Name.SelectedValue;
                    newIntake.RoomID = (int)cbRoom.SelectedValue;
                    newIntake.IntakeDate = dpIntake_Date.Value;
                    _db.Intakes.Add(newIntake);
                    _db.SaveChanges();
                    IntakePage intakePage = new IntakePage();
                    intakePage.Refresh();
                    MessageBox.Show("Record added");
                    if (MessageBox.Show("Do you want to add another record", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) 
                    {
                    
                        Close();
                    
                    
                    }

                }
              

            }
            catch
            {
                MessageBox.Show("An unexpected error has occured, plesae contact you administrator");
            
            }
        }

        private void tbExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    } }

﻿using System;
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
    public partial class IntakeManagement : Form
    {
        private readonly HGatesDesktopApp _db;

       // private readonly HGatesDesktopAppEntities _db;


        public IntakeManagement()
        {
            _db = new HGatesDesktopApp();
            //_db = new HGatesDesktopAppEntities();
            InitializeComponent();
        }

        private void IntakeManagement_Load(object sender, EventArgs e)
        {


            //var Intake = _db.Intakes.ToList();
            var Intake = _db.Intakes.Select(w => new { ID = w.PatientID, Intake_Date = w.IntakeDate, Condition = w.ConditionID, Procedure = w.ProcedureID, Doctor = w.DoctorID, Room = w.RoomID} ) . ToList();
            dvIntake_Managment_list.DataSource = Intake;


        }
    }
}

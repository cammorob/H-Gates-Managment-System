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
    public partial class AddNurse : Form
    {
        private readonly HGatesDesktopAppEntities2 _db;
        private Administration administration;
        private bool AddMode;
        public AddNurse()
        {
            InitializeComponent();
            _db = new HGatesDesktopAppEntities2();
            administration = new Administration();

        }

        public AddNurse(Nurse nurse)
        {
            InitializeComponent();
            _db = new HGatesDesktopAppEntities2();
            administration = new Administration();
            PopulateField(nurse);

        }

        public void PopulateField(Nurse nurse)
        {
            tbFirstNames.Text = nurse.FirstName;
            tblastName.Text = nurse.LastName;
            //NurseLicenceDate =nurse.LicensureDate;
            cbAssignDoctor.Text = nurse.DoctorID.ToString();
            var NurseID = (int)nurse.Id;
        }

        public void AddNurse_Load(object sender, EventArgs e)
        {
            var docters = _db.Doctors.ToList();
            cbAssignDoctor.DisplayMember = "FirstName";
            cbAssignDoctor.ValueMember = "Id";
            cbAssignDoctor.DataSource = docters;

        }




        private void btSubmitNurse_Click(object sender, EventArgs e)
        {
            try
            {
                string FirstName = tbFirstNames.Text;
                string LastName = tblastName.Text;

                var shortdate = NurseLicenceDate.Value;
                var AssignDoctor = cbAssignDoctor.SelectedValue;

                if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName))
                {


                    MessageBox.Show("Please Input missing information");



                }
                else
                {

                    var Nurse = new Nurse();
                    Nurse.FirstName = FirstName;
                    Nurse.LastName = LastName;
                    Nurse.LicensureDate = shortdate;
                    Nurse.DoctorID = (int)AssignDoctor;

                    _db.Nurses.Add(Nurse);
                    _db.SaveChanges();
                    MessageBox.Show("Submition Complete");
                    administration.GetNurses();

                }

            }
            catch
            {
                MessageBox.Show("Data entry error");
            }
        }
    }
       

       
    
      /*  private void btUpDate_Click(object sender, EventArgs e, Nurse nurse )
        {
        //var nurse = new Nurse();
            
            nurse.FirstName = tbFirstNames.Text;
            nurse.LastName = tblastName.Text;
            nurse.LicensureDate = NurseLicenceDate.Value;
            nurse.DoctorID = (int)cbAssignDoctor.SelectedValue;
            _db.SaveChanges();*/
        
    
}

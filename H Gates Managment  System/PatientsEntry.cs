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
        //private readonly HGatesDesktopAppEntities _db;
        private readonly HGatesDesktopAppEntities1 _db;
        public PatientsEntry()
        {
            InitializeComponent();
            //_db = new HGatesDesktopAppEntities();
            _db = new HGatesDesktopAppEntities1();
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

        private void Btback_Click(object sender, EventArgs e)
        {
            var MainPage = new MainPage();
            MainPage.Show();
            Hide();

        }

        private void PatientsEntry_Load(object sender, EventArgs e)
        {
            var parish = _db.Parishes.ToList();
            cbParish.DisplayMember = "ParishName";
            cbParish.ValueMember= "Id";
            cbParish.DataSource= parish;

            var relationship =_db.EmergencyRelationships.ToList();
            cbRelationship.DisplayMember = "RelationshipType";
            cbRelationship.ValueMember = "Id";
            cbRelationship.DataSource = relationship;

            var gender = _db.Genders.ToList();
            cbGender.DisplayMember = "ShortName";
            cbGender.ValueMember = "Id";
            cbGender.DataSource = gender;
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {


            string FirstName = tbFirstName.Text;
            string LastName = tbLastName.Text;
            string City = tbCity.Text;
            var date = datePicker.Value;
            var Gender = cbGender.Text;
            //string GenderM = MalePicker.ToString();
            // string Genderf = FemalePicker.ToString();
            string Street = tbStreet.Text;
            var Parish = cbParish.Text;
            var Relationship = cbRelationship.Text;
            string EmfirstName = EfirstName.Text;
            string ELastName = ElastName.Text;
            string Emaddress = Eaddress.Text;
            var Emphone = Ephone.Text;

            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(Street) || string.IsNullOrWhiteSpace(Emphone) || string.IsNullOrWhiteSpace(ELastName) )
            {


                MessageBox.Show("Please Input the rest of the information");



            }
            else
            {

                MessageBox.Show("Submition Complete");

                var PatiensEntry = new Patient();

                PatiensEntry.FirstName = FirstName;
                PatiensEntry.LastName = LastName;
                PatiensEntry.StreetAddress = Street;
                PatiensEntry.ContactName = EmfirstName;
                PatiensEntry.ContactAddress = Emaddress;
                PatiensEntry.EContactNo = Emphone;
                PatiensEntry.City = City;
                PatiensEntry.DateOfBirth = date;
                PatiensEntry.GenderID = (int)cbGender.SelectedValue;
                PatiensEntry.ParishID = (int)cbParish.SelectedValue;
                PatiensEntry.ERelationshipID = (int)cbRelationship.SelectedValue;

                _db.Patients.Add(PatiensEntry);
                _db.SaveChanges();


            }





        }
    }
}

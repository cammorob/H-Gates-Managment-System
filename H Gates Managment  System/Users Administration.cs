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
    public partial class Users_Administration : Form
    {
        private readonly HGatesDesktopAppEntities2 _db;
        public Users_Administration()
        {
            InitializeComponent();
            _db = new HGatesDesktopAppEntities2();
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "AddUser");
            if (!isOpen)
            {
                var adduser = new AddUser(this);
                adduser.MdiParent = this.MdiParent;
                adduser.Show();
            }
            
        }

        private void btEdit_Click(object sender, EventArgs e)
        {

        }

        private void DeAct_Click(object sender, EventArgs e)
        {

            try
            {

                var id = (int)dgvUsers.SelectedRows[0].Cells["Id"].Value;
                var user = _db.Users.FirstOrDefault(x => x.Id == id);

                user.isAcitive = user.isAcitive == true ? true : false;

                if (user.isAcitive == false)
                {
                    MessageBox.Show($"{user.User1}) deactivated");

                }
                else
                {
                    MessageBox.Show($"{user.User1}) Activated");
                }
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error :{ex.Message}");



            }
        }

            private void btResetPassword_Click(object sender, EventArgs e)
            {
                try
                {

                    var id = (int)dgvUsers.SelectedRows[0].Cells["Id"].Value;
                    var user = _db.Users.FirstOrDefault(x => x.Id == id);

                    var genericPassword = "Password@123";
                    var hash_password = Utils.DefaultHashPassword();
                    user.Password = hash_password;
                    _db.SaveChanges();

                    MessageBox.Show($"{user.User1})'s password has been reset!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"error :{ex.Message}");

                }

            }


        public void PopulateGrid()
        {
            var user = _db.Users.Select(q => new {q.Id,q.User1,
            q.UserRoles.FirstOrDefault().Role.Name,q.isAcitive}).ToList();

            dgvUsers.DataSource = user;
            dgvUsers.Columns["User1"].HeaderText = "Username";
            dgvUsers.Columns["Name"].HeaderText = "Role Name";
            dgvUsers.Columns["isAcitive"].HeaderText = "Active/Not Active";
            dgvUsers.Columns["Id"].Visible=false;

        }

        private void Users_Administration_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
} 



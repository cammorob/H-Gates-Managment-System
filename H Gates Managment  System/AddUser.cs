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
    public partial class AddUser : Form
    {
        private readonly HGatesDesktopAppEntities2 _db;
        private Users_Administration users_Administration;
        public AddUser(Users_Administration users_Administration)
        {
            InitializeComponent();
            _db = new HGatesDesktopAppEntities2();
            users_Administration = new Users_Administration();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var role = _db.Roles.ToList();
            cbRoles.DataSource = role;
            cbRoles.ValueMember = "Id";
            cbRoles.DisplayMember = "Name";
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var username = tbUserNames.Text;
                var roleId = (int)cbRoles.SelectedValue;
                var password = Utils.DefaultHashPassword();
                var user = new User

                {
                    User1 = username,
                    Password = password,
                    isAcitive = true,
                };
                _db.Users.Add(user);
                _db.SaveChanges();
                var userid = user.Id;
                var userRole = new UserRole
                {
                    RoleId = roleId,
                    UserId = userid

                };
                _db.UserRoles.Add(userRole);
                _db.SaveChanges();
                MessageBox.Show("New user added");
                users_Administration.PopulateGrid();
                Close();

            }
            catch (Exception ex) 
            {
                MessageBox.Show("An Error has Occured");
            }
        }

        

    }  }


        
            
        


    


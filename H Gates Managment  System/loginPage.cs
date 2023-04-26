using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Gates_Managment__System
{
    public partial class loginPage : Form
    {

        private readonly HGatesDesktopAppEntities2 _db;
       // private readonly HGatesDesktopApp _db;
        public static string CurrentUser = " ";
        
        public loginPage()
        {
            InitializeComponent();
            _db= new HGatesDesktopAppEntities2();
           // _db = new HGatesDesktopApp();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();

                var username = tbUserName.Text.Trim();
                var password = tbPassword.Text;

                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));  
                StringBuilder stringBuilder = new StringBuilder();

                for(int i=0; i<data.Length; i++)
                { 
                    stringBuilder.Append(data[i].ToString("x2")); 
                }
                var hashed_password= stringBuilder.ToString();
                 
                var user =_db.Users.FirstOrDefault(q=>q.User1== username && q.Password == hashed_password);

                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                    tbUserName.Clear();
                    tbPassword.Clear();

                
                }
               

                else
                {
                   var role = user.UserRoles.FirstOrDefault();
                   var roleSname = role.Role.ShortName.TrimEnd();
                   var MainPage = new MainPage(this,roleSname);
                    
                   MainPage.Show();
                   CurrentUser = username;
                   tbUserName.Clear();
                    tbPassword.Clear(); 
                    this.Hide();
                
                }
                


            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please try again");
                tbUserName.Clear();
                tbPassword.Clear();

            }
        }

    }
}

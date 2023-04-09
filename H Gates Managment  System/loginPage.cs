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
    public partial class loginPage : Form
    {

        private readonly HGatesDesktopAppEntities _db;
            public loginPage()
        {
            InitializeComponent();
            _db= new HGatesDesktopAppEntities();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            try
            {
                var username = tbUserName.Text.Trim();
                var password = tbPassword.Text;

                var user =_db.Users.FirstOrDefault(q=>q.username== username && q.password == password);

                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                
                }
                else
                {
                    var MainPage = new MainPage(this);
                    MainPage.Show();
                    Hide();
                
                }



            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please try again");
                
            }
        }

    }
}

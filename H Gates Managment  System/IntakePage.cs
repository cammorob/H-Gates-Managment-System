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
        }

        private void intakeListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var IntakeList = new IntakeList();
            IntakeList.MdiParent = this;
            IntakeList.Show();


        }

        private void intakeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var IntakeManagement  = new IntakeManagement();
            IntakeManagement.MdiParent = this;
            IntakeManagement.Show();


        }
    }
}

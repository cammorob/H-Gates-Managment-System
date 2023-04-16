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
    }
}

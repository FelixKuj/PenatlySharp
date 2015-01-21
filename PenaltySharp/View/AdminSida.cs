using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using PenaltySharp.Model;
using PenaltySharp.Controller;
using System.Windows.Forms;

namespace PenaltySharp.View
{
    public partial class AdminSida : Form
    {
        RegelController regelcontroller;
        public AdminSida()
        {
            InitializeComponent();
            regelcontroller = new RegelController();
        }

        private void btn_AdminSida_Regler_Click(object sender, EventArgs e)
        {
            regelcontroller.VisaRegler();
        }
    }
}

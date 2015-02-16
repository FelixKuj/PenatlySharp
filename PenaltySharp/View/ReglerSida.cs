using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PenaltySharp.Controller;

namespace PenaltySharp.View
{
    public partial class ReglerSida : Form
    {
        public ReglerSida()
        {
            InitializeComponent();
        }
        RegelController regelcontroller;
        public bool skaparegel = false;
        private void reglerSida_btn_LäggaTillRegel_Click(object sender, EventArgs e)
        {
            regelcontroller = ServiceProvider.GetReglerService();
            regelcontroller.TestData();
        }
    }
}

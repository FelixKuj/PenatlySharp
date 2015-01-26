using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenaltySharp.Model;
using PenaltySharp.Controller;
using System.Windows.Forms;

namespace PenaltySharp.View
{
    public partial class AdminSida : Form
    {
        RegelController regelcontroller;
        SpelareController spelarController;
        public AdminSida()
        {
            InitializeComponent();
            regelcontroller = ServiceProvider.GetReglerService();
            spelarController = ServiceProvider.GetSpelareService();
            
        }

        private void btn_AdminSida_Regler_Click(object sender, EventArgs e)
        {
            regelcontroller.VisaRegler();           
            
        }

        private void btn_AdminSida_LoggaUt_Click(object sender, EventArgs e)
        {
            this.Close();          
        }
    }
}

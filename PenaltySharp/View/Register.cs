using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PenaltySharp.Model;
using PenaltySharp.Controller;
using PenaltySharp.View;

namespace PenaltySharp.View
{
    public partial class Register : Form
    {
        SpelareController spelarController;
        public Register()
        {
            InitializeComponent();
            spelarController = new SpelareController();
        }

        private void btn_RegistreringsSida_Registrera_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }
    }
}

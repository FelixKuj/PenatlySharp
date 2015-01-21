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
using PenaltySharp.View;
using System.Windows.Forms;

namespace PenaltySharp.View
{
    public partial class Inloggning : Form
    {

        SpelareController spelarController;
        public Inloggning()
        {
            InitializeComponent();
            spelarController = new SpelareController();
            spelarController.TestData();
        }

        private void btn_InloggningsSida_Inloggning_Click(object sender, EventArgs e)
        {
            string information = spelarController.LoggaIn(tbx_InloggningsSida_Användarnamn.Text, tbx_InloggningsSida_Lösenord.Text);
        }

        private void btn_InloggningsSida_Registrera_Click(object sender, EventArgs e)
        {
            var registerForm = new Register();
            registerForm.Show();
        }

       
    }
}

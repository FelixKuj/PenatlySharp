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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PenaltySharp.View
{
    public partial class Inloggning : Form
    {

        SpelareController spelarController;
        public Inloggning()
        {
            InitializeComponent();
            spelarController = ServiceProvider.GetSpelareService();
            tbx_InloggningsSida_Användarnamn.Focus();
        }

        private void btn_InloggningsSida_Inloggning_Click(object sender, EventArgs e)
        {
            string information = spelarController.LoggaIn(tbx_InloggningsSida_Användarnamn.Text, tbx_InloggningsSida_Lösenord.Text);
            tbx_InloggningsSida_Användarnamn.Clear();
            tbx_InloggningsSida_Lösenord.Clear();
        }

        private void btn_InloggningsSida_Registrera_Click(object sender, EventArgs e)
        {
            var registerForm = new Register();
            registerForm.Show();
        }

        private void tbx_InloggningsSida_Lösenord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_InloggningsSida_Inloggning.PerformClick();
            }
        }

        private void Inloggning_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
    }
}

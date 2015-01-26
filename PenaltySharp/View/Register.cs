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
            spelarController = ServiceProvider.GetSpelareService();
        }

        private void btn_RegistreringsSida_Registrera_Click(object sender, EventArgs e)
        {
            spelarController.SkapaAnvändare(tbx_RegistreringsSida_Förnamn.Text, tbx_RegistreringsSida_Efternamn.Text, tbx_RegistreringsSida_användarnamn.Text, tbx_RegistreringsSida_lösenord.Text, tbx_RegistreringsSida_LösenordIgen.Text, tbx_RegistreringsSida_Email.Text);
            this.Hide();
            
        }
    }
}

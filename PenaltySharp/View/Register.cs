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
        bool FelAnvändarnamn;
        bool FelEfternamn;
        bool FelEmail;
        bool FelFörnamn;
        bool FelLösenord;
        bool FelLösenordsjämförelse;

        public Register()
        {
            InitializeComponent();
            spelarController = ServiceProvider.GetSpelareService();
        }

        private void btn_RegistreringsSida_Registrera_Click(object sender, EventArgs e)
        {
            if (tbx_RegistreringsSida_användarnamn.TextLength >= 6 &&
    tbx_RegistreringsSida_Efternamn.Text != null &&
    tbx_RegistreringsSida_Email.Text.Contains('@') &&
    tbx_RegistreringsSida_Förnamn.Text != null &&
    tbx_RegistreringsSida_lösenord.TextLength >= 6 &&
    tbx_RegistreringsSida_LösenordIgen.Text == tbx_RegistreringsSida_lösenord.Text)
            {
                spelarController.SkapaAnvändare(tbx_RegistreringsSida_Förnamn.Text, tbx_RegistreringsSida_Efternamn.Text, tbx_RegistreringsSida_användarnamn.Text, tbx_RegistreringsSida_lösenord.Text, tbx_RegistreringsSida_LösenordIgen.Text, tbx_RegistreringsSida_Email.Text);
                this.Hide();
            }
            if (tbx_RegistreringsSida_användarnamn.TextLength < 6)
            {
                FelAnvändarnamn = true;
            }
            if (tbx_RegistreringsSida_Efternamn.TextLength < 6)
            {
                FelEfternamn = true;
            }
            if (tbx_RegistreringsSida_Email.Text.Contains('@'))
            {
                FelEmail = true;
            }
            if (tbx_RegistreringsSida_Förnamn.Text != null)
            {
                FelFörnamn = true;
            }
            if (tbx_RegistreringsSida_lösenord.TextLength >= 6)
            {
                FelLösenord = true;
            }
            if (tbx_RegistreringsSida_LösenordIgen.Text == tbx_RegistreringsSida_lösenord.Text)
            {
                FelLösenordsjämförelse = true;
            }
        }
    }
}

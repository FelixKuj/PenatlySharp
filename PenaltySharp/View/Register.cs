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
using System.Net.Mail.MailAddress;

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
        bool FelNågot;
        string FelMedlenade;

        public Register()
        {
            InitializeComponent();
            spelarController = ServiceProvider.GetSpelareService();
        }

        private void btn_RegistreringsSida_Registrera_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < spelarController.Antal(); i++)
            {
                if (tbx_RegistreringsSida_användarnamn.Text == spelarController.GetAnvändarnamn(i))
                {   FelMedlenade += "Användarnamnet existerar redan.\n";
                    FelAnvändarnamn = true;
                    FelNågot = true;
                }
            }
            if (tbx_RegistreringsSida_användarnamn.TextLength <= 6 || tbx_RegistreringsSida_användarnamn.TextLength <= 18)
            {
                FelMedlenade += "Användarnamnet är för kort eller långt.\n";
                FelAnvändarnamn = true;
                FelNågot = true;
            }
            if (tbx_RegistreringsSida_Efternamn.TextLength < 6)
            {
                FelMedlenade += "Har du inget efternamn?\n";
                FelEfternamn = true;
                FelNågot = true;
            }
            //if (tbx_RegistreringsSida_Email.Text.Contains('@') == true)
            //{
            //    FelMedlenade += "Tror inte det där är en Email va.\n";
            //    FelEmail = true;
            //    FelNågot = true;
            //}

            if (tbx_RegistreringsSida_Förnamn.Text != null)
            {
                FelMedlenade += "Har du inget förnamn?\n";
                FelFörnamn = true;
                FelNågot = true;
            }
            if (tbx_RegistreringsSida_lösenord.TextLength >= 6 || tbx_RegistreringsSida_lösenord.TextLength <= 18)
            {
                FelMedlenade += "Lösenorden Är för kort eller långt.\n";
                FelLösenord = true;
                FelNågot = true;
            }
            if (tbx_RegistreringsSida_LösenordIgen.Text == tbx_RegistreringsSida_lösenord.Text)
            {
                FelMedlenade += "Lösenorden Matchar inte.\n";
                FelLösenordsjämförelse = true;
                FelNågot = true;
            }
            if (FelNågot == true)
            {
                MessageBox.Show(FelMedlenade);
            }
            else
            {
                spelarController.SkapaAnvändare(tbx_RegistreringsSida_Förnamn.Text, tbx_RegistreringsSida_Efternamn.Text, tbx_RegistreringsSida_användarnamn.Text, tbx_RegistreringsSida_lösenord.Text, tbx_RegistreringsSida_LösenordIgen.Text, tbx_RegistreringsSida_Email.Text);
                this.Hide();
            }

        }
        //public bool IsValid(string emailaddress)
        //{
        //    try
        //    {
        //        MailAddress m = new MailAddress(emailaddress);

        //        return true;
        //    }
        //    catch (FormatException)
        //    {
        //        return false;
        //    }
        //}
    }
}

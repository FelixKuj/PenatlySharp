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
//using System.Net.Mail.MailAddress;

namespace PenaltySharp.View
{
    public partial class Register : Form
    {
        SpelareController spelarController;
        bool FelNågot;
        string text;
        int textlängd;
        char textchar;
        string FelMeddelnade;

        public Register()
        {
            InitializeComponent();
            spelarController = ServiceProvider.GetSpelareService();
        }
        /// <summary>
        /// kollar igenom alla textboxes i fromen och ser om de är lämpliga för att skapa en användare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RegistreringsSida_Registrera_Click(object sender, EventArgs e)
        {
            FelMeddelnade = "";
            FelNågot = false;
            for (int i = 0; i < spelarController.Antal(); i++) //kollar om användarmanet redan finns
            {
                if (tbx_RegistreringsSida_användarnamn.Text == spelarController.GetAnvändarnamn(i))
                {   FelMeddelnade += "Användarnamnet existerar redan.\n";
                    FelNågot = true;
                }
            }
            if (tbx_RegistreringsSida_användarnamn.TextLength <= 6 || tbx_RegistreringsSida_användarnamn.TextLength >= 18)//om det är för långt eller kort
            {
                FelMeddelnade += "Användarnamnet är för kort eller långt.\n";
                FelNågot = true;
            }
            if (tbx_RegistreringsSida_Efternamn.Text == "") //man måste fylla i ett efternamn
            {
                FelMeddelnade += "Har du inget efternamn?\n";
                FelNågot = true;
            }


            //för att se individuella chars i en text behöver jag veta textens längd och vad texten är.
            text = tbx_RegistreringsSida_Email.Text;
            textlängd = text.Length;
            textchar = ' ';
            for (int i = 0; i < textlängd; i++) //en for-sats för att gå igenom hela texten char för char
            {
                //en string är en lista med chars, så jag sätter charen till att vara stringens list värde
                textchar = text[i];
                if (textchar == '@') //om @ finns i texten så bryts for-satsen och inte läsa av mer utav texten.
                {
                    break;
                }
                else if (textchar != '@' && i + 1 == textlängd) //om @ inte finns i texten efter man sökt igenom hela texten kommer ett felmeddelande att skapas
                {
                    FelMeddelnade += "Tror inte det där är en Email va.\n";
                    FelNågot = true;
                }
            }

            if (tbx_RegistreringsSida_Förnamn.Text == "") //man måste ha ett förnamn
            {
                FelMeddelnade += "Har du inget förnamn?\n";
                FelNågot = true;
            }
            if (tbx_RegistreringsSida_lösenord.TextLength <= 4 || tbx_RegistreringsSida_lösenord.TextLength >= 18) //lösenordet får inte vara för kort/långt
            {
                FelMeddelnade += "Lösenorden är för kort eller långt.\n";
                FelNågot = true;
            }
            if (tbx_RegistreringsSida_LösenordIgen.Text != tbx_RegistreringsSida_lösenord.Text)//man måste skriva in smma lösenord 2 gånger för att vara säker på det
            {
                FelMeddelnade += "Lösenorden Matchar inte.\n";
                FelNågot = true;
            }
            if (FelNågot == true) //om det uppstått ett fel visas detta felmeddelande
            {
                MessageBox.Show(FelMeddelnade);
            }
            else
            {
                //skapar den nya användaren
                spelarController.SkapaAnvändare(tbx_RegistreringsSida_Förnamn.Text,
                    tbx_RegistreringsSida_Efternamn.Text,
                    tbx_RegistreringsSida_användarnamn.Text,
                    tbx_RegistreringsSida_lösenord.Text,
                    tbx_RegistreringsSida_LösenordIgen.Text,
                    tbx_RegistreringsSida_Email.Text);
                this.Hide();
            }

        }
    }
}

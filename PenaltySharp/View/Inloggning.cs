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
        public Inloggning()
        {
            InitializeComponent();
             
        }

        

        private void btn_InloggningsSida_Inloggning_Click(object sender, EventArgs e)
        {
            var användarsidaForm = new Användarsida();
            //var adminsidaForm =

            //if (Spelare == användare)
            //{
            //    användarsidaForm.Show();
            //    this.Hide();
            //}

            //else
            //{
            //    adminsidaForm.Show();
            //    this.Hide();
            //}
         

        }

        private void btn_InloggningsSida_Registrera_Click(object sender, EventArgs e)
        {
            var registerForm = new Register();
            registerForm.Show();
        }
    }
}

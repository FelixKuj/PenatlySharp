﻿using System;
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
            cbx_AdminSida_Spelare.Show();
            for (int index = 0; index < spelarController.Antal(); index++) //lägger till alla spelare i en dropdown lista.
            {
                cbx_AdminSida_Spelare.Items.Add(spelarController.GetAnvändarnamn(index));
            }
            
        }
        /// <summary>
        /// Öppnar regelsida.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AdminSida_Regler_Click(object sender, EventArgs e)
        {
            Form regelsida = new ReglerSida();
            regelsida.Show();      
            
        }
        /// <summary>
        /// Stänger admin sidan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AdminSida_LoggaUt_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void btn_AdminSida_Spelare_Click(object sender, EventArgs e)
        {
            Form spelaresida = new SpelareSida();
            spelaresida.Show();
        }

        private void AdminSida_Load(object sender, EventArgs e) //visar välkomstmeddelande
        {
            label3.Text = "Välkommen Admin " + spelarController.GetNamnOfIndex(spelarController.publicID) + "!";
        }
    }
}

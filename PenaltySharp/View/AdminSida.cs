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
        BöterController bötercontroller;
        /// <summary>
        /// Initialiserar AdminSida.
        /// </summary>
        public AdminSida()
        {
            
            InitializeComponent();
            regelcontroller = ServiceProvider.GetReglerService();
            spelarController = ServiceProvider.GetSpelareService();
            bötercontroller = ServiceProvider.GetBöterService();
            cbx_AdminSida_Spelare.Show();
            for (int index = 0; index < spelarController.Antal(); index++) //lägger till alla spelare i en dropdown lista.
            {
                cbx_AdminSida_Spelare.Items.Add(spelarController.GetAnvändarnamn(index));
            }
            updateListViewBöter();
        }
        /// <summary>
        /// Öppnar regelsida.
        /// </summary>
        /// <param name="sender">btn_AdminSida_Regler</param>
        /// <param name="e">Clickevent</param>
        private void btn_AdminSida_Regler_Click(object sender, EventArgs e)
        {
            Form regelsida = new ReglerSida();
            regelsida.Show();      
            
        }
        /// <summary>
        /// Stänger admin sidan.
        /// </summary>
        /// <param name="sender">btn_AdminSida_LoggaUt</param>
        /// <param name="e">Clickevent</param>
        private void btn_AdminSida_LoggaUt_Click(object sender, EventArgs e)
        {
            this.Close();          
        }
        /// <summary>
        /// Skapar och visar spelarssida.
        /// </summary>
        /// <param name="sender">btn_AdminSida_Spelare</param>
        /// <param name="e">Clickevent</param>
        private void btn_AdminSida_Spelare_Click(object sender, EventArgs e)
        {
            Form spelaresida = new SpelareSida();
            spelaresida.Show();
        }
        /// <summary>
        /// Visar ett välkomstmeddelande.
        /// </summary>
        /// <param name="sender">AdminSida</param>
        /// <param name="e">Loadevent</param>
        private void AdminSida_Load(object sender, EventArgs e)
        {
            label3.Text = "Välkommen Admin " + spelarController.GetNamnOfIndex(spelarController.publicID) + "!";
        }
        private void updateListViewBöter()
        {
            
            lv_AdminSida.Items.Clear();
            string[] columns = new string[2];
            ListViewItem item;
            for (int i = 0; i < bötercontroller.Count(); i++)
            {
                if (bötercontroller.Get(i).getPersonId() == spelarController.publicID)
                {
                    columns[0] = regelcontroller.Get(i).getNamn();
                    columns[1] = regelcontroller.Get(i).getBöter().ToString();
                    item = new ListViewItem(columns);
                    lv_AdminSida.Items.Add(item);
                }
            }
            for (int i = 0; i < columns.Length; i++)
            {

                lv_AdminSida.AutoResizeColumn(i,
                ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        }

        private void cbx_AdminSida_Spelare_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < spelarController.Antal(); i++)
            {
                if (spelarController.GetNamnOfIndex(i) == cbx_AdminSida_Spelare.Items[cbx_AdminSida_Spelare.SelectedIndex].ToString())
                {
                    for (int i1 = 0; i1 < bötercontroller.Count(); i1++)
                    {
                        lv_AdminSida.Items.Clear();
                        string[] columns = new string[2];
                        ListViewItem item;
                        if (bötercontroller.Get(i).getPersonId() == spelarController.GetIndexOfNamn(cbx_AdminSida_Spelare.Items[cbx_AdminSida_Spelare.SelectedIndex].ToString()))
                        {
                            columns[0] = regelcontroller.Get(i).getNamn();
                            columns[1] = regelcontroller.Get(i).getBöter().ToString();
                            item = new ListViewItem(columns);
                            lv_AdminSida.Items.Add(item);
                        }
                    }
                    break;
                }
            }
        }
    }
}

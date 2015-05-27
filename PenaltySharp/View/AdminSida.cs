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
            for (int index = 0; index < spelarController.Antal(); index++) //lägger till alla spelare i en dropdown lista.
            {
                cbx_AdminSida_SpelareBöter.Items.Add(spelarController.GetNamnOfIndex(index));
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

        /// <summary>
        /// Uppdaterar ListView.
        /// </summary>
        private void updateListViewBöter()
        {

            lv_AdminSida.Items.Clear();
            string[] columns = new string[2];

            for (int i = 0; i < bötercontroller.Count(); i++)
            {

                ListViewItem item;
                if (bötercontroller.Get(i).getPersonId() == spelarController.publicID)
                {
                    for (int index = 0; index < bötercontroller.Count(); index++)
                    {
                        if (bötercontroller.Get(index).getPersonId() == i)
                        {
                            columns[0] = regelcontroller.Get(bötercontroller.Get(index).getRegelId()).getNamn();
                            columns[1] = regelcontroller.Get(bötercontroller.Get(index).getRegelId()).getBöter().ToString();
                            item = new ListViewItem(columns);
                            lv_AdminSida.Items.Add(item);
                        }
                    }
                }
            }
            for (int i = 0; i < columns.Length; i++)
            {

                lv_AdminSida.AutoResizeColumn(i,
                ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            for (int index = 0; index < regelcontroller.Count(); index++)
            {
                cbx_AdminSida_LäggTillRegel.Items.Add(regelcontroller.GetNamnOFIndex(index));
            }

        }

        /// <summary>
        /// Visar markerade objektets böter.
        /// </summary>
        /// <param name="sender">Adminsidan</param>
        /// <param name="e">Index event</param>
        private void cbx_AdminSida_Spelare_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < spelarController.Antal(); i++)
            {
                if (spelarController.GetAnvändarnamn(i) == cbx_AdminSida_Spelare.Items[cbx_AdminSida_Spelare.SelectedIndex].ToString())
                {
                    lv_AdminSida.Items.Clear();
                    for (int i1 = 0; i1 < bötercontroller.Count(); i1++)
                    {
                        string[] columns = new string[2];
                        ListViewItem item;
                        if (bötercontroller.Get(i1).getPersonId() == i)
                        {
                            columns[0] = regelcontroller.Get(bötercontroller.Get(i1).getRegelId()).getNamn();
                            columns[1] = regelcontroller.Get(bötercontroller.Get(i1).getRegelId()).getBöter().ToString();
                            item = new ListViewItem(columns);
                            lv_AdminSida.Items.Add(item);
                        }
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// Lägger till en bot på en spelare efter att man fyllt in comboxarna ovan.
        /// </summary>
        /// <param name="sender">btn_AdminSida_Acceptera</param>
        /// <param name="e">Clickevent</param>
        private void btn_AdminSida_Acceptera_Click(object sender, EventArgs e)
        {
            try
            {
                bötercontroller.LäggtillBöter(cbx_AdminSida_SpelareBöter.SelectedIndex, cbx_AdminSida_LäggTillRegel.SelectedIndex);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Öppna meddelande för att betala böter.
        /// </summary>
        /// <param name="sender">lv_AdminSida</param>
        /// <param name="e">Clickevent</param>
        private void lv_AdminSida_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Betala denna böter?","Böter Betalning",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < lv_AdminSida.Items.Count; i++)
                    {
                        if (lv_AdminSida.Items[i].Selected)
                        {
                            lv_AdminSida.Items.RemoveAt(i);
                            regelcontroller.RemoveAt(i);
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        /// <summary>
        /// Visar diagramformuläret.
        /// </summary>
        /// <param name="sender">button1</param>
        /// <param name="e">Clickevent</param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Form diagramsida = new DiagramSida();
            //diagramsida.Show();
        }
    }
}

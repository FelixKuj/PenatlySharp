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
    public partial class Användarsida : Form
    {
        BöterController bötercontroller;
        SpelareController spelarController;
        RegelController regelcontroller;
        public Användarsida()
        {
            InitializeComponent();

            spelarController = ServiceProvider.GetSpelareService();
            regelcontroller = ServiceProvider.GetReglerService();
            bötercontroller = ServiceProvider.GetBöterService();
            updateListViewBöter();
        }
   
        private void lv_Användarsida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Visar ett välkomstmeddelande
        /// </summary>
        /// <param name="sender">Användarsida</param>
        /// <param name="e">Loadevent</param>
        private void Användarsida_Load(object sender, EventArgs e)
        {
            label3.Text = "Välkommen " + spelarController.GetNamnOfIndex(spelarController.publicID) + "!";

        }
        /// <summary>
        /// Stänger ner användarsidan när du trycker på logga ut.
        /// </summary>

        private void btn_Användarsida_LoggaUt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Startar metoden updateListViewRegler när man klickar på knappen regler i användarsidan.
        /// </summary>
        /// <param name="sender">btn_Användarsida_Regler</param>
        /// <param name="e">Clickevent</param>
        private void btn_Användarsida_Regler_Click(object sender, EventArgs e)
        {
            updateListViewRegler();
        }

        /// <summary>
        /// Gör om lv_Användarsida så att den visar regler istället för böter.
        /// </summary>
        private void updateListViewRegler()
        {
            lv_Användarsida.Items.Clear();
            Column1.Text = "Regler";
            string[] columns = new string[2];
            ListViewItem item;
            for (int i = 0; i < regelcontroller.Count(); i++)
            {
                columns[0] = regelcontroller.Get(bötercontroller.Get(i).getBöterId()).getNamn();
                columns[1] = regelcontroller.Get(bötercontroller.Get(i).getBöterId()).getBöter().ToString();
                item = new ListViewItem(columns);
                lv_Användarsida.Items.Add(item);
            }


            for (int i = 0; i < columns.Length; i++)
            {

                lv_Användarsida.AutoResizeColumn(i,
                ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        }

        /// <summary>
        /// Visar lv_Användarsida med böter.
        /// </summary>
        /// <param name="sender">btn_Användarsida_Böter</param>
        /// <param name="e">Clickevent</param>
        private void btn_Användarsida_Böter_Click(object sender, EventArgs e)
        {
            updateListViewBöter();
        }
        /// <summary>
        /// Upptaderar texten i Column1.
        /// </summary>
        private void updateListViewBöter()
        {
            lv_Användarsida.Items.Clear();
            Column1.Text = "Bruten Regel";
            string[] columns = new string[2];
            ListViewItem item;
            for (int i = 0; i < bötercontroller.Count(); i++)
            {
                if (bötercontroller.Get(i).getPersonId() == spelarController.publicID)
                {
                    columns[0] = regelcontroller.Get(i).getNamn();
                    columns[1] = regelcontroller.Get(i).getBöter().ToString();
                    item = new ListViewItem(columns);
                    lv_Användarsida.Items.Add(item);
                }
            }
            for (int i = 0; i < columns.Length; i++)
            {

                lv_Användarsida.AutoResizeColumn(i,
                ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        }

    }
}

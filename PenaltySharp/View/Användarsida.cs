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
        }

        private void lv_Användarsida_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Användarsida_Load(object sender, EventArgs e)
        {
            label3.Text = "Välkommen " + spelarController.publicanvändarnamn + "!";

        }
        /// <summary>
        /// Stänger ner användarsidan när du trycker på logga ut.
        /// </summary>

        private void btn_Användarsida_LoggaUt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Användarsida_Regler_Click(object sender, EventArgs e)
        {
            updateListView();
        }
        private void updateListView()
        {
            Column1.Text = "Regler";
            lv_Användarsida.Items.Clear();
            string[] columns = new string[2];
            ListViewItem item;
            for (int i = 0; i < regelcontroller.Count(); i++)
            {
                columns[0] = regelcontroller.Get(i).getNamn();
                columns[1] = regelcontroller.Get(i).getBöter().ToString();
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
        /// Bestämmer kolumnrubrik.
        /// </summary>

        private void btn_Användarsida_Böter_Click(object sender, EventArgs e)
        {
            Column1.Text = "Bruten Regel";
            lv_Användarsida.Items.Clear();
        }

    }
}

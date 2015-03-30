using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PenaltySharp.Controller;

namespace PenaltySharp.View
{
    public partial class ReglerSida : Form
    {
        RegelController regelcontroller;
        public ReglerSida()
        {
            InitializeComponent();
            regelcontroller = ServiceProvider.GetReglerService();
            updateListView();
        }

        public bool skaparegel = false;

        /// <summary>
        /// Metod för att admin ska kunna lägga till nya regler.
        /// </summary>
        private void reglerSida_btn_LäggaTillRegel_Click(object sender, EventArgs e)
        {
            try
            {
                regelcontroller.Add(new Model.Regler(ReglerSida_tbx_RegelNamn.Text,
                    regelcontroller.Count(),
                    Convert.ToInt32(ReglerSida_tbx_RegelKostnad.Text)));
                updateListView();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Vänligen skriv in en regel och bötersumma innan du läger till en ny regel.");
            }
        }
        /// <summary>
        /// Uppdaterar regellistan när man öppnar sidan, samt när man lägger till en ny regel.
        /// </summary>
        private void updateListView()
        {

            lv_ReglerSida.Items.Clear();
            string[] columns = new string[2];
            ListViewItem item;
            for (int i = 0; i < regelcontroller.Count(); i++)
            {
                columns[0] = regelcontroller.Get(i).getNamn();
                columns[1] = regelcontroller.Get(i).getBöter().ToString();
                item = new ListViewItem(columns);
                lv_ReglerSida.Items.Add(item);
            }
            for (int i = 0; i < columns.Length; i++)
            {

                lv_ReglerSida.AutoResizeColumn(i,
                ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        }
        /// <summary>
        /// Tar bort regler.
        /// </summary>
        private void lv_ReglerSida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    for (int i = 0; i < lv_ReglerSida.Items.Count; i++)
                    {
                        if (lv_ReglerSida.Items[i].Selected)
                        {
                            lv_ReglerSida.Items.RemoveAt(i);
                            regelcontroller.RemoveAt(i);

                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }
    }
}

using PenaltySharp.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenaltySharp.View
{
    public partial class SpelareSida : Form
    {
        SpelareController spelarecontroller;
        
        public SpelareSida()
        {
            spelarecontroller = ServiceProvider.GetSpelareService();
            InitializeComponent();
            updateListView();
        }
        /// <summary>
        /// Upptaderar spelarlistan när man öppnar sidan samt när man lägger till en ny spelare.
        /// </summary>
        private void updateListView()
        {

            lv_SpelareSida.Items.Clear();
            string[] columns = new string[3];
            ListViewItem item;
            for (int i = 0; i < spelarecontroller.Antal(); i++)
            {
                columns[0] = spelarecontroller.Get(i).getNamn();
                columns[1] = spelarecontroller.Get(i).getAnvändarnamn();
                columns[2] = i.ToString();
                item = new ListViewItem(columns);
                lv_SpelareSida.Items.Add(item);
            }
            for (int i = 0; i < columns.Length; i++)
            {

                lv_SpelareSida.AutoResizeColumn(i,
                ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        }
        /// <summary>
        /// Tar bort markerat objekt när man trycker delete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_SpelareSida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    for (int i = 0; i < spelarecontroller.Antal(); i++)
                    {
                        if (lv_SpelareSida.Items[i].Selected)
                        {
                            lv_SpelareSida.Items.RemoveAt(i);
                            spelarecontroller.TaBortVid(i);
                            updateListView();
                            break;
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

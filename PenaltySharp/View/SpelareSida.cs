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
        }
        
        private void SpelareSida_KeyDown(object sender, KeyEventArgs e)
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
                            //regelcontroller.RemoveAt(i);

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

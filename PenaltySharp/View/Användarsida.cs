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
            bötercontroller = new BöterController();
            spelarController = new SpelareController();
            regelcontroller = new RegelController();
        }

        private void btn_Användarsida_Spealre_Click(object sender, EventArgs e)
        {
           
        }

        private void lv_Användarsida_SelectedIndexChanged(object sender, EventArgs e)
        {
            bötercontroller.test1();
        }

        private void Användarsida_Load(object sender, EventArgs e)
        {

        }

        private void btn_Användarsida_Regler_Click(object sender, EventArgs e)
        {
            regelcontroller.VisaRegler();
        }
    }
}

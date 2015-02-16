using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PenaltySharp.Model;
using PenaltySharp.Controller;
using PenaltySharp.View;


namespace PenaltySharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            View.Inloggning inloggningsForm = new Inloggning();
            inloggningsForm.ShowDialog();
        }
    }
}

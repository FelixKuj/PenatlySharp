﻿using System;
using PenaltySharp.Controller;
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
    public partial class DiagramSida : Form
    {
        SpelareController spelarecontroller;
        BöterController bötercontroller;
        public DiagramSida()
        {
            InitializeComponent();
            spelarecontroller = ServiceProvider.GetSpelareService();
            bötercontroller = ServiceProvider.GetBöterService();
        }
        Image BetaldBöter = PenaltySharp.Properties.Resources.betaldböterbild;
        Image ObetaldBöter = PenaltySharp.Properties.Resources.obetaldböterbild;
        Image Diagram = PenaltySharp.Properties.Resources.diagram_bild;
        bool SpelareDiagram = false;
        bool BöterDiagram = false;
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Diagram, 0, 100);
            if (SpelareDiagram)
            {
                for (int i = 0; i < spelarecontroller.Antal(); i++)
                {
                    for (int y = 0; y < bötercontroller.GetAntalBöter(i); y++)
                    {
                        g.DrawImage(ObetaldBöter,45 +  25 * i, 306 - 10*y);
                    }
                }        
                
            }
            if (BöterDiagram)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpelareDiagram = true;
            BöterDiagram = false;
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BöterDiagram = true;
            SpelareDiagram = false;
            Refresh();
        }
    }
}

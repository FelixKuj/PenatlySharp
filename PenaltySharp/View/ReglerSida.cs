﻿using System;
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
        private void reglerSida_btn_LäggaTillRegel_Click(object sender, EventArgs e)
        {
            regelcontroller.Add(new Model.Regler(ReglerSida_tbx_RegelNamn.Text, 0, Convert.ToInt32(ReglerSida_tbx_RegelKostnad.Text)));
            updateListView();
        }
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
                ColumnHeaderAutoResizeStyle.ColumnContent);
            }

        }
    }
}

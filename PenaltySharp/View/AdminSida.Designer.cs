﻿namespace PenaltySharp.View
{
    partial class AdminSida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AdminSida_Regler = new System.Windows.Forms.Button();
            this.btn_AdminSida_Spelare = new System.Windows.Forms.Button();
            this.btn_AdminSida_LoggaUt = new System.Windows.Forms.Button();
            this.lv_AdminSida = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbx_AdminSida_Spelare = new System.Windows.Forms.ComboBox();
            this.cbx_AdminSida_LäggTillRegel = new System.Windows.Forms.ComboBox();
            this.spelareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spelareControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbx_AdminSida_SpelareBöter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AdminSida_Acceptera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spelareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelareControllerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Välkommen!";
            // 
            // btn_AdminSida_Regler
            // 
            this.btn_AdminSida_Regler.Location = new System.Drawing.Point(255, 12);
            this.btn_AdminSida_Regler.Name = "btn_AdminSida_Regler";
            this.btn_AdminSida_Regler.Size = new System.Drawing.Size(75, 23);
            this.btn_AdminSida_Regler.TabIndex = 7;
            this.btn_AdminSida_Regler.Text = "Regler";
            this.btn_AdminSida_Regler.UseVisualStyleBackColor = true;
            this.btn_AdminSida_Regler.Click += new System.EventHandler(this.btn_AdminSida_Regler_Click);
            // 
            // btn_AdminSida_Spelare
            // 
            this.btn_AdminSida_Spelare.Location = new System.Drawing.Point(336, 12);
            this.btn_AdminSida_Spelare.Name = "btn_AdminSida_Spelare";
            this.btn_AdminSida_Spelare.Size = new System.Drawing.Size(75, 23);
            this.btn_AdminSida_Spelare.TabIndex = 8;
            this.btn_AdminSida_Spelare.Text = "Spelare";
            this.btn_AdminSida_Spelare.UseVisualStyleBackColor = true;
            this.btn_AdminSida_Spelare.Click += new System.EventHandler(this.btn_AdminSida_Spelare_Click);
            // 
            // btn_AdminSida_LoggaUt
            // 
            this.btn_AdminSida_LoggaUt.Location = new System.Drawing.Point(697, 9);
            this.btn_AdminSida_LoggaUt.Name = "btn_AdminSida_LoggaUt";
            this.btn_AdminSida_LoggaUt.Size = new System.Drawing.Size(75, 23);
            this.btn_AdminSida_LoggaUt.TabIndex = 9;
            this.btn_AdminSida_LoggaUt.Text = "Logga ut";
            this.btn_AdminSida_LoggaUt.UseVisualStyleBackColor = true;
            this.btn_AdminSida_LoggaUt.Click += new System.EventHandler(this.btn_AdminSida_LoggaUt_Click);
            // 
            // lv_AdminSida
            // 
            this.lv_AdminSida.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_AdminSida.GridLines = true;
            this.lv_AdminSida.Location = new System.Drawing.Point(12, 61);
            this.lv_AdminSida.Name = "lv_AdminSida";
            this.lv_AdminSida.Size = new System.Drawing.Size(756, 389);
            this.lv_AdminSida.TabIndex = 10;
            this.lv_AdminSida.UseCompatibleStateImageBehavior = false;
            this.lv_AdminSida.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Brutna Regler";
            this.columnHeader1.Width = 568;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Böter";
            // 
            // cbx_AdminSida_Spelare
            // 
            this.cbx_AdminSida_Spelare.FormattingEnabled = true;
            this.cbx_AdminSida_Spelare.Location = new System.Drawing.Point(417, 14);
            this.cbx_AdminSida_Spelare.Name = "cbx_AdminSida_Spelare";
            this.cbx_AdminSida_Spelare.Size = new System.Drawing.Size(121, 21);
            this.cbx_AdminSida_Spelare.TabIndex = 14;
            this.cbx_AdminSida_Spelare.SelectedIndexChanged += new System.EventHandler(this.cbx_AdminSida_Spelare_SelectedIndexChanged);
            // 
            // cbx_AdminSida_LäggTillRegel
            // 
            this.cbx_AdminSida_LäggTillRegel.FormattingEnabled = true;
            this.cbx_AdminSida_LäggTillRegel.Location = new System.Drawing.Point(87, 474);
            this.cbx_AdminSida_LäggTillRegel.Name = "cbx_AdminSida_LäggTillRegel";
            this.cbx_AdminSida_LäggTillRegel.Size = new System.Drawing.Size(121, 21);
            this.cbx_AdminSida_LäggTillRegel.TabIndex = 16;
            // 
            // spelareBindingSource
            // 
            this.spelareBindingSource.DataSource = typeof(PenaltySharp.Model.Spelare);
            // 
            // spelareControllerBindingSource
            // 
            this.spelareControllerBindingSource.DataSource = typeof(PenaltySharp.Controller.SpelareController);
            // 
            // cbx_AdminSida_SpelareBöter
            // 
            this.cbx_AdminSida_SpelareBöter.FormattingEnabled = true;
            this.cbx_AdminSida_SpelareBöter.Location = new System.Drawing.Point(214, 474);
            this.cbx_AdminSida_SpelareBöter.Name = "cbx_AdminSida_SpelareBöter";
            this.cbx_AdminSida_SpelareBöter.Size = new System.Drawing.Size(121, 21);
            this.cbx_AdminSida_SpelareBöter.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lägg till regel";
            // 
            // btn_AdminSida_Acceptera
            // 
            this.btn_AdminSida_Acceptera.Location = new System.Drawing.Point(341, 472);
            this.btn_AdminSida_Acceptera.Name = "btn_AdminSida_Acceptera";
            this.btn_AdminSida_Acceptera.Size = new System.Drawing.Size(75, 23);
            this.btn_AdminSida_Acceptera.TabIndex = 19;
            this.btn_AdminSida_Acceptera.Text = "Acceptera";
            this.btn_AdminSida_Acceptera.UseVisualStyleBackColor = true;
            // 
            // AdminSida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 526);
            this.Controls.Add(this.btn_AdminSida_Acceptera);
            this.Controls.Add(this.cbx_AdminSida_SpelareBöter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_AdminSida_LäggTillRegel);
            this.Controls.Add(this.cbx_AdminSida_Spelare);
            this.Controls.Add(this.lv_AdminSida);
            this.Controls.Add(this.btn_AdminSida_LoggaUt);
            this.Controls.Add(this.btn_AdminSida_Spelare);
            this.Controls.Add(this.btn_AdminSida_Regler);
            this.Controls.Add(this.label3);
            this.Name = "AdminSida";
            this.Text = "AdminSida";
            this.Load += new System.EventHandler(this.AdminSida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spelareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelareControllerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AdminSida_Regler;
        private System.Windows.Forms.Button btn_AdminSida_Spelare;
        private System.Windows.Forms.Button btn_AdminSida_LoggaUt;
        private System.Windows.Forms.ListView lv_AdminSida;
        private System.Windows.Forms.ComboBox cbx_AdminSida_Spelare;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cbx_AdminSida_LäggTillRegel;
        private System.Windows.Forms.BindingSource spelareBindingSource;
        private System.Windows.Forms.BindingSource spelareControllerBindingSource;
        private System.Windows.Forms.ComboBox cbx_AdminSida_SpelareBöter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AdminSida_Acceptera;
    }
}
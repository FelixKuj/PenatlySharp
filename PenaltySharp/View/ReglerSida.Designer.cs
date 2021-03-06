﻿namespace PenaltySharp.View
{
    partial class ReglerSida
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
            this.reglerSida_btn_LäggaTillRegel = new System.Windows.Forms.Button();
            this.ReglerSida_tbx_RegelNamn = new System.Windows.Forms.TextBox();
            this.ReglerSida_tbx_RegelKostnad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lv_ReglerSida = new System.Windows.Forms.ListView();
            this.Column_Regler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_Böter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reglerSida_btn_LäggaTillRegel
            // 
            this.reglerSida_btn_LäggaTillRegel.Location = new System.Drawing.Point(12, 404);
            this.reglerSida_btn_LäggaTillRegel.Name = "reglerSida_btn_LäggaTillRegel";
            this.reglerSida_btn_LäggaTillRegel.Size = new System.Drawing.Size(115, 23);
            this.reglerSida_btn_LäggaTillRegel.TabIndex = 2;
            this.reglerSida_btn_LäggaTillRegel.Text = "Lägg till ny regel";
            this.reglerSida_btn_LäggaTillRegel.UseVisualStyleBackColor = true;
            this.reglerSida_btn_LäggaTillRegel.Click += new System.EventHandler(this.reglerSida_btn_LäggaTillRegel_Click);
            // 
            // ReglerSida_tbx_RegelNamn
            // 
            this.ReglerSida_tbx_RegelNamn.Location = new System.Drawing.Point(12, 368);
            this.ReglerSida_tbx_RegelNamn.Name = "ReglerSida_tbx_RegelNamn";
            this.ReglerSida_tbx_RegelNamn.Size = new System.Drawing.Size(239, 20);
            this.ReglerSida_tbx_RegelNamn.TabIndex = 3;
            // 
            // ReglerSida_tbx_RegelKostnad
            // 
            this.ReglerSida_tbx_RegelKostnad.Location = new System.Drawing.Point(286, 368);
            this.ReglerSida_tbx_RegelKostnad.Name = "ReglerSida_tbx_RegelKostnad";
            this.ReglerSida_tbx_RegelKostnad.Size = new System.Drawing.Size(76, 20);
            this.ReglerSida_tbx_RegelKostnad.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Regel namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Regel böter";
            // 
            // lv_ReglerSida
            // 
            this.lv_ReglerSida.AutoArrange = false;
            this.lv_ReglerSida.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column_Regler,
            this.Column_Böter});
            this.lv_ReglerSida.GridLines = true;
            this.lv_ReglerSida.Location = new System.Drawing.Point(16, 13);
            this.lv_ReglerSida.Name = "lv_ReglerSida";
            this.lv_ReglerSida.Size = new System.Drawing.Size(346, 330);
            this.lv_ReglerSida.TabIndex = 7;
            this.lv_ReglerSida.UseCompatibleStateImageBehavior = false;
            this.lv_ReglerSida.View = System.Windows.Forms.View.Details;
            this.lv_ReglerSida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_ReglerSida_KeyDown);
            // 
            // Column_Regler
            // 
            this.Column_Regler.Text = "Regler";
            this.Column_Regler.Width = 255;
            // 
            // Column_Böter
            // 
            this.Column_Böter.Text = "Böter";
            this.Column_Böter.Width = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Extrahera till databas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReglerSida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lv_ReglerSida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReglerSida_tbx_RegelKostnad);
            this.Controls.Add(this.ReglerSida_tbx_RegelNamn);
            this.Controls.Add(this.reglerSida_btn_LäggaTillRegel);
            this.DoubleBuffered = true;
            this.Name = "ReglerSida";
            this.Text = "Regler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reglerSida_btn_LäggaTillRegel;
        private System.Windows.Forms.TextBox ReglerSida_tbx_RegelNamn;
        private System.Windows.Forms.TextBox ReglerSida_tbx_RegelKostnad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Column_Regler;
        private System.Windows.Forms.ColumnHeader Column_Böter;
        public System.Windows.Forms.ListView lv_ReglerSida;
        private System.Windows.Forms.Button button1;
    }
}
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AdminSida_Regler = new System.Windows.Forms.Button();
            this.btn_AdminSida_Spelare = new System.Windows.Forms.Button();
            this.btn_AdminSida_LoggaUt = new System.Windows.Forms.Button();
            this.lv_AdminSida = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_AdminSida_Spelare = new System.Windows.Forms.ComboBox();
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
            this.btn_AdminSida_Regler.Location = new System.Drawing.Point(140, 9);
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
            this.lv_AdminSida.Location = new System.Drawing.Point(12, 161);
            this.lv_AdminSida.Name = "lv_AdminSida";
            this.lv_AdminSida.Size = new System.Drawing.Size(756, 389);
            this.lv_AdminSida.TabIndex = 10;
            this.lv_AdminSida.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bruten regel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(681, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Böter";
            // 
            // cbx_AdminSida_Spelare
            // 
            this.cbx_AdminSida_Spelare.FormattingEnabled = true;
            this.cbx_AdminSida_Spelare.Location = new System.Drawing.Point(417, 14);
            this.cbx_AdminSida_Spelare.Name = "cbx_AdminSida_Spelare";
            this.cbx_AdminSida_Spelare.Size = new System.Drawing.Size(121, 21);
            this.cbx_AdminSida_Spelare.TabIndex = 14;
            // 
            // AdminSida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.cbx_AdminSida_Spelare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_AdminSida);
            this.Controls.Add(this.btn_AdminSida_LoggaUt);
            this.Controls.Add(this.btn_AdminSida_Spelare);
            this.Controls.Add(this.btn_AdminSida_Regler);
            this.Controls.Add(this.label3);
            this.Name = "AdminSida";
            this.Text = "AdminSida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AdminSida_Regler;
        private System.Windows.Forms.Button btn_AdminSida_Spelare;
        private System.Windows.Forms.Button btn_AdminSida_LoggaUt;
        private System.Windows.Forms.ListView lv_AdminSida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_AdminSida_Spelare;
    }
}
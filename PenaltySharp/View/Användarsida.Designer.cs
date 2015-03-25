namespace PenaltySharp.View
{
    partial class Användarsida
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
            this.lv_Användarsida = new System.Windows.Forms.ListView();
            this.Column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Användarsida_LoggaUt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Användarsida_Regler = new System.Windows.Forms.Button();
            this.btn_Användarsida_Böter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_Användarsida
            // 
            this.lv_Användarsida.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column1,
            this.Column2});
            this.lv_Användarsida.GridLines = true;
            this.lv_Användarsida.Location = new System.Drawing.Point(12, 64);
            this.lv_Användarsida.Name = "lv_Användarsida";
            this.lv_Användarsida.Size = new System.Drawing.Size(756, 389);
            this.lv_Användarsida.TabIndex = 3;
            this.lv_Användarsida.UseCompatibleStateImageBehavior = false;
            this.lv_Användarsida.View = System.Windows.Forms.View.Details;
            this.lv_Användarsida.SelectedIndexChanged += new System.EventHandler(this.lv_Användarsida_SelectedIndexChanged);
            // 
            // Column1
            // 
            this.Column1.Text = "Bruten Regel";
            this.Column1.Width = 572;
            // 
            // Column2
            // 
            this.Column2.Text = "Böter";
            this.Column2.Width = 180;
            // 
            // btn_Användarsida_LoggaUt
            // 
            this.btn_Användarsida_LoggaUt.Location = new System.Drawing.Point(697, 13);
            this.btn_Användarsida_LoggaUt.Name = "btn_Användarsida_LoggaUt";
            this.btn_Användarsida_LoggaUt.Size = new System.Drawing.Size(75, 23);
            this.btn_Användarsida_LoggaUt.TabIndex = 4;
            this.btn_Användarsida_LoggaUt.Text = "Logga ut";
            this.btn_Användarsida_LoggaUt.UseVisualStyleBackColor = true;
            this.btn_Användarsida_LoggaUt.Click += new System.EventHandler(this.btn_Användarsida_LoggaUt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Välkommen!";
            // 
            // btn_Användarsida_Regler
            // 
            this.btn_Användarsida_Regler.Location = new System.Drawing.Point(311, 8);
            this.btn_Användarsida_Regler.Name = "btn_Användarsida_Regler";
            this.btn_Användarsida_Regler.Size = new System.Drawing.Size(75, 23);
            this.btn_Användarsida_Regler.TabIndex = 6;
            this.btn_Användarsida_Regler.Text = "Regler";
            this.btn_Användarsida_Regler.UseVisualStyleBackColor = true;
            this.btn_Användarsida_Regler.Click += new System.EventHandler(this.btn_Användarsida_Regler_Click);
            // 
            // btn_Användarsida_Böter
            // 
            this.btn_Användarsida_Böter.Location = new System.Drawing.Point(392, 8);
            this.btn_Användarsida_Böter.Name = "btn_Användarsida_Böter";
            this.btn_Användarsida_Böter.Size = new System.Drawing.Size(75, 23);
            this.btn_Användarsida_Böter.TabIndex = 7;
            this.btn_Användarsida_Böter.Text = "Böter";
            this.btn_Användarsida_Böter.UseVisualStyleBackColor = true;
            this.btn_Användarsida_Böter.Click += new System.EventHandler(this.btn_Användarsida_Böter_Click);
            // 
            // Användarsida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.btn_Användarsida_Böter);
            this.Controls.Add(this.btn_Användarsida_Regler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Användarsida_LoggaUt);
            this.Controls.Add(this.lv_Användarsida);
            this.Name = "Användarsida";
            this.Text = "Användarsida";
            this.Load += new System.EventHandler(this.Användarsida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Användarsida;
        private System.Windows.Forms.Button btn_Användarsida_LoggaUt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Användarsida_Regler;
        private System.Windows.Forms.Button btn_Användarsida_Böter;
        private System.Windows.Forms.ColumnHeader Column1;
        private System.Windows.Forms.ColumnHeader Column2;

    }
}
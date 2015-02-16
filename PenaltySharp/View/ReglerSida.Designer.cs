namespace PenaltySharp.View
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
            this.tbx_ReglerSida_Regel = new System.Windows.Forms.TextBox();
            this.tbx_ReglerSida_Böter = new System.Windows.Forms.TextBox();
            this.reglerSida_btn_LäggaTillRegel = new System.Windows.Forms.Button();
            this.ReglerSida_tbx_RegelNamn = new System.Windows.Forms.TextBox();
            this.ReglerSida_tbx_RegelKostnad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_ReglerSida_Regel
            // 
            this.tbx_ReglerSida_Regel.Location = new System.Drawing.Point(13, 13);
            this.tbx_ReglerSida_Regel.Multiline = true;
            this.tbx_ReglerSida_Regel.Name = "tbx_ReglerSida_Regel";
            this.tbx_ReglerSida_Regel.ReadOnly = true;
            this.tbx_ReglerSida_Regel.Size = new System.Drawing.Size(239, 326);
            this.tbx_ReglerSida_Regel.TabIndex = 0;
            // 
            // tbx_ReglerSida_Böter
            // 
            this.tbx_ReglerSida_Böter.Location = new System.Drawing.Point(286, 13);
            this.tbx_ReglerSida_Böter.Multiline = true;
            this.tbx_ReglerSida_Böter.Name = "tbx_ReglerSida_Böter";
            this.tbx_ReglerSida_Böter.ReadOnly = true;
            this.tbx_ReglerSida_Böter.Size = new System.Drawing.Size(75, 326);
            this.tbx_ReglerSida_Böter.TabIndex = 1;
            // 
            // reglerSida_btn_LäggaTillRegel
            // 
            this.reglerSida_btn_LäggaTillRegel.Location = new System.Drawing.Point(12, 404);
            this.reglerSida_btn_LäggaTillRegel.Name = "reglerSida_btn_LäggaTillRegel";
            this.reglerSida_btn_LäggaTillRegel.Size = new System.Drawing.Size(115, 23);
            this.reglerSida_btn_LäggaTillRegel.TabIndex = 2;
            this.reglerSida_btn_LäggaTillRegel.Text = "Lägg till ny regel";
            this.reglerSida_btn_LäggaTillRegel.UseVisualStyleBackColor = true;
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
            // ReglerSida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReglerSida_tbx_RegelKostnad);
            this.Controls.Add(this.ReglerSida_tbx_RegelNamn);
            this.Controls.Add(this.reglerSida_btn_LäggaTillRegel);
            this.Controls.Add(this.tbx_ReglerSida_Böter);
            this.Controls.Add(this.tbx_ReglerSida_Regel);
            this.Name = "ReglerSida";
            this.Text = "Regler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbx_ReglerSida_Regel;
        public System.Windows.Forms.TextBox tbx_ReglerSida_Böter;
        private System.Windows.Forms.Button reglerSida_btn_LäggaTillRegel;
        private System.Windows.Forms.TextBox ReglerSida_tbx_RegelNamn;
        private System.Windows.Forms.TextBox ReglerSida_tbx_RegelKostnad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
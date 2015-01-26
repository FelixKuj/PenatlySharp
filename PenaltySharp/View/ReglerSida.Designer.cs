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
            this.SuspendLayout();
            // 
            // tbx_ReglerSida_Regel
            // 
            this.tbx_ReglerSida_Regel.Location = new System.Drawing.Point(13, 13);
            this.tbx_ReglerSida_Regel.Multiline = true;
            this.tbx_ReglerSida_Regel.Name = "tbx_ReglerSida_Regel";
            this.tbx_ReglerSida_Regel.ReadOnly = true;
            this.tbx_ReglerSida_Regel.Size = new System.Drawing.Size(239, 508);
            this.tbx_ReglerSida_Regel.TabIndex = 0;
            // 
            // tbx_ReglerSida_Böter
            // 
            this.tbx_ReglerSida_Böter.Location = new System.Drawing.Point(286, 13);
            this.tbx_ReglerSida_Böter.Multiline = true;
            this.tbx_ReglerSida_Böter.Name = "tbx_ReglerSida_Böter";
            this.tbx_ReglerSida_Böter.ReadOnly = true;
            this.tbx_ReglerSida_Böter.Size = new System.Drawing.Size(75, 508);
            this.tbx_ReglerSida_Böter.TabIndex = 1;
            // 
            // ReglerSida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 533);
            this.Controls.Add(this.tbx_ReglerSida_Böter);
            this.Controls.Add(this.tbx_ReglerSida_Regel);
            this.Name = "ReglerSida";
            this.Text = "ReglerSida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbx_ReglerSida_Regel;
        public System.Windows.Forms.TextBox tbx_ReglerSida_Böter;
    }
}
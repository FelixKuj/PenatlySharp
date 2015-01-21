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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lv_Användarsida = new System.Windows.Forms.ListView();
            this.btn_Användarsida_LoggaUt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Användarsida_Regler = new System.Windows.Forms.Button();
            this.btn_Användarsida_Spelare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bruten regel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(694, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Böter";
            // 
            // lv_Användarsida
            // 
            this.lv_Användarsida.Location = new System.Drawing.Point(16, 152);
            this.lv_Användarsida.Name = "lv_Användarsida";
            this.lv_Användarsida.Size = new System.Drawing.Size(756, 389);
            this.lv_Användarsida.TabIndex = 3;
            this.lv_Användarsida.UseCompatibleStateImageBehavior = false;
            this.lv_Användarsida.SelectedIndexChanged += new System.EventHandler(this.lv_Användarsida_SelectedIndexChanged);
            // 
            // btn_Användarsida_LoggaUt
            // 
            this.btn_Användarsida_LoggaUt.Location = new System.Drawing.Point(697, 13);
            this.btn_Användarsida_LoggaUt.Name = "btn_Användarsida_LoggaUt";
            this.btn_Användarsida_LoggaUt.Size = new System.Drawing.Size(75, 23);
            this.btn_Användarsida_LoggaUt.TabIndex = 4;
            this.btn_Användarsida_LoggaUt.Text = "Logga ut";
            this.btn_Användarsida_LoggaUt.UseVisualStyleBackColor = true;
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
            this.btn_Användarsida_Regler.Location = new System.Drawing.Point(138, 8);
            this.btn_Användarsida_Regler.Name = "btn_Användarsida_Regler";
            this.btn_Användarsida_Regler.Size = new System.Drawing.Size(75, 23);
            this.btn_Användarsida_Regler.TabIndex = 6;
            this.btn_Användarsida_Regler.Text = "Regler";
            this.btn_Användarsida_Regler.UseVisualStyleBackColor = true;
            // 
            // btn_Användarsida_Spelare
            // 
            this.btn_Användarsida_Spelare.Location = new System.Drawing.Point(252, 8);
            this.btn_Användarsida_Spelare.Name = "btn_Användarsida_Spelare";
            this.btn_Användarsida_Spelare.Size = new System.Drawing.Size(75, 23);
            this.btn_Användarsida_Spelare.TabIndex = 7;
            this.btn_Användarsida_Spelare.Text = "Spelare";
            this.btn_Användarsida_Spelare.UseVisualStyleBackColor = true;
            this.btn_Användarsida_Spelare.Click += new System.EventHandler(this.btn_Användarsida_Spealre_Click);
            // 
            // Användarsida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btn_Användarsida_Spelare);
            this.Controls.Add(this.btn_Användarsida_Regler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Användarsida_LoggaUt);
            this.Controls.Add(this.lv_Användarsida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Användarsida";
            this.Text = "Användarsida";
            this.Load += new System.EventHandler(this.Användarsida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lv_Användarsida;
        private System.Windows.Forms.Button btn_Användarsida_LoggaUt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Användarsida_Regler;
        private System.Windows.Forms.Button btn_Användarsida_Spelare;

    }
}
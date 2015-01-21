namespace PenaltySharp.View
{
    partial class Inloggning
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
            this.btn_InloggningsSida_Inloggning = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_InloggningsSida_Användarnamn = new System.Windows.Forms.TextBox();
            this.tbx_InloggningsSida_Lösenord = new System.Windows.Forms.TextBox();
            this.btn_InloggningsSida_Registrera = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_InloggningsSida_Inloggning
            // 
            this.btn_InloggningsSida_Inloggning.Location = new System.Drawing.Point(127, 123);
            this.btn_InloggningsSida_Inloggning.Name = "btn_InloggningsSida_Inloggning";
            this.btn_InloggningsSida_Inloggning.Size = new System.Drawing.Size(75, 23);
            this.btn_InloggningsSida_Inloggning.TabIndex = 0;
            this.btn_InloggningsSida_Inloggning.Text = "Logga in";
            this.btn_InloggningsSida_Inloggning.UseVisualStyleBackColor = true;
            this.btn_InloggningsSida_Inloggning.Click += new System.EventHandler(this.btn_InloggningsSida_Inloggning_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Användarnamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lösenord";
            // 
            // tbx_InloggningsSida_Användarnamn
            // 
            this.tbx_InloggningsSida_Användarnamn.Location = new System.Drawing.Point(102, 38);
            this.tbx_InloggningsSida_Användarnamn.Name = "tbx_InloggningsSida_Användarnamn";
            this.tbx_InloggningsSida_Användarnamn.Size = new System.Drawing.Size(100, 20);
            this.tbx_InloggningsSida_Användarnamn.TabIndex = 3;
            // 
            // tbx_InloggningsSida_Lösenord
            // 
            this.tbx_InloggningsSida_Lösenord.Location = new System.Drawing.Point(102, 78);
            this.tbx_InloggningsSida_Lösenord.Name = "tbx_InloggningsSida_Lösenord";
            this.tbx_InloggningsSida_Lösenord.PasswordChar = '•';
            this.tbx_InloggningsSida_Lösenord.Size = new System.Drawing.Size(100, 20);
            this.tbx_InloggningsSida_Lösenord.TabIndex = 4;
            // 
            // btn_InloggningsSida_Registrera
            // 
            this.btn_InloggningsSida_Registrera.Location = new System.Drawing.Point(269, 185);
            this.btn_InloggningsSida_Registrera.Name = "btn_InloggningsSida_Registrera";
            this.btn_InloggningsSida_Registrera.Size = new System.Drawing.Size(75, 23);
            this.btn_InloggningsSida_Registrera.TabIndex = 5;
            this.btn_InloggningsSida_Registrera.Text = "Registrera";
            this.btn_InloggningsSida_Registrera.UseVisualStyleBackColor = true;
            this.btn_InloggningsSida_Registrera.Click += new System.EventHandler(this.btn_InloggningsSida_Registrera_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Har du inte ett konto? Skapa här";
            // 
            // Inloggning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 220);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_InloggningsSida_Registrera);
            this.Controls.Add(this.tbx_InloggningsSida_Lösenord);
            this.Controls.Add(this.tbx_InloggningsSida_Användarnamn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_InloggningsSida_Inloggning);
            this.Name = "Inloggning";
            this.Text = "Inloggning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_InloggningsSida_Inloggning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_InloggningsSida_Användarnamn;
        private System.Windows.Forms.TextBox tbx_InloggningsSida_Lösenord;
        private System.Windows.Forms.Button btn_InloggningsSida_Registrera;
        private System.Windows.Forms.Label label3;
    }
}
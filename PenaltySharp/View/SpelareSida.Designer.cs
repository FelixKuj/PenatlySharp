namespace PenaltySharp.View
{
    partial class SpelareSida
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
            this.lv_SpelareSida = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv_SpelareSida
            // 
            this.lv_SpelareSida.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_SpelareSida.GridLines = true;
            this.lv_SpelareSida.Location = new System.Drawing.Point(12, 12);
            this.lv_SpelareSida.Name = "lv_SpelareSida";
            this.lv_SpelareSida.Size = new System.Drawing.Size(560, 538);
            this.lv_SpelareSida.TabIndex = 0;
            this.lv_SpelareSida.UseCompatibleStateImageBehavior = false;
            this.lv_SpelareSida.View = System.Windows.Forms.View.Details;
            this.lv_SpelareSida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_SpelareSida_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fullständigt namn";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Användarnamn";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Användar ID";
            this.columnHeader3.Width = 200;
            // 
            // SpelareSida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.lv_SpelareSida);
            this.Name = "SpelareSida";
            this.Text = "SpelareSida";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_SpelareSida;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
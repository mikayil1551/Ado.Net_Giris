namespace AdoNet_Giris
{
    partial class KategorilerYeni
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
            this.listKat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listKat
            // 
            this.listKat.FormattingEnabled = true;
            this.listKat.Location = new System.Drawing.Point(313, 70);
            this.listKat.Name = "listKat";
            this.listKat.Size = new System.Drawing.Size(199, 147);
            this.listKat.TabIndex = 0;
            // 
            // KategorilerYeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listKat);
            this.Name = "KategorilerYeni";
            this.Text = "KategorilerYeni";
            this.Load += new System.EventHandler(this.KategorilerYeni_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listKat;
    }
}
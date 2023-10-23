namespace for_döngüsü__2
{
    partial class Form1
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
            this.btnYaz = new System.Windows.Forms.Button();
            this.lbAd = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(12, 161);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(154, 57);
            this.btnYaz.TabIndex = 0;
            this.btnYaz.Text = "YAZ";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // lbAd
            // 
            this.lbAd.FormattingEnabled = true;
            this.lbAd.Location = new System.Drawing.Point(181, 66);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(154, 290);
            this.lbAd.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 463);
            this.Controls.Add(this.lbAd);
            this.Controls.Add(this.btnYaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.ListBox lbAd;
    }
}


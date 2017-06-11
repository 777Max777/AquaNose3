namespace QuadroSoft.Enose
{
    partial class ReopenMap
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
            this.WebBro = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WebBro
            // 
            this.WebBro.Location = new System.Drawing.Point(1, 1);
            this.WebBro.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBro.Name = "WebBro";
            this.WebBro.Size = new System.Drawing.Size(940, 549);
            this.WebBro.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(1, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Загрузить координаты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReopenMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WebBro);
            this.Name = "ReopenMap";
            this.Text = "ReopenMap";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser WebBro;
        private System.Windows.Forms.Button button1;
    }
}
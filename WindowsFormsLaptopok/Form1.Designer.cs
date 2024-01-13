namespace WindowsFormsLaptopok
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.listBox_Laptopok = new System.Windows.Forms.ListBox();
            this.panel_Gyartok = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listBox_Laptopok
            // 
            this.listBox_Laptopok.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox_Laptopok.FormattingEnabled = true;
            this.listBox_Laptopok.ItemHeight = 16;
            this.listBox_Laptopok.Location = new System.Drawing.Point(378, 0);
            this.listBox_Laptopok.Name = "listBox_Laptopok";
            this.listBox_Laptopok.Size = new System.Drawing.Size(422, 450);
            this.listBox_Laptopok.TabIndex = 0;
            // 
            // panel_Gyartok
            // 
            this.panel_Gyartok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Gyartok.Location = new System.Drawing.Point(0, 0);
            this.panel_Gyartok.Name = "panel_Gyartok";
            this.panel_Gyartok.Size = new System.Drawing.Size(378, 450);
            this.panel_Gyartok.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Gyartok);
            this.Controls.Add(this.listBox_Laptopok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Váélasztható laptopok";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Laptopok;
        private System.Windows.Forms.Panel panel_Gyartok;
    }
}


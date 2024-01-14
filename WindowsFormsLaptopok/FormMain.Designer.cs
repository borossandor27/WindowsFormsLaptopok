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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.laptopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törölToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eladásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beállításokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Laptopok
            // 
            this.listBox_Laptopok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Laptopok.FormattingEnabled = true;
            this.listBox_Laptopok.ItemHeight = 16;
            this.listBox_Laptopok.Location = new System.Drawing.Point(0, 28);
            this.listBox_Laptopok.Name = "listBox_Laptopok";
            this.listBox_Laptopok.Size = new System.Drawing.Size(401, 422);
            this.listBox_Laptopok.TabIndex = 0;
            this.listBox_Laptopok.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_Laptopok_MouseDoubleClick);
            // 
            // panel_Gyartok
            // 
            this.panel_Gyartok.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Gyartok.Location = new System.Drawing.Point(380, 28);
            this.panel_Gyartok.Name = "panel_Gyartok";
            this.panel_Gyartok.Size = new System.Drawing.Size(248, 422);
            this.panel_Gyartok.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laptopToolStripMenuItem,
            this.eladásToolStripMenuItem,
            this.beállításokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // laptopToolStripMenuItem
            // 
            this.laptopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.módosítToolStripMenuItem,
            this.törölToolStripMenuItem});
            this.laptopToolStripMenuItem.Name = "laptopToolStripMenuItem";
            this.laptopToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.laptopToolStripMenuItem.Text = "Laptop";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // módosítToolStripMenuItem
            // 
            this.módosítToolStripMenuItem.Name = "módosítToolStripMenuItem";
            this.módosítToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.módosítToolStripMenuItem.Text = "Módosít";
            this.módosítToolStripMenuItem.Click += new System.EventHandler(this.módosítToolStripMenuItem_Click);
            // 
            // törölToolStripMenuItem
            // 
            this.törölToolStripMenuItem.Name = "törölToolStripMenuItem";
            this.törölToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.törölToolStripMenuItem.Text = "Töröl";
            this.törölToolStripMenuItem.Click += new System.EventHandler(this.törölToolStripMenuItem_Click);
            // 
            // eladásToolStripMenuItem
            // 
            this.eladásToolStripMenuItem.Name = "eladásToolStripMenuItem";
            this.eladásToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.eladásToolStripMenuItem.Text = "Eladás";
            this.eladásToolStripMenuItem.Click += new System.EventHandler(this.eladásToolStripMenuItem_Click);
            // 
            // beállításokToolStripMenuItem
            // 
            this.beállításokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valutaToolStripMenuItem});
            this.beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            this.beállításokToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.beállításokToolStripMenuItem.Text = "Beállítások";
            // 
            // valutaToolStripMenuItem
            // 
            this.valutaToolStripMenuItem.Name = "valutaToolStripMenuItem";
            this.valutaToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.valutaToolStripMenuItem.Text = "Valuta";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.panel_Gyartok);
            this.Controls.Add(this.listBox_Laptopok);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Választható laptopok";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Gyartok;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem laptopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosítToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törölToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eladásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beállításokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valutaToolStripMenuItem;
        public System.Windows.Forms.ListBox listBox_Laptopok;
    }
}


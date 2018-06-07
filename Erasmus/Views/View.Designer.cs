namespace Erasmus
{
    partial class View
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
            this.menuStripNavi = new System.Windows.Forms.MenuStrip();
            this.studenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uczelnieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.columns = new Erasmus.Views.Column();
            this.menuStripNavi.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripNavi
            // 
            this.menuStripNavi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripNavi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studenciToolStripMenuItem,
            this.uczelnieToolStripMenuItem});
            this.menuStripNavi.Location = new System.Drawing.Point(0, 0);
            this.menuStripNavi.Name = "menuStripNavi";
            this.menuStripNavi.Size = new System.Drawing.Size(855, 28);
            this.menuStripNavi.TabIndex = 1;
            this.menuStripNavi.Text = "menuStrip1";
            // 
            // studenciToolStripMenuItem
            // 
            this.studenciToolStripMenuItem.Name = "studenciToolStripMenuItem";
            this.studenciToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.studenciToolStripMenuItem.Text = "Studenci";
            this.studenciToolStripMenuItem.Click += new System.EventHandler(this.studenciToolStripMenuItem_Click);
            // 
            // uczelnieToolStripMenuItem
            // 
            this.uczelnieToolStripMenuItem.Name = "uczelnieToolStripMenuItem";
            this.uczelnieToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.uczelnieToolStripMenuItem.Text = "Uczelnie";
            this.uczelnieToolStripMenuItem.Click += new System.EventHandler(this.uczelnieToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // columns
            // 
            this.columns.ColElements = new string[0];
            this.columns.ColName = new string[] { "Column", "Column", "Column", "Column" };
            this.columns.Location = new System.Drawing.Point(12, 52);
            this.columns.Name = "columns";
            this.columns.Size = new System.Drawing.Size(795, 372);
            this.columns.TabIndex = 3;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 474);
            this.Controls.Add(this.columns);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStripNavi);
            this.MainMenuStrip = this.menuStripNavi;
            this.Name = "View";
            this.Text = "Erasmus";
            this.menuStripNavi.ResumeLayout(false);
            this.menuStripNavi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripNavi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem studenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uczelnieToolStripMenuItem;
        private Views.Column columns;
    }
}


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
            this.column4 = new Erasmus.Views.Column();
            this.column3 = new Erasmus.Views.Column();
            this.column2 = new Erasmus.Views.Column();
            this.column1 = new Erasmus.Views.Column();
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
            this.menuStripNavi.Size = new System.Drawing.Size(923, 28);
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
            // column4
            // 
            this.column4.ColElements = new string[0];
            this.column4.ColName = "ColumnName";
            this.column4.Location = new System.Drawing.Point(663, 52);
            this.column4.Name = "column4";
            this.column4.Size = new System.Drawing.Size(211, 372);
            this.column4.TabIndex = 6;
            // 
            // column3
            // 
            this.column3.ColElements = new string[0];
            this.column3.ColName = "ColumnName";
            this.column3.Location = new System.Drawing.Point(446, 52);
            this.column3.Name = "column3";
            this.column3.Size = new System.Drawing.Size(211, 372);
            this.column3.TabIndex = 5;
            // 
            // column2
            // 
            this.column2.ColElements = new string[0];
            this.column2.ColName = "ColumnName";
            this.column2.Location = new System.Drawing.Point(229, 52);
            this.column2.Name = "column2";
            this.column2.Size = new System.Drawing.Size(211, 372);
            this.column2.TabIndex = 4;
            // 
            // column1
            // 
            this.column1.ColElements = new string[0];
            this.column1.ColName = "ColumnName";
            this.column1.Location = new System.Drawing.Point(12, 52);
            this.column1.Name = "column1";
            this.column1.Size = new System.Drawing.Size(211, 372);
            this.column1.TabIndex = 3;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 515);
            this.Controls.Add(this.column4);
            this.Controls.Add(this.column3);
            this.Controls.Add(this.column2);
            this.Controls.Add(this.column1);
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
        private Views.Column column1;
        private Views.Column column2;
        private Views.Column column3;
        private Views.Column column4;
    }
}


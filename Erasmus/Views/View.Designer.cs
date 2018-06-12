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
            this.buttonShowRecord = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.columns = new Erasmus.Views.Column();
            this.buttonDelete = new System.Windows.Forms.Button();
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
            this.menuStripNavi.Size = new System.Drawing.Size(812, 28);
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
            // buttonShowRecord
            // 
            this.buttonShowRecord.Location = new System.Drawing.Point(105, 476);
            this.buttonShowRecord.Name = "buttonShowRecord";
            this.buttonShowRecord.Size = new System.Drawing.Size(136, 38);
            this.buttonShowRecord.TabIndex = 2;
            this.buttonShowRecord.Text = "Zobacz rekord";
            this.buttonShowRecord.UseVisualStyleBackColor = true;
            this.buttonShowRecord.Click += new System.EventHandler(this.buttonShowRecord_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(362, 476);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(136, 38);
            this.buttonAddNew.TabIndex = 5;
            this.buttonAddNew.Text = "Dodaj nowy";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // columns
            // 
            this.columns.ColElements = null;
            this.columns.ColName = new string[] {
        "Column",
        "Column",
        "Column",
        "Column"};
            this.columns.Location = new System.Drawing.Point(12, 31);
            this.columns.Name = "columns";
            this.columns.SelectedIndex = -1;
            this.columns.Size = new System.Drawing.Size(787, 439);
            this.columns.TabIndex = 4;
            this.columns.TypeOfData = null;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(606, 476);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(136, 38);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Usun rekord";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 547);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.columns);
            this.Controls.Add(this.buttonShowRecord);
            this.Controls.Add(this.menuStripNavi);
            this.MainMenuStrip = this.menuStripNavi;
            this.MaximumSize = new System.Drawing.Size(830, 594);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(830, 594);
            this.Name = "View";
            this.Text = "Erasmus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_FormClosing);
            this.menuStripNavi.ResumeLayout(false);
            this.menuStripNavi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripNavi;
        private System.Windows.Forms.Button buttonShowRecord;
        private System.Windows.Forms.ToolStripMenuItem studenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uczelnieToolStripMenuItem;
        private Views.Column columns;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonDelete;
    }
}


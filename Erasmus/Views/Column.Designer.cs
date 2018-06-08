namespace Erasmus.Views
{
    partial class Column
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelColName1 = new System.Windows.Forms.Label();
            this.labelColName2 = new System.Windows.Forms.Label();
            this.labelColName4 = new System.Windows.Forms.Label();
            this.labelColName3 = new System.Windows.Forms.Label();
            this.listViewData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelColName1
            // 
            this.labelColName1.AutoSize = true;
            this.labelColName1.Location = new System.Drawing.Point(3, 0);
            this.labelColName1.Name = "labelColName1";
            this.labelColName1.Size = new System.Drawing.Size(92, 17);
            this.labelColName1.TabIndex = 1;
            this.labelColName1.Text = "ColumnName";
            // 
            // labelColName2
            // 
            this.labelColName2.AllowDrop = true;
            this.labelColName2.AutoSize = true;
            this.labelColName2.Location = new System.Drawing.Point(198, 0);
            this.labelColName2.Name = "labelColName2";
            this.labelColName2.Size = new System.Drawing.Size(92, 17);
            this.labelColName2.TabIndex = 3;
            this.labelColName2.Text = "ColumnName";
            // 
            // labelColName4
            // 
            this.labelColName4.AllowDrop = true;
            this.labelColName4.AutoSize = true;
            this.labelColName4.Location = new System.Drawing.Point(586, 0);
            this.labelColName4.Name = "labelColName4";
            this.labelColName4.Size = new System.Drawing.Size(92, 17);
            this.labelColName4.TabIndex = 7;
            this.labelColName4.Text = "ColumnName";
            // 
            // labelColName3
            // 
            this.labelColName3.AutoSize = true;
            this.labelColName3.Location = new System.Drawing.Point(391, 0);
            this.labelColName3.Name = "labelColName3";
            this.labelColName3.Size = new System.Drawing.Size(92, 17);
            this.labelColName3.TabIndex = 5;
            this.labelColName3.Text = "ColumnName";
            // 
            // listViewData
            // 
            this.listViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewData.FullRowSelect = true;
            this.listViewData.GridLines = true;
            this.listViewData.Location = new System.Drawing.Point(8, 52);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(770, 292);
            this.listViewData.TabIndex = 8;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 155;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.Width = 155;
            // 
            // Column
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewData);
            this.Controls.Add(this.labelColName4);
            this.Controls.Add(this.labelColName3);
            this.Controls.Add(this.labelColName2);
            this.Controls.Add(this.labelColName1);
            this.Name = "Column";
            this.Size = new System.Drawing.Size(791, 395);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelColName1;
        private System.Windows.Forms.Label labelColName2;
        private System.Windows.Forms.Label labelColName4;
        private System.Windows.Forms.Label labelColName3;
        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

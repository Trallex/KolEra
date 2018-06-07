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
            this.listBoxValues = new System.Windows.Forms.ListBox();
            this.labelColName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxValues
            // 
            this.listBoxValues.FormattingEnabled = true;
            this.listBoxValues.ItemHeight = 16;
            this.listBoxValues.Location = new System.Drawing.Point(8, 20);
            this.listBoxValues.Name = "listBoxValues";
            this.listBoxValues.Size = new System.Drawing.Size(189, 340);
            this.listBoxValues.TabIndex = 0;
            // 
            // labelColName
            // 
            this.labelColName.AutoSize = true;
            this.labelColName.Location = new System.Drawing.Point(3, 0);
            this.labelColName.Name = "labelColName";
            this.labelColName.Size = new System.Drawing.Size(92, 17);
            this.labelColName.TabIndex = 1;
            this.labelColName.Text = "ColumnName";
            // 
            // Column
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelColName);
            this.Controls.Add(this.listBoxValues);
            this.Name = "Column";
            this.Size = new System.Drawing.Size(211, 372);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxValues;
        private System.Windows.Forms.Label labelColName;
    }
}

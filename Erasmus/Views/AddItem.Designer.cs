namespace Erasmus.Views
{
    partial class AddItem
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
            this.components = new System.ComponentModel.Container();
            this.textBoxValue1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxValue2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxValue4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxValue3 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxValue1
            // 
            this.textBoxValue1.Location = new System.Drawing.Point(136, 33);
            this.textBoxValue1.Name = "textBoxValue1";
            this.textBoxValue1.Size = new System.Drawing.Size(250, 22);
            this.textBoxValue1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // textBoxValue2
            // 
            this.textBoxValue2.Location = new System.Drawing.Point(136, 86);
            this.textBoxValue2.Name = "textBoxValue2";
            this.textBoxValue2.Size = new System.Drawing.Size(250, 22);
            this.textBoxValue2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // textBoxValue4
            // 
            this.textBoxValue4.Location = new System.Drawing.Point(136, 187);
            this.textBoxValue4.Name = "textBoxValue4";
            this.textBoxValue4.Size = new System.Drawing.Size(250, 22);
            this.textBoxValue4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // textBoxValue3
            // 
            this.textBoxValue3.Location = new System.Drawing.Point(136, 134);
            this.textBoxValue3.Name = "textBoxValue3";
            this.textBoxValue3.Size = new System.Drawing.Size(250, 22);
            this.textBoxValue3.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(77, 228);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(238, 45);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 295);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxValue4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxValue3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxValue2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxValue1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(457, 342);
            this.MinimumSize = new System.Drawing.Size(457, 342);
            this.Name = "AddItem";
            this.Text = "AddItem";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValue1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxValue2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxValue4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxValue3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
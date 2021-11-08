
namespace Project4
{
    partial class MemberForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dobPicker);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.lengthLabel);
            this.panel1.Controls.Add(this.genreLabel);
            this.panel1.Controls.Add(this.yearLabel);
            this.panel1.Controls.Add(this.typeTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 200);
            this.panel1.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(80, 70);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(127, 20);
            this.nameTextBox.TabIndex = 31;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(24, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(19, 13);
            this.titleLabel.TabIndex = 25;
            this.titleLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(80, 25);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(127, 20);
            this.idTextBox.TabIndex = 24;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(24, 159);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(46, 13);
            this.lengthLabel.TabIndex = 28;
            this.lengthLabel.Text = "Type Id:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(24, 70);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(38, 13);
            this.genreLabel.TabIndex = 26;
            this.genreLabel.Text = "Name:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(5, 120);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(69, 13);
            this.yearLabel.TabIndex = 27;
            this.yearLabel.Text = "Date of Birth:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(80, 159);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(127, 20);
            this.typeTextBox.TabIndex = 30;
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(80, 120);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(127, 20);
            this.dobPicker.TabIndex = 32;
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 224);
            this.Controls.Add(this.panel1);
            this.Name = "MemberForm";
            this.Text = "MemberForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MemberForm_FormClosing);
            this.Load += new System.EventHandler(this.MemberForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.DateTimePicker dobPicker;
    }
}
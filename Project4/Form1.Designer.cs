
namespace Project4
{
    partial class Form1
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
            this.movieListView = new System.Windows.Forms.ListView();
            this.genreListBox = new System.Windows.Forms.ListBox();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.modifyGenreButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.memberListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // movieListView
            // 
            this.movieListView.HideSelection = false;
            this.movieListView.Location = new System.Drawing.Point(173, 12);
            this.movieListView.Name = "movieListView";
            this.movieListView.Size = new System.Drawing.Size(265, 308);
            this.movieListView.TabIndex = 0;
            this.movieListView.UseCompatibleStateImageBehavior = false;
            this.movieListView.SelectedIndexChanged += new System.EventHandler(this.movieListView_SelectedIndexChanged);
            // 
            // genreListBox
            // 
            this.genreListBox.FormattingEnabled = true;
            this.genreListBox.Location = new System.Drawing.Point(12, 23);
            this.genreListBox.Name = "genreListBox";
            this.genreListBox.Size = new System.Drawing.Size(123, 95);
            this.genreListBox.TabIndex = 1;
            this.genreListBox.SelectedIndexChanged += new System.EventHandler(this.genreListBox_SelectedIndexChanged);
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(12, 153);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(123, 23);
            this.addGenreButton.TabIndex = 2;
            this.addGenreButton.Text = "Add a Genre";
            this.addGenreButton.UseVisualStyleBackColor = true;
            // 
            // modifyGenreButton
            // 
            this.modifyGenreButton.Location = new System.Drawing.Point(12, 124);
            this.modifyGenreButton.Name = "modifyGenreButton";
            this.modifyGenreButton.Size = new System.Drawing.Size(123, 23);
            this.modifyGenreButton.TabIndex = 3;
            this.modifyGenreButton.Text = "Modify a Genre";
            this.modifyGenreButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search by Year";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Search by Name";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search Movie";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(173, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 137);
            this.panel1.TabIndex = 9;
            // 
            // memberListBox
            // 
            this.memberListBox.FormattingEnabled = true;
            this.memberListBox.Location = new System.Drawing.Point(12, 193);
            this.memberListBox.Name = "memberListBox";
            this.memberListBox.Size = new System.Drawing.Size(123, 212);
            this.memberListBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Genre:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Modify a Member";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Add a Member";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(247, 326);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Add a Movie";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 499);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memberListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.modifyGenreButton);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.genreListBox);
            this.Controls.Add(this.movieListView);
            this.Name = "Form1";
            this.Text = "Db Movies Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView movieListView;
        private System.Windows.Forms.ListBox genreListBox;
        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.Button modifyGenreButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox memberListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}


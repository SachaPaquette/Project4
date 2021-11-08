
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
            this.searchYearButton = new System.Windows.Forms.Button();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.searchNameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.memberListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.memberModButton = new System.Windows.Forms.Button();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.addMovieButton = new System.Windows.Forms.Button();
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
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // modifyGenreButton
            // 
            this.modifyGenreButton.Location = new System.Drawing.Point(12, 124);
            this.modifyGenreButton.Name = "modifyGenreButton";
            this.modifyGenreButton.Size = new System.Drawing.Size(123, 23);
            this.modifyGenreButton.TabIndex = 3;
            this.modifyGenreButton.Text = "Modify a Genre";
            this.modifyGenreButton.UseVisualStyleBackColor = true;
            this.modifyGenreButton.Click += new System.EventHandler(this.modifyGenreButton_Click);
            // 
            // searchYearButton
            // 
            this.searchYearButton.Location = new System.Drawing.Point(138, 93);
            this.searchYearButton.Name = "searchYearButton";
            this.searchYearButton.Size = new System.Drawing.Size(107, 23);
            this.searchYearButton.TabIndex = 4;
            this.searchYearButton.Text = "Search by Year";
            this.searchYearButton.UseVisualStyleBackColor = true;
            this.searchYearButton.Click += new System.EventHandler(this.searchYearButton_Click);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(10, 95);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(123, 20);
            this.yearTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(10, 58);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(123, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // searchNameButton
            // 
            this.searchNameButton.Location = new System.Drawing.Point(138, 55);
            this.searchNameButton.Name = "searchNameButton";
            this.searchNameButton.Size = new System.Drawing.Size(107, 23);
            this.searchNameButton.TabIndex = 7;
            this.searchNameButton.Text = "Search by Name";
            this.searchNameButton.UseVisualStyleBackColor = true;
            this.searchNameButton.Click += new System.EventHandler(this.searchNameButton_Click);
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
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchYearButton);
            this.panel1.Controls.Add(this.searchNameButton);
            this.panel1.Controls.Add(this.yearTextBox);
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
            // memberModButton
            // 
            this.memberModButton.Location = new System.Drawing.Point(12, 411);
            this.memberModButton.Name = "memberModButton";
            this.memberModButton.Size = new System.Drawing.Size(123, 23);
            this.memberModButton.TabIndex = 12;
            this.memberModButton.Text = "Modify a Member";
            this.memberModButton.UseVisualStyleBackColor = true;
            this.memberModButton.Click += new System.EventHandler(this.memberModButton_Click);
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(12, 440);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(123, 23);
            this.addMemberButton.TabIndex = 13;
            this.addMemberButton.Text = "Add a Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(248, 326);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(123, 23);
            this.addMovieButton.TabIndex = 14;
            this.addMovieButton.Text = "Add a Movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 499);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.memberModButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memberListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.modifyGenreButton);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.genreListBox);
            this.Controls.Add(this.movieListView);
            this.Name = "Form1";
            this.Text = "Db Movies Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.Button searchYearButton;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button searchNameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox memberListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button memberModButton;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Button addMovieButton;
    }
}


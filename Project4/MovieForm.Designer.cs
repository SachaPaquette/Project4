
namespace Project4
{
    partial class MovieForm
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
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.pathButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.moviePictureBox = new System.Windows.Forms.PictureBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.memberListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.genreTextBox);
            this.panel1.Controls.Add(this.pathButton);
            this.panel1.Controls.Add(this.pathTextBox);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(this.ratingTextBox);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.directorTextBox);
            this.panel1.Controls.Add(this.genreLabel);
            this.panel1.Controls.Add(this.lengthTextBox);
            this.panel1.Controls.Add(this.yearLabel);
            this.panel1.Controls.Add(this.yearTextBox);
            this.panel1.Controls.Add(this.lengthLabel);
            this.panel1.Controls.Add(this.directorLabel);
            this.panel1.Controls.Add(this.pathLabel);
            this.panel1.Controls.Add(this.ratingLabel);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 465);
            this.panel1.TabIndex = 22;
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(124, 96);
            this.genreTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(168, 22);
            this.genreTextBox.TabIndex = 23;
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(124, 417);
            this.pathButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(169, 28);
            this.pathButton.TabIndex = 19;
            this.pathButton.Text = "Select Path";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(124, 385);
            this.pathTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(168, 22);
            this.pathTextBox.TabIndex = 19;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(124, 41);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(168, 22);
            this.titleTextBox.TabIndex = 0;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(124, 334);
            this.ratingTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(168, 22);
            this.ratingTextBox.TabIndex = 12;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(49, 41);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 17);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // directorTextBox
            // 
            this.directorTextBox.Location = new System.Drawing.Point(124, 273);
            this.directorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(168, 22);
            this.directorTextBox.TabIndex = 11;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(49, 96);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(52, 17);
            this.genreLabel.TabIndex = 2;
            this.genreLabel.Text = "Genre:";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(124, 206);
            this.lengthTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(168, 22);
            this.lengthTextBox.TabIndex = 10;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(49, 154);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(42, 17);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(124, 154);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(168, 22);
            this.yearTextBox.TabIndex = 9;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(49, 206);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(56, 17);
            this.lengthLabel.TabIndex = 4;
            this.lengthLabel.Text = "Length:";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Location = new System.Drawing.Point(49, 277);
            this.directorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(62, 17);
            this.directorLabel.TabIndex = 5;
            this.directorLabel.Text = "Director:";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(49, 385);
            this.pathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(41, 17);
            this.pathLabel.TabIndex = 7;
            this.pathLabel.Text = "Path:";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(49, 334);
            this.ratingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(53, 17);
            this.ratingLabel.TabIndex = 6;
            this.ratingLabel.Text = "Rating:";
            // 
            // moviePictureBox
            // 
            this.moviePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moviePictureBox.Location = new System.Drawing.Point(393, 155);
            this.moviePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moviePictureBox.Name = "moviePictureBox";
            this.moviePictureBox.Size = new System.Drawing.Size(211, 268);
            this.moviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviePictureBox.TabIndex = 21;
            this.moviePictureBox.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(432, 438);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(129, 42);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(432, 100);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(129, 41);
            this.modifyButton.TabIndex = 19;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // memberListBox
            // 
            this.memberListBox.FormattingEnabled = true;
            this.memberListBox.ItemHeight = 16;
            this.memberListBox.Location = new System.Drawing.Point(625, 63);
            this.memberListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.memberListBox.Name = "memberListBox";
            this.memberListBox.Size = new System.Drawing.Size(163, 420);
            this.memberListBox.TabIndex = 23;
            this.memberListBox.SelectedIndexChanged += new System.EventHandler(this.memberListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Members of this movie:";
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(432, 15);
            this.addMovieButton.Margin = new System.Windows.Forms.Padding(4);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(129, 41);
            this.addMovieButton.TabIndex = 25;
            this.addMovieButton.Text = "Add a movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 494);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memberListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.moviePictureBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifyButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MovieForm";
            this.Text = "MovieForm";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.PictureBox moviePictureBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.ListBox memberListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addMovieButton;
    }
}
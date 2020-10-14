namespace Lab03
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.movieListBox = new System.Windows.Forms.ListBox();
            this.genreListBox = new System.Windows.Forms.ListBox();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.deleteMovieButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movies:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Genre:";
            // 
            // movieListBox
            // 
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.ItemHeight = 16;
            this.movieListBox.Location = new System.Drawing.Point(334, 66);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.Size = new System.Drawing.Size(319, 356);
            this.movieListBox.TabIndex = 2;
            // 
            // genreListBox
            // 
            this.genreListBox.FormattingEnabled = true;
            this.genreListBox.ItemHeight = 16;
            this.genreListBox.Location = new System.Drawing.Point(23, 185);
            this.genreListBox.Name = "genreListBox";
            this.genreListBox.Size = new System.Drawing.Size(272, 84);
            this.genreListBox.TabIndex = 3;
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(677, 197);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(93, 45);
            this.addMovieButton.TabIndex = 4;
            this.addMovieButton.Text = "Add Movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            // 
            // deleteMovieButton
            // 
            this.deleteMovieButton.Location = new System.Drawing.Point(677, 273);
            this.deleteMovieButton.Name = "deleteMovieButton";
            this.deleteMovieButton.Size = new System.Drawing.Size(93, 46);
            this.deleteMovieButton.TabIndex = 5;
            this.deleteMovieButton.Text = "Delete Movie";
            this.deleteMovieButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.deleteMovieButton);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.genreListBox);
            this.Controls.Add(this.movieListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "XML Movie Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox movieListBox;
        private System.Windows.Forms.ListBox genreListBox;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.Button deleteMovieButton;
    }
}


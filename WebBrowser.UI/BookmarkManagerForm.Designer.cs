namespace WebBrowser.UI
{
    partial class BookmarkManagerForm
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
            this.listBoxBookmark = new System.Windows.Forms.ListBox();
            this.bookmarkSearchTextBox = new System.Windows.Forms.TextBox();
            this.deleteBookmarkButton = new System.Windows.Forms.Button();
            this.bookmarkSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBookmark
            // 
            this.listBoxBookmark.FormattingEnabled = true;
            this.listBoxBookmark.Location = new System.Drawing.Point(0, 78);
            this.listBoxBookmark.Name = "listBoxBookmark";
            this.listBoxBookmark.Size = new System.Drawing.Size(689, 368);
            this.listBoxBookmark.TabIndex = 0;
            this.listBoxBookmark.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxBookmark_Format);
            // 
            // bookmarkSearchTextBox
            // 
            this.bookmarkSearchTextBox.Location = new System.Drawing.Point(0, 42);
            this.bookmarkSearchTextBox.Multiline = true;
            this.bookmarkSearchTextBox.Name = "bookmarkSearchTextBox";
            this.bookmarkSearchTextBox.Size = new System.Drawing.Size(689, 30);
            this.bookmarkSearchTextBox.TabIndex = 2;
            // 
            // deleteBookmarkButton
            // 
            this.deleteBookmarkButton.Location = new System.Drawing.Point(700, 78);
            this.deleteBookmarkButton.Name = "deleteBookmarkButton";
            this.deleteBookmarkButton.Size = new System.Drawing.Size(88, 35);
            this.deleteBookmarkButton.TabIndex = 4;
            this.deleteBookmarkButton.Text = "Delete Bookmark";
            this.deleteBookmarkButton.UseVisualStyleBackColor = true;
            this.deleteBookmarkButton.Click += new System.EventHandler(this.deleteBookmarkButton_Click);
            // 
            // bookmarkSearchButton
            // 
            this.bookmarkSearchButton.Location = new System.Drawing.Point(700, 42);
            this.bookmarkSearchButton.Name = "bookmarkSearchButton";
            this.bookmarkSearchButton.Size = new System.Drawing.Size(88, 30);
            this.bookmarkSearchButton.TabIndex = 5;
            this.bookmarkSearchButton.Text = "Search";
            this.bookmarkSearchButton.UseVisualStyleBackColor = true;
            this.bookmarkSearchButton.Click += new System.EventHandler(this.bookmarkSearchButton_Click);
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBookmarkButton);
            this.Controls.Add(this.bookmarkSearchButton);
            this.Controls.Add(this.bookmarkSearchTextBox);
            this.Controls.Add(this.listBoxBookmark);
            this.Name = "BookmarkManagerForm";
            this.Text = "BookmarkManagerForm";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBookmark;
        private System.Windows.Forms.TextBox bookmarkSearchTextBox;
        private System.Windows.Forms.Button deleteBookmarkButton;
        private System.Windows.Forms.Button bookmarkSearchButton;
    }
}
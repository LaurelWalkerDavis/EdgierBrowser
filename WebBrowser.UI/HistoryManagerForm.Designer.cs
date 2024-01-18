namespace WebBrowser.UI
{
    partial class HistoryManagerForm
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
            this.historySearchTextBox = new System.Windows.Forms.TextBox();
            this.historySearchButton = new System.Windows.Forms.Button();
            this.deleteEntryButton = new System.Windows.Forms.Button();
            this.clearHistoryButton = new System.Windows.Forms.Button();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // historySearchTextBox
            // 
            this.historySearchTextBox.Location = new System.Drawing.Point(0, 42);
            this.historySearchTextBox.Multiline = true;
            this.historySearchTextBox.Name = "historySearchTextBox";
            this.historySearchTextBox.Size = new System.Drawing.Size(689, 30);
            this.historySearchTextBox.TabIndex = 1;
            // 
            // historySearchButton
            // 
            this.historySearchButton.Location = new System.Drawing.Point(700, 42);
            this.historySearchButton.Name = "historySearchButton";
            this.historySearchButton.Size = new System.Drawing.Size(88, 30);
            this.historySearchButton.TabIndex = 2;
            this.historySearchButton.Text = "Search";
            this.historySearchButton.UseVisualStyleBackColor = true;
            this.historySearchButton.Click += new System.EventHandler(this.historySearchButton_Click);
            // 
            // deleteEntryButton
            // 
            this.deleteEntryButton.Location = new System.Drawing.Point(700, 78);
            this.deleteEntryButton.Name = "deleteEntryButton";
            this.deleteEntryButton.Size = new System.Drawing.Size(88, 30);
            this.deleteEntryButton.TabIndex = 2;
            this.deleteEntryButton.Text = "Delete Entry";
            this.deleteEntryButton.UseVisualStyleBackColor = true;
            this.deleteEntryButton.Click += new System.EventHandler(this.deleteEntryButton_Click);
            // 
            // clearHistoryButton
            // 
            this.clearHistoryButton.Location = new System.Drawing.Point(700, 408);
            this.clearHistoryButton.Name = "clearHistoryButton";
            this.clearHistoryButton.Size = new System.Drawing.Size(88, 30);
            this.clearHistoryButton.TabIndex = 2;
            this.clearHistoryButton.Text = "Clear All History";
            this.clearHistoryButton.UseVisualStyleBackColor = true;
            this.clearHistoryButton.Click += new System.EventHandler(this.clearHistoryButton_Click);
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.Location = new System.Drawing.Point(0, 78);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(689, 368);
            this.listBoxHistory.TabIndex = 0;
            this.listBoxHistory.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxHistory_Format);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearHistoryButton);
            this.Controls.Add(this.deleteEntryButton);
            this.Controls.Add(this.historySearchButton);
            this.Controls.Add(this.historySearchTextBox);
            this.Controls.Add(this.listBoxHistory);
            this.Name = "HistoryManagerForm";
            this.Text = "HistoryManagerForm";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox historySearchTextBox;
        private System.Windows.Forms.Button historySearchButton;
        private System.Windows.Forms.Button deleteEntryButton;
        private System.Windows.Forms.Button clearHistoryButton;
        private System.Windows.Forms.ListBox listBoxHistory;
    }
}
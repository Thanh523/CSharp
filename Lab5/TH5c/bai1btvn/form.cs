namespace Bai1btvn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TabControl tabDictionary;
        private TabPage tabEnglishVietnamese;
        private TabPage tabVietnameseEnglish;
        private Label lblEnglishWord;
        private Label lblVietnameseMeaning;
        private ComboBox cboEnglishWord;
        private ListBox lstEnglishWords;
        private TextBox txtVietnameseMeaning;
        private Button btnLookupEnglish;
        private Label lblVietnameseWord;
        private Label lblEnglishMeaning;
        private ComboBox cboVietnameseWord;
        private ListBox lstVietnameseWords;
        private TextBox txtEnglishMeaning;
        private Button btnLookupVietnamese;
        private Button btnExit;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabDictionary = new TabControl();
            tabEnglishVietnamese = new TabPage();
            lblEnglishWord = new Label();
            lblVietnameseMeaning = new Label();
            cboEnglishWord = new ComboBox();
            lstEnglishWords = new ListBox();
            txtVietnameseMeaning = new TextBox();
            btnLookupEnglish = new Button();
            tabVietnameseEnglish = new TabPage();
            lblVietnameseWord = new Label();
            lblEnglishMeaning = new Label();
            cboVietnameseWord = new ComboBox();
            lstVietnameseWords = new ListBox();
            txtEnglishMeaning = new TextBox();
            btnLookupVietnamese = new Button();
            btnExit = new Button();
            tabDictionary.SuspendLayout();
            tabEnglishVietnamese.SuspendLayout();
            tabVietnameseEnglish.SuspendLayout();
            SuspendLayout();
            // 
            // tabDictionary
            // 
            tabDictionary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabDictionary.Controls.Add(tabEnglishVietnamese);
            tabDictionary.Controls.Add(tabVietnameseEnglish);
            tabDictionary.Location = new Point(12, 12);
            tabDictionary.Name = "tabDictionary";
            tabDictionary.SelectedIndex = 0;
            tabDictionary.Size = new Size(560, 370);
            tabDictionary.TabIndex = 0;
            // 
            // tabEnglishVietnamese
            // 
            tabEnglishVietnamese.Controls.Add(lblEnglishWord);
            tabEnglishVietnamese.Controls.Add(lblVietnameseMeaning);
            tabEnglishVietnamese.Controls.Add(cboEnglishWord);
            tabEnglishVietnamese.Controls.Add(lstEnglishWords);
            tabEnglishVietnamese.Controls.Add(txtVietnameseMeaning);
            tabEnglishVietnamese.Controls.Add(btnLookupEnglish);
            tabEnglishVietnamese.Location = new Point(4, 29);
            tabEnglishVietnamese.Name = "tabEnglishVietnamese";
            tabEnglishVietnamese.Padding = new Padding(10);
            tabEnglishVietnamese.Size = new Size(552, 337);
            tabEnglishVietnamese.TabIndex = 0;
            tabEnglishVietnamese.Text = "ANH - VIỆT";
            tabEnglishVietnamese.UseVisualStyleBackColor = true;
            // 
            // lblEnglishWord
            // 
            lblEnglishWord.AutoSize = true;
            lblEnglishWord.Location = new Point(14, 16);
            lblEnglishWord.Name = "lblEnglishWord";
            lblEnglishWord.Size = new Size(76, 20);
            lblEnglishWord.TabIndex = 0;
            lblEnglishWord.Text = "Tiếng Anh";
            // 
            // lblVietnameseMeaning
            // 
            lblVietnameseMeaning.AutoSize = true;
            lblVietnameseMeaning.Location = new Point(282, 16);
            lblVietnameseMeaning.Name = "lblVietnameseMeaning";
            lblVietnameseMeaning.Size = new Size(76, 20);
            lblVietnameseMeaning.TabIndex = 1;
            lblVietnameseMeaning.Text = "Tiếng Việt";
            // 
            // cboEnglishWord
            // 
            cboEnglishWord.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboEnglishWord.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEnglishWord.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEnglishWord.FormattingEnabled = true;
            cboEnglishWord.Location = new Point(14, 36);
            cboEnglishWord.Name = "cboEnglishWord";
            cboEnglishWord.Size = new Size(245, 28);
            cboEnglishWord.TabIndex = 2;
            // 
            // lstEnglishWords
            // 
            lstEnglishWords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstEnglishWords.FormattingEnabled = true;
            lstEnglishWords.Location = new Point(14, 65);
            lstEnglishWords.Name = "lstEnglishWords";
            lstEnglishWords.Size = new Size(245, 244);
            lstEnglishWords.TabIndex = 3;
            lstEnglishWords.SelectedIndexChanged += lstEnglishWords_SelectedIndexChanged;
            // 
            // txtVietnameseMeaning
            // 
            txtVietnameseMeaning.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtVietnameseMeaning.Location = new Point(282, 36);
            txtVietnameseMeaning.Multiline = true;
            txtVietnameseMeaning.Name = "txtVietnameseMeaning";
            txtVietnameseMeaning.ReadOnly = true;
            txtVietnameseMeaning.ScrollBars = ScrollBars.Vertical;
            txtVietnameseMeaning.Size = new Size(245, 273);
            txtVietnameseMeaning.TabIndex = 4;
            // 
            // btnLookupEnglish
            // 
            btnLookupEnglish.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLookupEnglish.Location = new Point(424, 310);
            btnLookupEnglish.Name = "btnLookupEnglish";
            btnLookupEnglish.Size = new Size(103, 27);
            btnLookupEnglish.TabIndex = 5;
            btnLookupEnglish.Text = "Tra từ (Enter)";
            btnLookupEnglish.UseVisualStyleBackColor = true;
            // 
            // tabVietnameseEnglish
            // 
            tabVietnameseEnglish.Controls.Add(lblVietnameseWord);
            tabVietnameseEnglish.Controls.Add(lblEnglishMeaning);
            tabVietnameseEnglish.Controls.Add(cboVietnameseWord);
            tabVietnameseEnglish.Controls.Add(lstVietnameseWords);
            tabVietnameseEnglish.Controls.Add(txtEnglishMeaning);
            tabVietnameseEnglish.Controls.Add(btnLookupVietnamese);
            tabVietnameseEnglish.Location = new Point(4, 29);
            tabVietnameseEnglish.Name = "tabVietnameseEnglish";
            tabVietnameseEnglish.Padding = new Padding(10);
            tabVietnameseEnglish.Size = new Size(552, 337);
            tabVietnameseEnglish.TabIndex = 1;
            tabVietnameseEnglish.Text = "VIỆT - ANH";
            tabVietnameseEnglish.UseVisualStyleBackColor = true;
            // 
            // lblVietnameseWord
            // 
            lblVietnameseWord.AutoSize = true;
            lblVietnameseWord.Location = new Point(14, 16);
            lblVietnameseWord.Name = "lblVietnameseWord";
            lblVietnameseWord.Size = new Size(76, 20);
            lblVietnameseWord.TabIndex = 0;
            lblVietnameseWord.Text = "Tiếng Việt";
            // 
            // lblEnglishMeaning
            // 
            lblEnglishMeaning.AutoSize = true;
            lblEnglishMeaning.Location = new Point(282, 16);
            lblEnglishMeaning.Name = "lblEnglishMeaning";
            lblEnglishMeaning.Size = new Size(76, 20);
            lblEnglishMeaning.TabIndex = 1;
            lblEnglishMeaning.Text = "Tiếng Anh";
            // 
            // cboVietnameseWord
            // 
            cboVietnameseWord.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboVietnameseWord.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboVietnameseWord.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboVietnameseWord.FormattingEnabled = true;
            cboVietnameseWord.Location = new Point(14, 36);
            cboVietnameseWord.Name = "cboVietnameseWord";
            cboVietnameseWord.Size = new Size(245, 28);
            cboVietnameseWord.TabIndex = 2;
            // 
            // lstVietnameseWords
            // 
            lstVietnameseWords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstVietnameseWords.FormattingEnabled = true;
            lstVietnameseWords.Location = new Point(14, 65);
            lstVietnameseWords.Name = "lstVietnameseWords";
            lstVietnameseWords.Size = new Size(245, 244);
            lstVietnameseWords.TabIndex = 3;
            // 
            // txtEnglishMeaning
            // 
            txtEnglishMeaning.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEnglishMeaning.Location = new Point(282, 36);
            txtEnglishMeaning.Multiline = true;
            txtEnglishMeaning.Name = "txtEnglishMeaning";
            txtEnglishMeaning.ReadOnly = true;
            txtEnglishMeaning.ScrollBars = ScrollBars.Vertical;
            txtEnglishMeaning.Size = new Size(245, 273);
            txtEnglishMeaning.TabIndex = 4;
            // 
            // btnLookupVietnamese
            // 
            btnLookupVietnamese.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLookupVietnamese.Location = new Point(424, 310);
            btnLookupVietnamese.Name = "btnLookupVietnamese";
            btnLookupVietnamese.Size = new Size(103, 27);
            btnLookupVietnamese.TabIndex = 5;
            btnLookupVietnamese.Text = "Tra từ (Enter)";
            btnLookupVietnamese.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.Location = new Point(482, 388);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 30);
            btnExit.TabIndex = 1;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnLookupEnglish;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 430);
            Controls.Add(btnExit);
            Controls.Add(tabDictionary);
            MinimumSize = new Size(600, 469);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TỪ ĐIỂN ANH VIỆT - VIỆT ANH";
            tabDictionary.ResumeLayout(false);
            tabEnglishVietnamese.ResumeLayout(false);
            tabEnglishVietnamese.PerformLayout();
            tabVietnameseEnglish.ResumeLayout(false);
            tabVietnameseEnglish.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}

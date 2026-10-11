namespace WinFormsApp1
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            groupInput = new GroupBox();
            lblInput = new Label();
            txtNumber = new TextBox();
            btnUpdate = new Button();
            cboNumbers = new ComboBox();
            groupDivisors = new GroupBox();
            lstDivisors = new ListBox();
            btnSum = new Button();
            btnEvenCount = new Button();
            btnPrimeCount = new Button();
            btnExit = new Button();
            groupInput.SuspendLayout();
            groupDivisors.SuspendLayout();
            SuspendLayout();
            // 
            // groupInput
            // 
            groupInput.Controls.Add(lblInput);
            groupInput.Controls.Add(txtNumber);
            groupInput.Controls.Add(btnUpdate);
            groupInput.Controls.Add(cboNumbers);
            groupInput.Location = new Point(24, 24);
            groupInput.Name = "groupInput";
            groupInput.Size = new Size(350, 150);
            groupInput.TabIndex = 0;
            groupInput.TabStop = false;
            groupInput.Text = "Nhập số";
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(14, 28);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(75, 20);
            lblInput.TabIndex = 0;
            lblInput.Text = "Nhập số:";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(18, 57);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(150, 27);
            txtNumber.TabIndex = 1;
            txtNumber.KeyPress += txtNumber_KeyPress;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(180, 55);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 30);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "&Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cboNumbers
            // 
            cboNumbers.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNumbers.FormattingEnabled = true;
            cboNumbers.Location = new Point(18, 101);
            cboNumbers.Name = "cboNumbers";
            cboNumbers.Size = new Size(307, 28);
            cboNumbers.TabIndex = 3;
            cboNumbers.SelectedIndexChanged += cboNumbers_SelectedIndexChanged;
            // 
            // groupDivisors
            // 
            groupDivisors.Controls.Add(lstDivisors);
            groupDivisors.Location = new Point(395, 24);
            groupDivisors.Name = "groupDivisors";
            groupDivisors.Size = new Size(350, 150);
            groupDivisors.TabIndex = 4;
            groupDivisors.TabStop = false;
            groupDivisors.Text = "Danh sách các ước số";
            // 
            // lstDivisors
            // 
            lstDivisors.FormattingEnabled = true;
            lstDivisors.Location = new Point(16, 27);
            lstDivisors.Name = "lstDivisors";
            lstDivisors.Size = new Size(318, 104);
            lstDivisors.TabIndex = 0;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(395, 191);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(350, 38);
            btnSum.TabIndex = 5;
            btnSum.Text = "&Tổng các ước số";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // btnEvenCount
            // 
            btnEvenCount.Location = new Point(395, 238);
            btnEvenCount.Name = "btnEvenCount";
            btnEvenCount.Size = new Size(350, 38);
            btnEvenCount.TabIndex = 6;
            btnEvenCount.Text = "Số lượng các ước số chẵ&n";
            btnEvenCount.UseVisualStyleBackColor = true;
            btnEvenCount.Click += btnEvenCount_Click;
            // 
            // btnPrimeCount
            // 
            btnPrimeCount.Location = new Point(395, 285);
            btnPrimeCount.Name = "btnPrimeCount";
            btnPrimeCount.Size = new Size(350, 38);
            btnPrimeCount.TabIndex = 7;
            btnPrimeCount.Text = "Số lượng các ước số &nguyên tố";
            btnPrimeCount.UseVisualStyleBackColor = true;
            btnPrimeCount.Click += btnPrimeCount_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(635, 342);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 38);
            btnExit.TabIndex = 8;
            btnExit.Text = "Th&oát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 410);
            Controls.Add(btnExit);
            Controls.Add(btnPrimeCount);
            Controls.Add(btnEvenCount);
            Controls.Add(btnSum);
            Controls.Add(groupDivisors);
            Controls.Add(groupInput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách ước số";
            FormClosing += Form_FormClosing;
            groupInput.ResumeLayout(false);
            groupInput.PerformLayout();
            groupDivisors.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupInput;
        private Label lblInput;
        private TextBox txtNumber;
        private Button btnUpdate;
        private ComboBox cboNumbers;
        private GroupBox groupDivisors;
        private ListBox lstDivisors;
        private Button btnSum;
        private Button btnEvenCount;
        private Button btnPrimeCount;
        private Button btnExit;
    }
}

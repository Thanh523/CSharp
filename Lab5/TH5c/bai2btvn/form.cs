namespace bai2btvn
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle = null!;
        private GroupBox grpList = null!;
        private TextBox txtCount = null!;
        private Button btnAdd = null!;
        private ListBox lstNumbers = null!;
        private GroupBox grpActions = null!;
        private Button btnSum = null!;
        private Button btnDeleteEnds = null!;
        private Button btnDeleteSelected = null!;
        private Button btnIncrease = null!;
        private Button btnSquare = null!;
        private Button btnSelectEven = null!;
        private Button btnSelectOdd = null!;
        private Button btnExit = null!;

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

        private void InitializeComponent()
        {
            lblTitle = new Label();
            grpList = new GroupBox();
            txtCount = new TextBox();
            btnAdd = new Button();
            lstNumbers = new ListBox();
            grpActions = new GroupBox();
            btnSum = new Button();
            btnDeleteEnds = new Button();
            btnDeleteSelected = new Button();
            btnIncrease = new Button();
            btnSquare = new Button();
            btnSelectEven = new Button();
            btnSelectOdd = new Button();
            btnExit = new Button();
            grpList.SuspendLayout();
            grpActions.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.WhiteSmoke;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkOrange;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(720, 58);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "LISTBOX";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpList
            // 
            grpList.Controls.Add(lstNumbers);
            grpList.Controls.Add(btnAdd);
            grpList.Controls.Add(txtCount);
            grpList.Font = new Font("Segoe UI", 9F);
            grpList.Location = new Point(24, 76);
            grpList.Name = "grpList";
            grpList.Size = new Size(286, 314);
            grpList.TabIndex = 1;
            grpList.TabStop = false;
            grpList.Text = "Danh sách số";
            // 
            // txtCount
            // 
            txtCount.Location = new Point(16, 25);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(254, 23);
            txtCount.TabIndex = 0;
            txtCount.Text = "12";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightBlue;
            btnAdd.Location = new Point(16, 56);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(254, 32);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Nhập số ngẫu nhiên";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstNumbers
            // 
            lstNumbers.FormattingEnabled = true;
            lstNumbers.ItemHeight = 15;
            lstNumbers.Location = new Point(16, 98);
            lstNumbers.Name = "lstNumbers";
            lstNumbers.SelectionMode = SelectionMode.MultiExtended;
            lstNumbers.Size = new Size(254, 199);
            lstNumbers.TabIndex = 2;
            // 
            // grpActions
            // 
            grpActions.Controls.Add(btnSelectOdd);
            grpActions.Controls.Add(btnSelectEven);
            grpActions.Controls.Add(btnSquare);
            grpActions.Controls.Add(btnIncrease);
            grpActions.Controls.Add(btnDeleteSelected);
            grpActions.Controls.Add(btnDeleteEnds);
            grpActions.Controls.Add(btnSum);
            grpActions.Font = new Font("Segoe UI", 9F);
            grpActions.Location = new Point(326, 76);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(370, 314);
            grpActions.TabIndex = 2;
            grpActions.TabStop = false;
            grpActions.Text = "Xử lý Listbox";
            // 
            // btnSum
            // 
            btnSum.Location = new Point(16, 25);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(338, 32);
            btnSum.TabIndex = 0;
            btnSum.Text = "Tổng các phần tử trong List";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // btnDeleteEnds
            // 
            btnDeleteEnds.Location = new Point(16, 63);
            btnDeleteEnds.Name = "btnDeleteEnds";
            btnDeleteEnds.Size = new Size(338, 32);
            btnDeleteEnds.TabIndex = 1;
            btnDeleteEnds.Text = "Xóa phần tử đầu và cuối";
            btnDeleteEnds.UseVisualStyleBackColor = true;
            btnDeleteEnds.Click += btnDeleteEnds_Click;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.Location = new Point(16, 101);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(338, 32);
            btnDeleteSelected.TabIndex = 2;
            btnDeleteSelected.Text = "Xóa phần tử đang chọn";
            btnDeleteSelected.UseVisualStyleBackColor = true;
            btnDeleteSelected.Click += btnDeleteSelected_Click;
            // 
            // btnIncrease
            // 
            btnIncrease.Location = new Point(16, 139);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(338, 32);
            btnIncrease.TabIndex = 3;
            btnIncrease.Text = "Tăng mỗi phần tử lên 2";
            btnIncrease.UseVisualStyleBackColor = true;
            btnIncrease.Click += btnIncrease_Click;
            // 
            // btnSquare
            // 
            btnSquare.Location = new Point(16, 177);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(338, 32);
            btnSquare.TabIndex = 4;
            btnSquare.Text = "Thay bằng bình phương";
            btnSquare.UseVisualStyleBackColor = true;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnSelectEven
            // 
            btnSelectEven.Location = new Point(16, 215);
            btnSelectEven.Name = "btnSelectEven";
            btnSelectEven.Size = new Size(338, 32);
            btnSelectEven.TabIndex = 5;
            btnSelectEven.Text = "Chọn số chẵn";
            btnSelectEven.UseVisualStyleBackColor = true;
            btnSelectEven.Click += btnSelectEven_Click;
            // 
            // btnSelectOdd
            // 
            btnSelectOdd.Location = new Point(16, 253);
            btnSelectOdd.Name = "btnSelectOdd";
            btnSelectOdd.Size = new Size(338, 32);
            btnSelectOdd.TabIndex = 6;
            btnSelectOdd.Text = "Chọn số lẻ";
            btnSelectOdd.UseVisualStyleBackColor = true;
            btnSelectOdd.Click += btnSelectOdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(24, 402);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(672, 36);
            btnExit.TabIndex = 3;
            btnExit.Text = "KẾT THÚC";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(720, 454);
            Controls.Add(btnExit);
            Controls.Add(grpActions);
            Controls.Add(grpList);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListbox";
            grpList.ResumeLayout(false);
            grpList.PerformLayout();
            grpActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}

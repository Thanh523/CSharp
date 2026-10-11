namespace bai2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private TreeView treeStudents = null!;
        private ComboBox cboClasses = null!;
        private GroupBox grpStudent = null!;
        private TextBox txtStudentId = null!;
        private TextBox txtStudentName = null!;
        private TextBox txtStudentAddress = null!;
        private Button btnUpdate = null!;
        private Button btnDelete = null!;
        private CheckBox chkAddClass = null!;
        private GroupBox grpClass = null!;
        private TextBox txtClassName = null!;
        private Button btnAddClass = null!;

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
            components = new System.ComponentModel.Container();
            treeStudents = new TreeView();
            cboClasses = new ComboBox();
            grpStudent = new GroupBox();
            txtStudentId = new TextBox();
            txtStudentName = new TextBox();
            txtStudentAddress = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            chkAddClass = new CheckBox();
            grpClass = new GroupBox();
            txtClassName = new TextBox();
            btnAddClass = new Button();
            grpStudent.SuspendLayout();
            grpClass.SuspendLayout();
            SuspendLayout();
            //
            // treeStudents
            //
            treeStudents.Location = new Point(12, 38);
            treeStudents.Name = "treeStudents";
            treeStudents.Size = new Size(240, 420);
            treeStudents.TabIndex = 0;
            treeStudents.HideSelection = false;
            treeStudents.AfterSelect += treeStudents_AfterSelect;
            //
            // cboClasses
            //
            cboClasses.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClasses.FormattingEnabled = true;
            cboClasses.Location = new Point(355, 38);
            cboClasses.Name = "cboClasses";
            cboClasses.Size = new Size(300, 28);
            cboClasses.TabIndex = 1;
            cboClasses.SelectedIndexChanged += cboClasses_SelectedIndexChanged;
            //
            // grpStudent
            //
            grpStudent.Controls.Add(new Label { AutoSize = true, Location = new Point(18, 35), Text = "Mã SV:" });
            grpStudent.Controls.Add(txtStudentId);
            grpStudent.Controls.Add(new Label { AutoSize = true, Location = new Point(18, 75), Text = "Họ Tên:" });
            grpStudent.Controls.Add(txtStudentName);
            grpStudent.Controls.Add(new Label { AutoSize = true, Location = new Point(18, 115), Text = "Địa Chỉ:" });
            grpStudent.Controls.Add(txtStudentAddress);
            grpStudent.Controls.Add(btnUpdate);
            grpStudent.Controls.Add(btnDelete);
            grpStudent.Location = new Point(280, 82);
            grpStudent.Name = "grpStudent";
            grpStudent.Size = new Size(390, 205);
            grpStudent.TabStop = false;
            grpStudent.Text = "Thông tin sinh viên";
            //
            // txtStudentId
            //
            txtStudentId.Location = new Point(105, 32);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(260, 27);
            txtStudentId.TabIndex = 2;
            //
            // txtStudentName
            //
            txtStudentName.Location = new Point(105, 72);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(260, 27);
            txtStudentName.TabIndex = 3;
            //
            // txtStudentAddress
            //
            txtStudentAddress.Location = new Point(105, 112);
            txtStudentAddress.Name = "txtStudentAddress";
            txtStudentAddress.Size = new Size(260, 27);
            txtStudentAddress.TabIndex = 4;
            //
            // btnUpdate
            //
            btnUpdate.Location = new Point(105, 157);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 30);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            //
            // btnDelete
            //
            btnDelete.Location = new Point(255, 157);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 30);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            //
            // chkAddClass
            //
            chkAddClass.AutoSize = true;
            chkAddClass.Location = new Point(280, 305);
            chkAddClass.Name = "chkAddClass";
            chkAddClass.Size = new Size(89, 24);
            chkAddClass.TabIndex = 7;
            chkAddClass.Text = "Thêm lớp";
            chkAddClass.UseVisualStyleBackColor = true;
            chkAddClass.CheckedChanged += chkAddClass_CheckedChanged;
            //
            // grpClass
            //
            grpClass.Controls.Add(new Label { AutoSize = true, Location = new Point(18, 37), Text = "Tên lớp:" });
            grpClass.Controls.Add(txtClassName);
            grpClass.Controls.Add(btnAddClass);
            grpClass.Location = new Point(280, 340);
            grpClass.Name = "grpClass";
            grpClass.Size = new Size(390, 105);
            grpClass.TabStop = false;
            grpClass.Text = "Thông tin lớp";
            grpClass.Visible = false;
            //
            // txtClassName
            //
            txtClassName.Location = new Point(105, 34);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(145, 27);
            txtClassName.TabIndex = 8;
            //
            // btnAddClass
            //
            btnAddClass.Location = new Point(265, 32);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(100, 30);
            btnAddClass.TabIndex = 9;
            btnAddClass.Text = "Thêm lớp";
            btnAddClass.UseVisualStyleBackColor = true;
            btnAddClass.Click += btnAddClass_Click;
            //
            // Form1
            //
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 475);
            Controls.Add(treeStudents);
            Controls.Add(new Label { AutoSize = true, Location = new Point(280, 41), Text = "Chọn Lớp" });
            Controls.Add(cboClasses);
            Controls.Add(grpStudent);
            Controls.Add(chkAddClass);
            Controls.Add(grpClass);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            grpStudent.ResumeLayout(false);
            grpStudent.PerformLayout();
            grpClass.ResumeLayout(false);
            grpClass.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}

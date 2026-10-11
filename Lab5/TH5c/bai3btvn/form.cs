namespace bai3btvn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TreeView treeViewNames = null!;
        private Label labelFirstName = null!;
        private Label labelLastName = null!;
        private TextBox textBoxFirstName = null!;
        private TextBox textBoxLastName = null!;
        private Button buttonAdd = null!;
        private Button buttonExit = null!;
        private GroupBox groupBoxEntry = null!;

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
            treeViewNames = new TreeView();
            labelFirstName = new Label();
            labelLastName = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            buttonAdd = new Button();
            buttonExit = new Button();
            groupBoxEntry = new GroupBox();
            groupBoxEntry.SuspendLayout();
            SuspendLayout();
            // 
            // treeViewNames
            // 
            treeViewNames.Location = new Point(8, 8);
            treeViewNames.Name = "treeViewNames";
            treeViewNames.Size = new Size(128, 214);
            treeViewNames.TabIndex = 0;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(10, 24);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(57, 15);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(10, 52);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(58, 15);
            labelLastName.TabIndex = 1;
            labelLastName.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(76, 20);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(90, 23);
            textBoxFirstName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(76, 48);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(90, 23);
            textBoxLastName.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(120, 78);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(46, 24);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(278, 128);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(46, 24);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // groupBoxEntry
            // 
            groupBoxEntry.Controls.Add(labelFirstName);
            groupBoxEntry.Controls.Add(labelLastName);
            groupBoxEntry.Controls.Add(textBoxFirstName);
            groupBoxEntry.Controls.Add(textBoxLastName);
            groupBoxEntry.Controls.Add(buttonAdd);
            groupBoxEntry.Location = new Point(142, 8);
            groupBoxEntry.Name = "groupBoxEntry";
            groupBoxEntry.Size = new Size(190, 112);
            groupBoxEntry.TabIndex = 1;
            groupBoxEntry.TabStop = false;
            // 
            // Form1
            // 
            AcceptButton = buttonAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 230);
            Controls.Add(buttonExit);
            Controls.Add(groupBoxEntry);
            Controls.Add(treeViewNames);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBTVN2";
            groupBoxEntry.ResumeLayout(false);
            groupBoxEntry.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}

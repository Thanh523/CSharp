namespace bai1
{
    public partial class Form1 : Form
    {
        private readonly TextBox nameTextBox = new();
        private readonly TextBox studentIdTextBox = new();
        private readonly RadioButton maleRadioButton = new() { Text = "Nam", Checked = true, AutoSize = true };
        private readonly RadioButton femaleRadioButton = new() { Text = "Nữ", AutoSize = true };
        private readonly CheckBox englishCheckBox = new() { Text = "Anh", AutoSize = true };
        private readonly CheckBox frenchCheckBox = new() { Text = "Pháp", AutoSize = true };
        private readonly CheckBox chineseCheckBox = new() { Text = "Hoa", AutoSize = true };
        private readonly ComboBox ethnicityComboBox = new();
        private readonly ListView studentsListView = new();
        private readonly Button addButton = new() { Text = "Thêm", Width = 88, Height = 32 };
        private readonly Button deleteButton = new() { Text = "Xóa", Width = 88, Height = 32 };
        private readonly Button editButton = new() { Text = "Sửa", Width = 88, Height = 32 };
        private readonly ContextMenuStrip listContextMenu = new();
        private ListViewItem? editingItem;

        public Form1()
        {
            InitializeComponent();
            Text = "Thông tin sinh viên";
            ClientSize = new Size(460, 430);
            MinimumSize = new Size(460, 430);
            MaximumSize = new Size(460, 430);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            BuildInterface();
            ethnicityComboBox.Items.AddRange(new object[] { "Kinh", "Tày", "Thái", "Mường", "Khmer", "Hoa", "Nùng", "H'Mông", "Dao", "Ê-đê", "Gia-rai", "Ba-na", "Chăm" });
            ethnicityComboBox.SelectedIndex = 0;

            addButton.Click += AddStudent;
            deleteButton.Click += (_, _) => DeleteSelectedStudent();
            editButton.Click += EditOrSaveStudent;
            studentsListView.MouseDown += SelectItemOnRightClick;
            listContextMenu.Items.Add("Xóa", null, (_, _) => DeleteSelectedStudent());
            listContextMenu.Opening += (_, e) => e.Cancel = studentsListView.SelectedItems.Count == 0;
            studentsListView.ContextMenuStrip = listContextMenu;
            studentsListView.SelectedIndexChanged += (_, _) =>
            {
                if (editingItem is null)
                    editButton.Enabled = studentsListView.SelectedItems.Count > 0;
            };
            editButton.Enabled = false;

            FormClosing += (_, e) =>
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    e.Cancel = true;
            };
        }

        private void BuildInterface()
        {
            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(12),
                ColumnCount = 1,
                RowCount = 3
            };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 150));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42));

            var inputs = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 5
            };
            inputs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105));
            inputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            for (var i = 0; i < 5; i++)
                inputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));

            AddInputRow(inputs, 0, "Họ và Tên", nameTextBox);
            AddInputRow(inputs, 1, "Mã sinh viên", studentIdTextBox);
            AddInputRow(inputs, 2, "Giới tính", CreateChoicePanel(maleRadioButton, femaleRadioButton));
            AddInputRow(inputs, 3, "Ngoại ngữ", CreateChoicePanel(englishCheckBox, frenchCheckBox, chineseCheckBox));
            ethnicityComboBox.Dock = DockStyle.Fill;
            ethnicityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AddInputRow(inputs, 4, "Dân tộc", ethnicityComboBox);

            studentsListView.Dock = DockStyle.Fill;
            studentsListView.View = View.Details;
            studentsListView.FullRowSelect = true;
            studentsListView.GridLines = true;
            studentsListView.MultiSelect = false;
            studentsListView.HideSelection = false;
            studentsListView.Columns.Add("Họ tên", 120);
            studentsListView.Columns.Add("Mã sinh viên", 95);
            studentsListView.Columns.Add("Giới tính", 70);
            studentsListView.Columns.Add("Ngoại ngữ", 90);
            studentsListView.Columns.Add("Dân tộc", 75);

            var buttons = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Anchor = AnchorStyles.None
            };
            buttons.Controls.Add(addButton);
            buttons.Controls.Add(deleteButton);
            buttons.Controls.Add(editButton);

            layout.Controls.Add(inputs, 0, 0);
            layout.Controls.Add(studentsListView, 0, 1);
            layout.Controls.Add(buttons, 0, 2);
            Controls.Add(layout);
        }

        private static void AddInputRow(TableLayoutPanel panel, int row, string labelText, Control input)
        {
            panel.Controls.Add(new Label
            {
                Text = labelText,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = false
            }, 0, row);
            input.Dock = DockStyle.Fill;
            panel.Controls.Add(input, 1, row);
        }

        private static FlowLayoutPanel CreateChoicePanel(params Control[] choices)
        {
            var panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Padding = new Padding(0, 4, 0, 0)
            };
            panel.Controls.AddRange(choices);
            return panel;
        }

        private void AddStudent(object? sender, EventArgs e)
        {
            if (editingItem is not null)
            {
                ResetEditor();
                return;
            }

            var name = nameTextBox.Text.Trim();
            var studentId = studentIdTextBox.Text.Trim();
            if (!ValidateRequiredFields(name, studentId))
                return;

            if (studentsListView.Items.Cast<ListViewItem>().Any(item => string.Equals(item.SubItems[1].Text, studentId, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                studentIdTextBox.Focus();
                return;
            }

            var item = new ListViewItem(name);
            item.SubItems.Add(studentId);
            item.SubItems.Add(maleRadioButton.Checked ? "Nam" : "Nữ");
            item.SubItems.Add(GetSelectedLanguages());
            item.SubItems.Add(ethnicityComboBox.Text);
            studentsListView.Items.Add(item);
            item.Selected = true;
            item.EnsureVisible();
            ResetEditor();
        }

        private void EditOrSaveStudent(object? sender, EventArgs e)
        {
            if (editingItem is null)
            {
                if (studentsListView.SelectedItems.Count == 0)
                    return;

                editingItem = studentsListView.SelectedItems[0];
                nameTextBox.Text = editingItem.Text;
                studentIdTextBox.Text = editingItem.SubItems[1].Text;
                studentIdTextBox.ReadOnly = true;
                maleRadioButton.Checked = editingItem.SubItems[2].Text == "Nam";
                femaleRadioButton.Checked = !maleRadioButton.Checked;
                SetLanguageChecks(editingItem.SubItems[3].Text);
                var ethnicityIndex = ethnicityComboBox.FindStringExact(editingItem.SubItems[4].Text);
                ethnicityComboBox.SelectedIndex = ethnicityIndex >= 0 ? ethnicityIndex : 0;
                editButton.Text = "Lưu sửa";
                addButton.Text = "Hủy sửa";
                return;
            }

            var name = nameTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập họ và tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameTextBox.Focus();
                return;
            }

            editingItem.Text = name;
            editingItem.SubItems[2].Text = maleRadioButton.Checked ? "Nam" : "Nữ";
            editingItem.SubItems[3].Text = GetSelectedLanguages();
            editingItem.SubItems[4].Text = ethnicityComboBox.Text;
            ResetEditor();
        }

        private bool ValidateRequiredFields(string name, string studentId)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập họ và tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(studentId))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                studentIdTextBox.Focus();
                return false;
            }

            return true;
        }

        private string GetSelectedLanguages()
        {
            var languages = new List<string>();
            if (englishCheckBox.Checked)
                languages.Add("Anh");
            if (frenchCheckBox.Checked)
                languages.Add("Pháp");
            if (chineseCheckBox.Checked)
                languages.Add("Hoa");
            return string.Join(", ", languages);
        }

        private void SetLanguageChecks(string languages)
        {
            var selectedLanguages = languages.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            englishCheckBox.Checked = selectedLanguages.Contains("Anh");
            frenchCheckBox.Checked = selectedLanguages.Contains("Pháp");
            chineseCheckBox.Checked = selectedLanguages.Contains("Hoa");
        }

        private void DeleteSelectedStudent()
        {
            if (studentsListView.SelectedItems.Count == 0)
                return;

            var selectedItem = studentsListView.SelectedItems[0];
            if (ReferenceEquals(selectedItem, editingItem))
                ResetEditor();
            studentsListView.Items.Remove(selectedItem);
            editButton.Enabled = studentsListView.SelectedItems.Count > 0;
        }

        private void SelectItemOnRightClick(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            var item = studentsListView.GetItemAt(e.X, e.Y);
            if (item is not null)
                item.Selected = true;
        }

        private void ResetEditor()
        {
            editingItem = null;
            nameTextBox.Clear();
            studentIdTextBox.Clear();
            studentIdTextBox.ReadOnly = false;
            maleRadioButton.Checked = true;
            femaleRadioButton.Checked = false;
            englishCheckBox.Checked = false;
            frenchCheckBox.Checked = false;
            chineseCheckBox.Checked = false;
            ethnicityComboBox.SelectedIndex = 0;
            editButton.Text = "Sửa";
            addButton.Text = "Thêm";
            editButton.Enabled = studentsListView.SelectedItems.Count > 0;
            nameTextBox.Focus();
        }
    }
}

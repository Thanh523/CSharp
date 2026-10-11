namespace bai2
{
    public partial class Form1 : Form
    {
        private readonly List<ClassInfo> _classes = [];
        private bool _syncingClassSelection;

        public Form1()
        {
            InitializeComponent();
            LoadSampleData();
            RefreshClassViews("05DHTH3");
        }

        private void LoadSampleData()
        {
            _classes.AddRange(
            [
                new ClassInfo("05DHTH1"),
                new ClassInfo("05DHTH2"),
                new ClassInfo("05DHTH3"),
                new ClassInfo("05DHTH4")
            ]);

            _classes[0].Students.Add(new StudentInfo("2001140001", "Nguyễn Văn A", "TPHCM"));
            _classes[2].Students.Add(new StudentInfo("200115", "Nguyễn Văn Bình", "TPHCM"));
        }

        private void RefreshClassViews(string? selectedClassName = null)
        {
            treeStudents.BeginUpdate();
            treeStudents.Nodes.Clear();
            TreeNode rootNode = new("Danh sách lớp");
            foreach (ClassInfo classInfo in _classes)
            {
                TreeNode classNode = new(classInfo.Name) { Tag = classInfo };
                foreach (StudentInfo student in classInfo.Students)
                {
                    classNode.Nodes.Add(new TreeNode($"{student.Id}, {student.Name}") { Tag = student });
                }

                rootNode.Nodes.Add(classNode);
            }

            treeStudents.Nodes.Add(rootNode);
            rootNode.Expand();
            treeStudents.EndUpdate();

            cboClasses.BeginUpdate();
            cboClasses.Items.Clear();
            foreach (ClassInfo classInfo in _classes)
            {
                cboClasses.Items.Add(classInfo.Name);
            }

            cboClasses.EndUpdate();
            int selectedIndex = selectedClassName is null
                ? -1
                : cboClasses.Items.IndexOf(selectedClassName);
            cboClasses.SelectedIndex = selectedIndex >= 0 ? selectedIndex : (cboClasses.Items.Count > 0 ? 0 : -1);
        }

        private void chkAddClass_CheckedChanged(object? sender, EventArgs e)
        {
            grpClass.Visible = chkAddClass.Checked;
            if (chkAddClass.Checked)
            {
                txtClassName.Focus();
            }
        }

        private void btnAddClass_Click(object? sender, EventArgs e)
        {
            string className = txtClassName.Text.Trim();
            if (className.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên lớp.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClassName.Focus();
                return;
            }

            if (_classes.Any(classInfo => string.Equals(classInfo.Name, className, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Lớp này đã tồn tại.", "Trùng tên lớp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClassName.SelectAll();
                txtClassName.Focus();
                return;
            }

            _classes.Add(new ClassInfo(className));
            RefreshClassViews(className);
            txtClassName.Clear();
            treeStudents.SelectedNode = null;
            ClearStudentFields();
        }

        private void cboClasses_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_syncingClassSelection)
            {
                return;
            }

            treeStudents.SelectedNode = null;
            ClearStudentFields();
        }

        private void treeStudents_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is not StudentInfo student)
            {
                ClearStudentFields();
                return;
            }

            txtStudentId.Text = student.Id;
            txtStudentName.Text = student.Name;
            txtStudentAddress.Text = student.Address;

            if (e.Node.Parent?.Tag is ClassInfo classInfo)
            {
                _syncingClassSelection = true;
                cboClasses.SelectedItem = classInfo.Name;
                _syncingClassSelection = false;
            }
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            string id = txtStudentId.Text.Trim();
            string name = txtStudentName.Text.Trim();
            string address = txtStudentAddress.Text.Trim();

            if (id.Length == 0 || name.Length == 0 || address.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã sinh viên, họ tên và địa chỉ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClassInfo? selectedClass = _classes.FirstOrDefault(classInfo => classInfo.Name == cboClasses.SelectedItem as string);
            if (selectedClass is null)
            {
                MessageBox.Show("Vui lòng chọn lớp.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StudentInfo? selectedStudent = treeStudents.SelectedNode?.Tag as StudentInfo;
            bool duplicateId = _classes
                .SelectMany(classInfo => classInfo.Students)
                .Any(student => student.Id.Equals(id, StringComparison.OrdinalIgnoreCase) && !ReferenceEquals(student, selectedStudent));
            if (duplicateId)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại.", "Trùng mã sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentId.SelectAll();
                txtStudentId.Focus();
                return;
            }

            StudentInfo savedStudent = new(id, name, address);
            if (selectedStudent is null)
            {
                selectedClass.Students.Add(savedStudent);
            }
            else
            {
                ClassInfo owner = _classes.First(classInfo => classInfo.Students.Contains(selectedStudent));
                int studentIndex = owner.Students.IndexOf(selectedStudent);
                owner.Students[studentIndex] = savedStudent;
                selectedClass = owner;
            }

            RefreshClassViews(selectedClass.Name);
            SelectStudentNode(savedStudent);
        }

        private void SelectStudentNode(StudentInfo student)
        {
            foreach (TreeNode rootNode in treeStudents.Nodes)
            {
                foreach (TreeNode classNode in rootNode.Nodes)
                {
                    TreeNode? studentNode = classNode.Nodes
                        .Cast<TreeNode>()
                        .FirstOrDefault(node => ReferenceEquals(node.Tag, student));
                    if (studentNode is not null)
                    {
                        classNode.Expand();
                        rootNode.Expand();
                        treeStudents.SelectedNode = studentNode;
                        return;
                    }
                }
            }
        }

        private void ClearStudentFields()
        {
            txtStudentId.Clear();
            txtStudentName.Clear();
            txtStudentAddress.Clear();
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (treeStudents.SelectedNode?.Tag is not StudentInfo student)
            {
                MessageBox.Show("Chỉ có thể xóa sinh viên đang được chọn trong danh sách.", "Chưa chọn sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa sinh viên {student.Name} (mã {student.Id}) không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            ClassInfo owner = _classes.First(classInfo => classInfo.Students.Contains(student));
            owner.Students.Remove(student);
            RefreshClassViews(owner.Name);
            ClearStudentFields();
        }

        private sealed class ClassInfo(string name)
        {
            public string Name { get; } = name;
            public List<StudentInfo> Students { get; } = [];
        }

        private sealed record StudentInfo(string Id, string Name, string Address);
    }
}

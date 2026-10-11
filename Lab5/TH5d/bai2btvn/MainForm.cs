namespace bai2btvn;

internal sealed class MainForm : Form
{
    private readonly MenuStrip menuStrip = new();
    private readonly Dictionary<string, Form> openForms = new();

    public MainForm()
    {
        InitializeInterface();
    }

    private void InitializeInterface()
    {
        Text = "Bài tập tuần 5";
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(600, 360);
        MainMenuStrip = menuStrip;

        ToolStripMenuItem exercisesMenu = new("Bài tập");

        ToolStripMenuItem th5cMenu = new("TH5c");
        th5cMenu.DropDownItems.Add(CreateExerciseItem(
            "Bài 1 - Danh sách ước số",
            "th5c-bai1",
            static () => new WinFormsApp1.Form()));
        th5cMenu.DropDownItems.Add(CreateExerciseItem(
            "Bài 1 BTVN - Từ điển Anh Việt",
            "th5c-bai1btvn",
            static () => new Bai1btvn.Form1()));
        th5cMenu.DropDownItems.Add(CreateExerciseItem(
            "Bài 2 - Quản lý lớp và sinh viên",
            "th5c-bai2",
            static () => new bai2.Form1()));
        th5cMenu.DropDownItems.Add(CreateExerciseItem(
            "Bài 2 BTVN - Xử lý danh sách số",
            "th5c-bai2btvn",
            static () => new bai2btvn.Form1()));
        th5cMenu.DropDownItems.Add(CreateExerciseItem(
            "Bài 3 BTVN - Cây danh bạ",
            "th5c-bai3btvn",
            static () => new bai3btvn.Form1()));
        exercisesMenu.DropDownItems.Add(th5cMenu);

        ToolStripMenuItem th5dMenu = new("TH5d");
        th5dMenu.DropDownItems.Add(CreateExerciseItem(
            "Bài 1 - Thông tin sinh viên",
            "th5d-bai1",
            static () => new bai1.Form1()));
        th5dMenu.DropDownItems.Add(CreateExerciseItem(
            "Bài 1 BTVN - Đồng hồ",
            "th5d-bai1btvn",
            static () => new bai1btvn.Form1()));
        th5dMenu.DropDownItems.Add(CreateExerciseItem(
            "Bài 2 - Quản lý tài khoản",
            "th5d-bai2",
            static () => new bai3.Form1()));
        exercisesMenu.DropDownItems.Add(th5dMenu);
        exercisesMenu.DropDownItems.Add(new ToolStripSeparator());
        exercisesMenu.DropDownItems.Add(new ToolStripMenuItem("Thoát", null, (_, _) => Close()));

        ToolStripMenuItem helpMenu = new("Trợ giúp");
        helpMenu.DropDownItems.Add(new ToolStripMenuItem(
            "Giới thiệu",
            null,
            (_, _) => MessageBox.Show(
                this,
                "Chương trình tổng hợp các bài tập tuần 5.",
                "Giới thiệu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)));

        menuStrip.Items.Add(exercisesMenu);
        menuStrip.Items.Add(helpMenu);
        Controls.Add(menuStrip);

        Label title = new()
        {
            Dock = DockStyle.Fill,
            Text = "CHƯƠNG TRÌNH BÀI TẬP TUẦN 5",
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 18F, FontStyle.Bold),
            ForeColor = Color.DarkBlue
        };
        Controls.Add(title);
        title.BringToFront();

        FormClosing += (_, e) =>
        {
            if (MessageBox.Show(
                    this,
                    "Bạn có chắc chắn muốn thoát chương trình không?",
                    "Xác nhận thoát",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        };
    }

    private ToolStripMenuItem CreateExerciseItem(
        string text,
        string key,
        Func<Form> createForm)
    {
        return new ToolStripMenuItem(text, null, (_, _) =>
        {
            if (openForms.TryGetValue(key, out Form? existingForm) && !existingForm.IsDisposed)
            {
                existingForm.Activate();
                return;
            }

            Form childForm = createForm();
            openForms[key] = childForm;
            childForm.FormClosed += (_, _) => openForms.Remove(key);
            childForm.Show(this);
        });
    }
}

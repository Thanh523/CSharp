namespace Quanlythanhtoantienphong
{
    public partial class Form1 : Form
    {
        private readonly TextBox txtHoTen = new();
        private readonly TextBox txtDiaChi = new();
        private readonly NumericUpDown nudSoNgay = new();
        private readonly RadioButton radPhongDon = new();
        private readonly RadioButton radPhongDoi = new();
        private readonly RadioButton radPhongBa = new();
        private readonly CheckBox chkTivi = new();
        private readonly CheckBox chkInternet = new();
        private readonly CheckBox chkMayNuocNong = new();
        private readonly CheckBox chkKaraoke = new();
        private readonly CheckBox chkAnSang = new();
        private readonly Label lblThanhTien = new();
        private readonly Label lblSoLuot = new();
        private readonly Label lblTongTien = new();
        private readonly Button btnThanhToan = new();
        private readonly Button btnNhapMoi = new();
        private readonly Button btnTongKet = new();
        private decimal tongTienTrongNgay;
        private int soLuotTrongNgay;
        private bool daThanhToan;

        public Form1()
        {
            InitializeComponent();
            KhoiTaoGiaoDien();
            CapNhatTrangThaiNut();
        }

        private void KhoiTaoGiaoDien()
        {
            Text = "Quản lý thanh toán tiền phòng - Khách sạn Thanh Thanh";
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(820, 570);
            ClientSize = new Size(920, 620);
            BackColor = Color.FromArgb(245, 247, 250);
            Font = new Font("Segoe UI", 10F);

            var header = new Label
            {
                Text = "KHÁCH SẠN THANH THANH - TRẢ PHÒNG",
                Dock = DockStyle.Top,
                Height = 64,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 17F, FontStyle.Bold),
                ForeColor = Color.FromArgb(190, 103, 28),
                BackColor = Color.White
            };
            Controls.Add(header);

            var leftPanel = new Panel
            {
                Location = new Point(24, 88),
                Size = new Size(560, 470),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.White,
                Padding = new Padding(14)
            };
            var rightPanel = new Panel
            {
                Location = new Point(604, 88),
                Size = new Size(292, 470),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right,
                BackColor = Color.White,
                Padding = new Padding(16)
            };
            Controls.Add(leftPanel);
            Controls.Add(rightPanel);

            AddFieldLabel(leftPanel, "Họ và tên:", 20, 24, 105);
            txtHoTen.SetBounds(132, 20, 390, 32);
            txtHoTen.MaxLength = 100;
            txtHoTen.TextChanged += (_, _) => CapNhatTrangThaiNut();
            leftPanel.Controls.Add(txtHoTen);

            AddFieldLabel(leftPanel, "Địa chỉ:", 20, 74, 105);
            txtDiaChi.SetBounds(132, 70, 390, 32);
            txtDiaChi.MaxLength = 200;
            txtDiaChi.TextChanged += (_, _) => CapNhatTrangThaiNut();
            leftPanel.Controls.Add(txtDiaChi);

            AddFieldLabel(leftPanel, "Số ngày ở:", 20, 124, 105);
            nudSoNgay.SetBounds(132, 120, 120, 32);
            nudSoNgay.Minimum = 1;
            nudSoNgay.Maximum = 365;
            nudSoNgay.ValueChanged += (_, _) => CapNhatTrangThaiNut();
            leftPanel.Controls.Add(nudSoNgay);

            var roomGroup = CreateGroup("Loại phòng", 18, 176, 170, 250);
            radPhongDon.Text = "Phòng đơn - 300.000đ/ngày";
            radPhongDoi.Text = "Phòng đôi - 350.000đ/ngày";
            radPhongBa.Text = "Phòng ba - 400.000đ/ngày";
            AddRadio(roomGroup, radPhongDon, 14, 32);
            AddRadio(roomGroup, radPhongDoi, 14, 82);
            AddRadio(roomGroup, radPhongBa, 14, 132);
            radPhongDon.Checked = true;
            radPhongDon.CheckedChanged += (_, _) => CapNhatTrangThaiNut();
            radPhongDoi.CheckedChanged += (_, _) => CapNhatTrangThaiNut();
            radPhongBa.CheckedChanged += (_, _) => CapNhatTrangThaiNut();
            leftPanel.Controls.Add(roomGroup);

            var amenityGroup = CreateGroup("Tiện nghi (+10.000đ/mục)", 204, 176, 170, 250);
            chkTivi.Text = "Tivi";
            chkInternet.Text = "Internet";
            chkMayNuocNong.Text = "Máy nước nóng";
            AddCheckBox(amenityGroup, chkTivi, 14, 32);
            AddCheckBox(amenityGroup, chkInternet, 14, 82);
            AddCheckBox(amenityGroup, chkMayNuocNong, 14, 132);
            leftPanel.Controls.Add(amenityGroup);

            var serviceGroup = CreateGroup("Dịch vụ", 390, 176, 150, 250);
            chkKaraoke.Text = "Karaoke - 50.000đ";
            chkAnSang.Text = "Ăn sáng - 15.000đ/ngày";
            AddCheckBox(serviceGroup, chkKaraoke, 12, 32);
            AddCheckBox(serviceGroup, chkAnSang, 12, 82);
            leftPanel.Controls.Add(serviceGroup);

            StyleButton(btnThanhToan, "Thanh toán", 18, 20, 122, 38, Color.FromArgb(39, 111, 181));
            StyleButton(btnNhapMoi, "Nhập mới", 154, 20, 122, 38, Color.FromArgb(39, 139, 120));
            StyleButton(btnTongKet, "Tổng kết", 18, 78, 258, 38, Color.FromArgb(190, 103, 28));
            rightPanel.Controls.Add(btnThanhToan);
            rightPanel.Controls.Add(btnNhapMoi);
            rightPanel.Controls.Add(btnTongKet);

            AddFieldLabel(rightPanel, "Thành tiền:", 18, 142, 100);
            lblThanhTien.SetBounds(18, 172, 250, 38);
            StyleValueLabel(lblThanhTien);
            rightPanel.Controls.Add(lblThanhTien);

            var summaryTitle = new Label
            {
                Text = "THỐNG KÊ TRONG NGÀY",
                Location = new Point(18, 236),
                Size = new Size(250, 28),
                Font = new Font(Font, FontStyle.Bold),
                ForeColor = Color.FromArgb(60, 70, 82)
            };
            rightPanel.Controls.Add(summaryTitle);
            AddFieldLabel(rightPanel, "Số lượt khách:", 18, 278, 250);
            lblSoLuot.SetBounds(18, 308, 250, 38);
            StyleValueLabel(lblSoLuot);
            rightPanel.Controls.Add(lblSoLuot);
            AddFieldLabel(rightPanel, "Tổng số tiền:", 18, 358, 250);
            lblTongTien.SetBounds(18, 388, 250, 38);
            StyleValueLabel(lblTongTien);
            rightPanel.Controls.Add(lblTongTien);

            var btnThoat = new Button
            {
                Text = "Thoát",
                Location = new Point(18, 430),
                Size = new Size(100, 34),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(232, 236, 241),
                ForeColor = Color.FromArgb(45, 55, 65)
            };
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.Click += BtnThoat_Click;
            rightPanel.Controls.Add(btnThoat);

            btnThanhToan.Click += BtnThanhToan_Click;
            btnNhapMoi.Click += BtnNhapMoi_Click;
            btnTongKet.Click += BtnTongKet_Click;
            Shown += (_, _) => txtHoTen.Focus();
            btnNhapMoi.Enabled = false;
            btnTongKet.Enabled = false;
            lblThanhTien.Text = "0 VND";
            lblSoLuot.Text = "0";
            lblTongTien.Text = "0 VND";
        }

        private static void AddFieldLabel(Control parent, string text, int x, int y, int width)
        {
            parent.Controls.Add(new Label
            {
                Text = text,
                Location = new Point(x, y),
                Size = new Size(width, 28),
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.FromArgb(55, 65, 75)
            });
        }

        private static GroupBox CreateGroup(string text, int x, int y, int width, int height) => new()
        {
            Text = text,
            Location = new Point(x, y),
            Size = new Size(width, height),
            ForeColor = Color.FromArgb(55, 65, 75)
        };

        private static void AddRadio(GroupBox parent, RadioButton radioButton, int x, int y)
        {
            radioButton.SetBounds(x, y, parent.Width - 24, 32);
            parent.Controls.Add(radioButton);
        }

        private static void AddCheckBox(GroupBox parent, CheckBox checkBox, int x, int y)
        {
            checkBox.SetBounds(x, y, parent.Width - 22, 34);
            parent.Controls.Add(checkBox);
        }

        private static void StyleButton(Button button, string text, int x, int y, int width, int height, Color color)
        {
            button.Text = text;
            button.SetBounds(x, y, width, height);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = color;
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            button.Cursor = Cursors.Hand;
        }

        private static void StyleValueLabel(Label label)
        {
            label.BorderStyle = BorderStyle.FixedSingle;
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Padding = new Padding(8, 0, 0, 0);
            label.BackColor = Color.FromArgb(249, 250, 252);
            label.ForeColor = Color.FromArgb(35, 45, 55);
            label.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        }

        private void CapNhatTrangThaiNut()
        {
            btnThanhToan.Enabled = !daThanhToan && !string.IsNullOrWhiteSpace(txtHoTen.Text)
                && !string.IsNullOrWhiteSpace(txtDiaChi.Text) && nudSoNgay.Value > 0;
        }

        private void BtnThanhToan_Click(object? sender, EventArgs e)
        {
            if (!decimal.TryParse(nudSoNgay.Value.ToString(), out var soNgay))
            {
                MessageBox.Show("Vui lòng nhập số ngày ở hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal donGiaPhong = radPhongBa.Checked ? 400000m : radPhongDoi.Checked ? 350000m : 300000m;
            int soTienNghi = (chkTivi.Checked ? 1 : 0) + (chkInternet.Checked ? 1 : 0) + (chkMayNuocNong.Checked ? 1 : 0);
            decimal thanhTien = donGiaPhong * soNgay + soTienNghi * 10000m
                + (chkKaraoke.Checked ? 50000m : 0m)
                + (chkAnSang.Checked ? 15000m * soNgay : 0m);

            lblThanhTien.Text = DinhDangTien(thanhTien);
            tongTienTrongNgay += thanhTien;
            soLuotTrongNgay++;
            daThanhToan = true;
            btnNhapMoi.Enabled = true;
            btnTongKet.Enabled = true;
            CapNhatTrangThaiNut();
        }

        private void BtnNhapMoi_Click(object? sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtDiaChi.Clear();
            nudSoNgay.Value = 1;
            radPhongDon.Checked = true;
            chkTivi.Checked = false;
            chkInternet.Checked = false;
            chkMayNuocNong.Checked = false;
            chkKaraoke.Checked = false;
            chkAnSang.Checked = false;
            lblThanhTien.Text = "0 VND";
            daThanhToan = false;
            CapNhatTrangThaiNut();
            txtHoTen.Focus();
        }

        private void BtnTongKet_Click(object? sender, EventArgs e)
        {
            lblSoLuot.Text = soLuotTrongNgay.ToString();
            lblTongTien.Text = DinhDangTien(tongTienTrongNgay);
            soLuotTrongNgay = 0;
            tongTienTrongNgay = 0;
            btnTongKet.Enabled = false;
        }

        private static string DinhDangTien(decimal soTien) => $"{soTien:N0} VND";

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            var ketQua = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ketQua == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}

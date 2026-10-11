namespace WinFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsAsciiDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumber.Text.Trim(), out int number) || number <= 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập một số nguyên dương hợp lệ.",
                    "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNumber.Focus();
                txtNumber.SelectAll();
                return;
            }

            if (cboNumbers.Items.Contains(number))
            {
                MessageBox.Show(
                    "Số này đã tồn tại trong danh sách.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtNumber.Clear();
                txtNumber.Focus();
                return;
            }

            cboNumbers.Items.Add(number);
            cboNumbers.SelectedItem = number;
            txtNumber.Clear();
            txtNumber.Focus();
        }

        private void cboNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDivisors.Items.Clear();
            if (cboNumbers.SelectedItem is not int number)
            {
                return;
            }

            var divisors = new List<int>();
            for (int divisor = 1; divisor <= number / divisor; divisor++)
            {
                if (number % divisor != 0)
                {
                    continue;
                }

                divisors.Add(divisor);
                int pairedDivisor = number / divisor;
                if (pairedDivisor != divisor)
                {
                    divisors.Add(pairedDivisor);
                }
            }

            divisors.Sort();
            lstDivisors.Items.AddRange(divisors.Cast<object>().ToArray());
        }

        private bool TryGetDivisors(out List<int> divisors)
        {
            divisors = lstDivisors.Items.Cast<object>()
                .Select(item => Convert.ToInt32(item))
                .ToList();

            if (divisors.Count > 0)
            {
                return true;
            }

            MessageBox.Show(
                "Vui lòng chọn một số trong danh sách trước.",
                "Chưa có dữ liệu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return false;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (TryGetDivisors(out List<int> divisors))
            {
                long sum = divisors.Sum(divisor => (long)divisor);
                MessageBox.Show($"Tổng các ước số là: {sum}", "Kết quả");
            }
        }

        private void btnEvenCount_Click(object sender, EventArgs e)
        {
            if (TryGetDivisors(out List<int> divisors))
            {
                int count = divisors.Count(divisor => divisor % 2 == 0);
                MessageBox.Show($"Số lượng ước số chẵn là: {count}", "Kết quả");
            }
        }

        private void btnPrimeCount_Click(object sender, EventArgs e)
        {
            if (TryGetDivisors(out List<int> divisors))
            {
                int count = divisors.Count(IsPrime);
                MessageBox.Show($"Số lượng ước số nguyên tố là: {count}", "Kết quả");
            }
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int divisor = 2; divisor <= number / divisor; divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            e.Cancel = result != DialogResult.Yes;
        }
    }
}

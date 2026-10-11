using System.Numerics;

namespace bai2btvn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtCount.Text.Trim(), out int count) || count < 0)
            {
                MessageBox.Show(this, "Vui lòng nhập số nguyên không âm.", "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCount.Focus();
                txtCount.SelectAll();
                return;
            }

            lstNumbers.BeginUpdate();
            try
            {
                for (int i = 0; i < count; i++)
                {
                    lstNumbers.Items.Add(Random.Shared.Next(1, 101));
                }
            }
            finally
            {
                lstNumbers.EndUpdate();
            }
        }

        private void btnSum_Click(object? sender, EventArgs e)
        {
            BigInteger sum = BigInteger.Zero;
            foreach (object item in lstNumbers.Items)
            {
                sum += BigInteger.Parse(item.ToString()!);
            }

            MessageBox.Show(this, $"Tổng các phần tử trong List là: {sum}", "Kết quả",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteEnds_Click(object? sender, EventArgs e)
        {
            if (lstNumbers.Items.Count == 0)
            {
                return;
            }

            lstNumbers.Items.RemoveAt(0);
            if (lstNumbers.Items.Count > 0)
            {
                lstNumbers.Items.RemoveAt(lstNumbers.Items.Count - 1);
            }
        }

        private void btnDeleteSelected_Click(object? sender, EventArgs e)
        {
            for (int i = lstNumbers.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstNumbers.Items.RemoveAt(lstNumbers.SelectedIndices[i]);
            }
        }

        private void btnIncrease_Click(object? sender, EventArgs e)
        {
            TransformItems(value => value + 2);
        }

        private void btnSquare_Click(object? sender, EventArgs e)
        {
            TransformItems(value => value * value);
        }

        private void TransformItems(Func<BigInteger, BigInteger> transform)
        {
            for (int i = 0; i < lstNumbers.Items.Count; i++)
            {
                BigInteger value = BigInteger.Parse(lstNumbers.Items[i]!.ToString()!);
                lstNumbers.Items[i] = transform(value);
            }
        }

        private void btnSelectEven_Click(object? sender, EventArgs e)
        {
            SelectByParity(even: true);
        }

        private void btnSelectOdd_Click(object? sender, EventArgs e)
        {
            SelectByParity(even: false);
        }

        private void SelectByParity(bool even)
        {
            for (int i = 0; i < lstNumbers.Items.Count; i++)
            {
                BigInteger value = BigInteger.Parse(lstNumbers.Items[i]!.ToString()!);
                lstNumbers.SetSelected(i, value.IsEven == even);
            }
        }

        private void btnExit_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}

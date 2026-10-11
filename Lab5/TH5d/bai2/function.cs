using System.Globalization;

namespace bai3
{
    public partial class Form1 : Form
    {
        private readonly TextBox accountNumberTextBox = new();
        private readonly TextBox customerNameTextBox = new();
        private readonly TextBox addressTextBox = new();
        private readonly TextBox balanceTextBox = new();
        private readonly Button addButton = new();
        private readonly Button saveButton = new();
        private readonly Button deleteButton = new();
        private readonly Button exitButton = new();
        private readonly ListView accountListView = new();
        private readonly TextBox totalTextBox = new();
        private bool isAdding;

        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            Text = "Quản lý thông tin tài khoản";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ClientSize = new Size(520, 438);
            Font = new Font("Segoe UI", 9F);

            var titleLabel = new Label
            {
                Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN",
                Font = new Font("Segoe UI", 15F, FontStyle.Bold),
                ForeColor = Color.Blue,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(10, 12),
                Size = new Size(500, 30)
            };
            Controls.Add(titleLabel);

            AddField("Số tài khoản", accountNumberTextBox, 52);
            AddField("Tên khách hàng", customerNameTextBox, 80);
            AddField("Địa chỉ khách hàng", addressTextBox, 108);
            AddField("Số tiền trong tài khoản", balanceTextBox, 136);

            addButton.Text = "Thêm";
            saveButton.Text = "Lưu";
            deleteButton.Text = "Xóa";
            exitButton.Text = "Thoát";
            saveButton.Enabled = false;
            deleteButton.Enabled = false;

            ConfigureButton(addButton, 163);
            ConfigureButton(saveButton, 235);
            ConfigureButton(deleteButton, 307);
            ConfigureButton(exitButton, 379);

            accountListView.Location = new Point(15, 198);
            accountListView.Size = new Size(490, 190);
            accountListView.View = View.Details;
            accountListView.FullRowSelect = true;
            accountListView.GridLines = true;
            accountListView.MultiSelect = false;
            accountListView.HideSelection = false;
            accountListView.Columns.Add("STT", 40);
            accountListView.Columns.Add("Số tài khoản", 105);
            accountListView.Columns.Add("Tên khách hàng", 125);
            accountListView.Columns.Add("Địa chỉ", 125);
            accountListView.Columns.Add("Số tiền", 85);
            Controls.Add(accountListView);

            var totalLabel = new Label
            {
                Text = "Tổng tiền",
                TextAlign = ContentAlignment.MiddleRight,
                Location = new Point(335, 397),
                Size = new Size(65, 24)
            };
            totalTextBox.Location = new Point(405, 397);
            totalTextBox.Size = new Size(100, 24);
            totalTextBox.ReadOnly = true;
            totalTextBox.TextAlign = HorizontalAlignment.Right;
            Controls.Add(totalLabel);
            Controls.Add(totalTextBox);

            Controls.Add(addButton);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(exitButton);

            addButton.Click += AddButton_Click;
            saveButton.Click += SaveButton_Click;
            deleteButton.Click += DeleteButton_Click;
            exitButton.Click += (_, _) => Close();
            accountListView.SelectedIndexChanged += AccountListView_SelectedIndexChanged;
        }

        private void AddField(string labelText, TextBox textBox, int top)
        {
            var label = new Label
            {
                Text = labelText,
                TextAlign = ContentAlignment.MiddleRight,
                Location = new Point(15, top),
                Size = new Size(125, 24)
            };
            textBox.Location = new Point(145, top);
            textBox.Size = new Size(360, 24);
            Controls.Add(label);
            Controls.Add(textBox);
        }

        private void ConfigureButton(Button button, int left)
        {
            button.Location = new Point(left, 163);
            button.Size = new Size(65, 27);
        }

        private void AddButton_Click(object? sender, EventArgs e)
        {
            if (isAdding)
            {
                isAdding = false;
                addButton.Text = "Thêm";
                saveButton.Enabled = false;
                ClearEntryFields();
                return;
            }

            isAdding = true;
            addButton.Text = "Hủy";
            saveButton.Enabled = true;
            deleteButton.Enabled = false;
            accountListView.SelectedItems.Clear();
            ClearEntryFields();
            accountNumberTextBox.Focus();
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            string accountNumber = accountNumberTextBox.Text.Trim();
            string customerName = customerNameTextBox.Text.Trim();
            string address = addressTextBox.Text.Trim();

            if (accountNumber.Length == 0 || customerName.Length == 0 || address.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string amountText = balanceTextBox.Text.Trim();
            bool validAmount = decimal.TryParse(amountText, NumberStyles.Number,
                CultureInfo.CurrentCulture, out decimal amount)
                || decimal.TryParse(amountText.Replace(",", ""), NumberStyles.Number,
                    CultureInfo.InvariantCulture, out amount);

            if (!validAmount || amount < 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ không âm.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                balanceTextBox.Focus();
                return;
            }

            var item = new ListViewItem(string.Empty);
            item.SubItems.Add(accountNumber);
            item.SubItems.Add(customerName);
            item.SubItems.Add(address);
            item.SubItems.Add(amount.ToString("N0", CultureInfo.InvariantCulture));
            accountListView.Items.Add(item);

            isAdding = false;
            addButton.Text = "Thêm";
            saveButton.Enabled = false;
            deleteButton.Enabled = false;
            UpdateSummary();
        }

        private void DeleteButton_Click(object? sender, EventArgs e)
        {
            if (accountListView.SelectedItems.Count == 0)
            {
                return;
            }

            accountListView.Items.Remove(accountListView.SelectedItems[0]);
            ClearEntryFields();
            deleteButton.Enabled = false;
            UpdateSummary();
        }

        private void AccountListView_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (accountListView.SelectedItems.Count == 0 || isAdding)
            {
                return;
            }

            ListViewItem item = accountListView.SelectedItems[0];
            accountNumberTextBox.Text = item.SubItems[1].Text;
            customerNameTextBox.Text = item.SubItems[2].Text;
            addressTextBox.Text = item.SubItems[3].Text;
            balanceTextBox.Text = item.SubItems[4].Text;
            deleteButton.Enabled = true;
        }

        private void ClearEntryFields()
        {
            accountNumberTextBox.Clear();
            customerNameTextBox.Clear();
            addressTextBox.Clear();
            balanceTextBox.Clear();
        }

        private void UpdateSummary()
        {
            decimal total = 0;

            for (int i = 0; i < accountListView.Items.Count; i++)
            {
                ListViewItem item = accountListView.Items[i];
                item.Text = (i + 1).ToString(CultureInfo.InvariantCulture);
                if (decimal.TryParse(item.SubItems[4].Text, NumberStyles.Number,
                    CultureInfo.InvariantCulture, out decimal amount))
                {
                    total += amount;
                }
            }

            totalTextBox.Text = total.ToString("N0", CultureInfo.InvariantCulture);
        }
    }
}

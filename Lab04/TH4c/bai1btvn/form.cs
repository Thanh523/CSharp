namespace maytinhbotui
{
    public partial class Form1 : Form
    {
        private readonly TextBox display = new();
        private decimal storedValue;
        private string? pendingOperator;
        private bool startNewNumber = true;

        public Form1()
        {
            InitializeComponent();
            InitializeCalculatorUi();
        }

        private void InitializeCalculatorUi()
        {
            Text = "Máy Tính Bỏ Túi";
            ClientSize = new Size(310, 365);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            var title = new Label
            {
                Text = "Máy Tính Bỏ Túi",
                Font = new Font("Times New Roman", 22, FontStyle.Bold),
                ForeColor = Color.Red,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(15, 12),
                Size = new Size(280, 48)
            };

            display.Location = new Point(24, 68);
            display.Size = new Size(262, 38);
            display.Font = new Font("Arial", 18, FontStyle.Regular);
            display.ForeColor = Color.Blue;
            display.TextAlign = HorizontalAlignment.Right;
            display.ReadOnly = true;
            display.TabStop = false;
            display.Text = "0";

            var keys = new[,]
            {
                { "1", "2", "3", "4" },
                { "5", "6", "7", "8" },
                { "9", "0", "=", "C" },
                { "+", "-", "*", "/" }
            };

            Controls.Add(title);
            Controls.Add(display);

            for (var row = 0; row < keys.GetLength(0); row++)
            {
                for (var column = 0; column < keys.GetLength(1); column++)
                {
                    var key = keys[row, column];
                    var button = new Button
                    {
                        Text = key,
                        Font = new Font("Arial", 14),
                        Location = new Point(28 + column * 66, 118 + row * 51),
                        Size = new Size(54, 40),
                        UseVisualStyleBackColor = true
                    };

                    button.Click += (_, _) => HandleKey(key);
                    Controls.Add(button);
                }
            }
        }

        private void HandleKey(string key)
        {
            if (key.Length == 1 && char.IsDigit(key[0]))
            {
                if (startNewNumber || display.Text == "0")
                {
                    display.Text = key;
                }
                else
                {
                    display.Text += key;
                }

                startNewNumber = false;
                return;
            }

            if (key == "C")
            {
                display.Text = "0";
                storedValue = 0;
                pendingOperator = null;
                startNewNumber = true;
                return;
            }

            if (key == "=")
            {
                if (pendingOperator is not null && decimal.TryParse(display.Text, out var currentValue))
                {
                    if (!TryCalculate(storedValue, currentValue, pendingOperator, out var result))
                    {
                        display.Text = "Lỗi";
                        pendingOperator = null;
                        startNewNumber = true;
                        return;
                    }

                    display.Text = result.ToString();
                    storedValue = result;
                    pendingOperator = null;
                    startNewNumber = true;
                }

                return;
            }

            if (key is "+" or "-" or "*" or "/")
            {
                if (!decimal.TryParse(display.Text, out var currentValue))
                {
                    return;
                }

                if (pendingOperator is not null && !startNewNumber)
                {
                    if (!TryCalculate(storedValue, currentValue, pendingOperator, out currentValue))
                    {
                        display.Text = "Lỗi";
                        pendingOperator = null;
                        startNewNumber = true;
                        return;
                    }

                    display.Text = currentValue.ToString();
                }

                storedValue = currentValue;
                pendingOperator = key;
                startNewNumber = true;
            }
        }

        private static bool TryCalculate(decimal left, decimal right, string operation, out decimal result)
        {
            result = 0;

            switch (operation)
            {
                case "+":
                    result = left + right;
                    return true;
                case "-":
                    result = left - right;
                    return true;
                case "*":
                    result = left * right;
                    return true;
                case "/":
                    if (right == 0)
                    {
                        return false;
                    }

                    result = left / right;
                    return true;
                default:
                    return false;
            }
        }
    }
}

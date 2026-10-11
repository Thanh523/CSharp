namespace bai1btvn
{
    public partial class Form1 : Form
    {
        private TimeSpan remainingTime = TimeSpan.FromMinutes(30);

        public Form1()
        {
            InitializeComponent();
            timer1.Tick += Timer1_Tick;
            UpdateTimeDisplay();
            btnStart.Click += BtnStart_Click;
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            btnStart.Enabled = false;
            timer1.Start();
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            if (remainingTime > TimeSpan.Zero)
            {
                remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
                UpdateTimeDisplay();
            }

            if (remainingTime == TimeSpan.Zero)
            {
                timer1.Stop();
                MessageBox.Show("Đã hết thời gian!", "Đồng hồ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateTimeDisplay()
        {
            lblTime.Text = $"{(int)remainingTime.TotalMinutes:00}:{remainingTime.Seconds:00}";
        }
    }
}

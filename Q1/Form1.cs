namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "問候";
            this.MinimizeBox = MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;

            generateButton.Text = "執行";            
            
            displayLabel.Text = String.Empty;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // 取得時間
            DateTime now = DateTime.Now;
            string nowString = now.ToString("yyyy/MM/dd HH:mm:ss");

            // 依據時間呈現不同的問候語
            string greet = GetGreet(now.Hour);

            // 呈現時間與問候語
            displayLabel.Text = 
                $"{greet}\r\n" + $"現在時間: " +
                $"{nowString}" 
                ;
            MessageBox.Show($"現在時間:" + $"{nowString}\r\n");
        }

        private string GetGreet(int hour)
        {
            string result = string.Empty;
            if (hour >= 0 && hour < 13)
            { result = "早安"; }
            else if (hour < 19)
            { result = "午安"; }
            else 
            { result = "晚安"; }
            
            return result;
        }
    }
}
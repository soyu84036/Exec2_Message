namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "�ݭ�";
            this.MinimizeBox = MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;

            generateButton.Text = "����";            
            
            displayLabel.Text = String.Empty;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // ���o�ɶ�
            DateTime now = DateTime.Now;
            string nowString = now.ToString("yyyy/MM/dd HH:mm:ss");

            // �̾ڮɶ��e�{���P���ݭԻy
            string greet = GetGreet(now.Hour);

            // �e�{�ɶ��P�ݭԻy
            displayLabel.Text = 
                $"{greet}\r\n" + $"�{�b�ɶ�: " +
                $"{nowString}" 
                ;
            MessageBox.Show($"�{�b�ɶ�:" + $"{nowString}\r\n");
        }

        private string GetGreet(int hour)
        {
            string result = string.Empty;
            if (hour >= 0 && hour < 13)
            { result = "���w"; }
            else if (hour < 19)
            { result = "�Ȧw"; }
            else 
            { result = "�ߦw"; }
            
            return result;
        }
    }
}
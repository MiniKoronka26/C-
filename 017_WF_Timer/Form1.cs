namespace _017_WF_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            labelTime.Text = DateTime.Now.ToLongTimeString();

            DateTime now = DateTime.Now;
            DateTime dateAfterWeek = new DateTime(2026, 1, 21);

            TimeSpan difference = dateAfterWeek - now;
            MessageBox.Show(difference.TotalDays.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

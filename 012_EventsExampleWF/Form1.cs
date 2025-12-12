namespace _012_EventsExampleWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Button Clicked!");
            this.BackColor = Color.DarkRed;
            button1.BackColor = Color.DarkSeaGreen;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"x: {e.X}, y: {e.Y}";
        }
    }
}

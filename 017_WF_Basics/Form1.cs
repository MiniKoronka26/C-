using System.ComponentModel;

namespace _017_WF_Basics
{
    public partial class Form1 : Form
    {

        int count = 0;
        int count2 = 0;

        public Form1()
        {
            InitializeComponent();

            /*DialogResult result = MessageBox.Show("Test", "Message", MessageBoxButtons.RetryCancel);

            while (result != DialogResult.Cancel)
            {
                result = MessageBox.Show("Test", "Message", MessageBoxButtons.RetryCancel);
            }*/

            /*if (result == DialogResult.OK)
            {
                MessageBox.Show("You clicked on 'OK'");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("You clicked on 'Cancel'");
            }*/



        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            /*if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("You clicked on left button",
                    "Error", 
                    MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Error);
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("You clicked on right button",
                    "Message", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }*/


            this.Text = count++.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            // this.Text = $"X: {e.X}, Y: {e.Y}";
            textLabel.Text = $"X: {e.X}, Y: {e.Y}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*this.BackColor = Color.FromArgb(18, 36, 98);*/

            Random random = new Random();

            this.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*MessageBox.Show("Message");*/
            labelCount.Text = count2++.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ми раді за вас!");
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Top -= e.Y;
            button2.Left += e.Y;

            if(button2.Top < -100 || button2.Top > 250)
                button2.Top = 190;

            if(button2.Left < -120 || button2.Left > 260)
                button2.Left = 280;

        }
    }
}

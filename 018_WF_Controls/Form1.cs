using System.Diagnostics.Eventing.Reader;

namespace _018_WF_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            /*button1.BackColor = Color.FromArgb(36, 98, 2);*/
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            /*button1.BackColor = Color.FromArgb(98, 98, 2);*/
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(25, 36, 98);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(98, 2, 3);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                MessageBox.Show("You are happy :)");
            else if (!checkBox1.Checked)
                MessageBox.Show("You are not happy :(");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
                MessageBox.Show("You want a piece of pizza");
            else if (checkBox2.CheckState == CheckState.Unchecked)
                MessageBox.Show("You don`t want a piece of pizza");
            else if (checkBox2.CheckState == CheckState.Indeterminate)
                MessageBox.Show("You don`t know");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                this.BackColor = Color.FromArgb(35, 35, 35);
                this.ForeColor = Color.White;
                button1.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("You`re men");
            else if (!radioButton1.Checked)
                MessageBox.Show("You`re women");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + "\n" + textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            /*textBox1.Text = "";*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}

namespace _017_WF_Basics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            labelCount = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.BackColor = SystemColors.ActiveCaptionText;
            textLabel.Font = new Font("Swis721 BlkEx BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textLabel.ForeColor = SystemColors.ActiveCaption;
            textLabel.Location = new Point(12, 19);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(165, 57);
            textLabel.TabIndex = 0;
            textLabel.Text = "Text";
            textLabel.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Swis721 BlkEx BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(300, 250);
            button1.Name = "button1";
            button1.Size = new Size(143, 73);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Swis721 BlkEx BT", 14.25F);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(525, 250);
            button2.Name = "button2";
            button2.Size = new Size(143, 73);
            button2.TabIndex = 2;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseMove += button2_MouseMove;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.BackColor = SystemColors.ActiveCaptionText;
            labelCount.Font = new Font("Swis721 BlkEx BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCount.ForeColor = SystemColors.ActiveCaption;
            labelCount.Location = new Point(12, 112);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(71, 57);
            labelCount.TabIndex = 3;
            labelCount.Text = "0";
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Swis721 BlkEx BT", 14.25F);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(974, 31);
            button3.Name = "button3";
            button3.Size = new Size(143, 73);
            button3.TabIndex = 4;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1144, 609);
            Controls.Add(button3);
            Controls.Add(labelCount);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Моє вікно";
            MouseClick += Form1_MouseClick;
            MouseDoubleClick += Form1_MouseDoubleClick;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textLabel;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private Label labelCount;
        private Button button3;
    }
}

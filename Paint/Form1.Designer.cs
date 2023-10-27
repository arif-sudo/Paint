namespace Paint
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            trackBar1 = new TrackBar();
            thickness = new Label();
            colorDialog1 = new ColorDialog();
            saveFileDialog1 = new SaveFileDialog();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(0, 377);
            button1.Name = "button1";
            button1.Size = new Size(181, 38);
            button1.TabIndex = 1;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Bottom;
            button2.Location = new Point(0, 415);
            button2.Name = "button2";
            button2.Size = new Size(181, 35);
            button2.TabIndex = 2;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 94);
            panel1.TabIndex = 3;
            // 
            // button10
            // 
            button10.BackColor = Color.Black;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(124, 48);
            button10.Name = "button10";
            button10.Size = new Size(30, 30);
            button10.TabIndex = 7;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button3_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(192, 0, 192);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(88, 48);
            button9.Name = "button9";
            button9.Size = new Size(30, 30);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button3_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Yellow;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(52, 48);
            button8.Name = "button8";
            button8.Size = new Size(30, 30);
            button8.TabIndex = 5;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button3_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Blue;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(16, 48);
            button7.Name = "button7";
            button7.Size = new Size(30, 30);
            button7.TabIndex = 4;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button3_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Lime;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(124, 12);
            button6.Name = "button6";
            button6.Size = new Size(30, 30);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Cyan;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(88, 12);
            button5.Name = "button5";
            button5.Size = new Size(30, 30);
            button5.TabIndex = 2;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(52, 12);
            button4.Name = "button4";
            button4.Size = new Size(30, 30);
            button4.TabIndex = 1;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button3_Click;
            // 
            // button3
            // 
            button3.Location = new Point(16, 12);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            button3.Click += palitra_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(trackBar1);
            panel2.Controls.Add(thickness);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(181, 108);
            panel2.TabIndex = 4;
            // 
            // trackBar1
            // 
            trackBar1.Dock = DockStyle.Bottom;
            trackBar1.Location = new Point(0, 50);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(179, 56);
            trackBar1.TabIndex = 1;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // thickness
            // 
            thickness.Dock = DockStyle.Top;
            thickness.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            thickness.Location = new Point(0, 0);
            thickness.Name = "thickness";
            thickness.Size = new Size(179, 30);
            thickness.TabIndex = 0;
            thickness.Text = "Choice of thickness";
            thickness.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(619, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(181, 450);
            panel3.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Panel panel2;
        private Label thickness;
        public TrackBar trackBar1;
        private ColorDialog colorDialog1;
        private SaveFileDialog saveFileDialog1;
        private Panel panel3;
    }
}
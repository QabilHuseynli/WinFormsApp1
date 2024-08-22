namespace WinFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            Sidebarcontainer = new FlowLayoutPanel();
            panel5 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            button5 = new Button();
            panel3 = new Panel();
            button4 = new Button();
            panel4 = new Panel();
            panel7 = new Panel();
            button2 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            button3 = new Button();
            sidebartimer = new System.Windows.Forms.Timer(components);
            button6 = new Button();
            Sidebarcontainer.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebarcontainer
            // 
            Sidebarcontainer.BackColor = Color.FromArgb(16, 18, 25);
            Sidebarcontainer.Controls.Add(panel5);
            Sidebarcontainer.Controls.Add(panel6);
            Sidebarcontainer.Controls.Add(panel3);
            Sidebarcontainer.Controls.Add(panel7);
            Sidebarcontainer.Controls.Add(panel1);
            Sidebarcontainer.Controls.Add(panel2);
            Sidebarcontainer.Dock = DockStyle.Left;
            Sidebarcontainer.Location = new Point(0, 0);
            Sidebarcontainer.MaximumSize = new Size(190, 736);
            Sidebarcontainer.MinimumSize = new Size(75, 736);
            Sidebarcontainer.Name = "Sidebarcontainer";
            Sidebarcontainer.Size = new Size(75, 736);
            Sidebarcontainer.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(186, 66);
            panel5.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(106, 20);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Location = new Point(3, 75);
            panel6.Name = "panel6";
            panel6.Size = new Size(186, 66);
            panel6.TabIndex = 3;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(16, 18, 25);
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Dock = DockStyle.Fill;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(186, 66);
            button5.TabIndex = 1;
            button5.Text = "              About";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button4);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(3, 147);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 66);
            panel3.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(16, 18, 25);
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(183, 66);
            button4.TabIndex = 1;
            button4.Text = "              Help";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel4
            // 
            panel4.Location = new Point(1, 73);
            panel4.Name = "panel4";
            panel4.Size = new Size(183, 71);
            panel4.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(button2);
            panel7.Location = new Point(3, 219);
            panel7.Name = "panel7";
            panel7.Size = new Size(186, 66);
            panel7.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(16, 18, 25);
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(186, 66);
            button2.TabIndex = 1;
            button2.Text = "              Settings";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 291);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 66);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(16, 18, 25);
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(186, 66);
            button1.TabIndex = 1;
            button1.Text = "              Graph";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Location = new Point(3, 363);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 66);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(16, 18, 25);
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(183, 66);
            button3.TabIndex = 1;
            button3.Text = "              Home";
            button3.UseVisualStyleBackColor = false;
            // 
            // sidebartimer
            // 
            sidebartimer.Interval = 10;
            sidebartimer.Tick += sidebartimer_Tick;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.Cursor = Cursors.Help;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(1096, 12);
            button6.Name = "button6";
            button6.Size = new Size(27, 39);
            button6.TabIndex = 8;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1135, 736);
            Controls.Add(button6);
            Controls.Add(Sidebarcontainer);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            Sidebarcontainer.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel Sidebarcontainer;
        private Panel panel1;
        private Button button1;
        private System.Windows.Forms.Timer sidebartimer;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel2;
        private Panel panel6;
        private Button button4;
        private Panel panel7;
        private Button button5;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button6;
    }
}
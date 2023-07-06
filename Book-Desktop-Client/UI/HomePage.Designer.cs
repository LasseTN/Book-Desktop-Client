namespace Book_Desktop_Client {
    partial class HomePage {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            Menu = new GroupBox();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.Info;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(Menu);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1033, 725);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(422, 143);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Menu
            // 
            Menu.Controls.Add(button4);
            Menu.Controls.Add(button3);
            Menu.Controls.Add(button1);
            Menu.Controls.Add(button2);
            Menu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Menu.Location = new Point(3, 152);
            Menu.Name = "Menu";
            Menu.Size = new Size(1015, 501);
            Menu.TabIndex = 5;
            Menu.TabStop = false;
            Menu.Text = "Menu";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(9, 178);
            button3.Name = "button3";
            button3.Size = new Size(210, 50);
            button3.TabIndex = 3;
            button3.Text = "Administrer lokationer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(9, 43);
            button1.Name = "button1";
            button1.Size = new Size(210, 50);
            button1.TabIndex = 1;
            button1.Text = "Administrer medarbejdere";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(9, 110);
            button2.Name = "button2";
            button2.Size = new Size(210, 50);
            button2.TabIndex = 2;
            button2.Text = "Administrer genrer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(9, 247);
            button4.Name = "button4";
            button4.Size = new Size(210, 50);
            button4.TabIndex = 4;
            button4.Text = "Administrer bog";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 725);
            Controls.Add(flowLayoutPanel1);
            Name = "HomePage";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private GroupBox Menu;
        private Button button3;
        private Button button4;
    }
}
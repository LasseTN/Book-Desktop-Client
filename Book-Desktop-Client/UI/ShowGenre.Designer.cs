namespace Book_Desktop_Client.UI {
    partial class ShowGenre {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            listView1 = new ListView();
            label1 = new Label();
            buttoShowGenres = new Button();
            buttonCreateGenre = new Button();
            label2 = new Label();
            label3 = new Label();
            textBoxGenre = new TextBox();
            buttonUpdateGenre = new Button();
            buttonDeleteGenre = new Button();
            buttonCloseWindow = new Button();
            textBox1 = new TextBox();
            labelGenreId = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(65, 99);
            listView1.Name = "listView1";
            listView1.Size = new Size(348, 264);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 26);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 1;
            label1.Text = "Liste over genrer";
            // 
            // buttoShowGenres
            // 
            buttoShowGenres.Location = new Point(65, 396);
            buttoShowGenres.Name = "buttoShowGenres";
            buttoShowGenres.Size = new Size(75, 23);
            buttoShowGenres.TabIndex = 2;
            buttoShowGenres.Text = "Vis genrer";
            buttoShowGenres.UseVisualStyleBackColor = true;
            buttoShowGenres.Click += buttoShowGenres_Click;
            // 
            // buttonCreateGenre
            // 
            buttonCreateGenre.Location = new Point(459, 396);
            buttonCreateGenre.Name = "buttonCreateGenre";
            buttonCreateGenre.Size = new Size(95, 23);
            buttonCreateGenre.TabIndex = 4;
            buttonCreateGenre.Text = "Tilføj genre";
            buttonCreateGenre.UseVisualStyleBackColor = true;
            buttonCreateGenre.Click += buttonCreateGenre_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(459, 26);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 5;
            label2.Text = "Tilføj genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(459, 70);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Genre";
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(459, 99);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(116, 23);
            textBoxGenre.TabIndex = 7;
            // 
            // buttonUpdateGenre
            // 
            buttonUpdateGenre.Location = new Point(573, 396);
            buttonUpdateGenre.Name = "buttonUpdateGenre";
            buttonUpdateGenre.Size = new Size(95, 23);
            buttonUpdateGenre.TabIndex = 8;
            buttonUpdateGenre.Text = "Opdater genre";
            buttonUpdateGenre.UseVisualStyleBackColor = true;
            buttonUpdateGenre.Click += buttonUpdateGenre_Click;
            // 
            // buttonDeleteGenre
            // 
            buttonDeleteGenre.Location = new Point(684, 396);
            buttonDeleteGenre.Name = "buttonDeleteGenre";
            buttonDeleteGenre.Size = new Size(95, 23);
            buttonDeleteGenre.TabIndex = 9;
            buttonDeleteGenre.Text = "Slet genre";
            buttonDeleteGenre.UseVisualStyleBackColor = true;
            buttonDeleteGenre.Click += buttonDeleteGenre_Click;
            // 
            // buttonCloseWindow
            // 
            buttonCloseWindow.BackColor = Color.Salmon;
            buttonCloseWindow.Location = new Point(684, 443);
            buttonCloseWindow.Name = "buttonCloseWindow";
            buttonCloseWindow.Size = new Size(95, 23);
            buttonCloseWindow.TabIndex = 10;
            buttonCloseWindow.Text = "Luk vinduet";
            buttonCloseWindow.UseVisualStyleBackColor = false;
            buttonCloseWindow.Click += buttonCloseWindow_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(459, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 23);
            textBox1.TabIndex = 11;
            // 
            // labelGenreId
            // 
            labelGenreId.AutoSize = true;
            labelGenreId.BackColor = SystemColors.Info;
            labelGenreId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGenreId.Location = new Point(459, 150);
            labelGenreId.Name = "labelGenreId";
            labelGenreId.Size = new Size(55, 15);
            labelGenreId.TabIndex = 12;
            labelGenreId.Text = "Genre id";
            // 
            // ShowGenre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(858, 500);
            Controls.Add(labelGenreId);
            Controls.Add(textBox1);
            Controls.Add(buttonCloseWindow);
            Controls.Add(buttonDeleteGenre);
            Controls.Add(buttonUpdateGenre);
            Controls.Add(textBoxGenre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonCreateGenre);
            Controls.Add(buttoShowGenres);
            Controls.Add(label1);
            Controls.Add(listView1);
            ForeColor = SystemColors.ControlText;
            Name = "ShowGenre";
            Text = "ShowGenrer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Button buttoShowGenres;
        private Button buttonCreateGenre;
        private Label label2;
        private Label label3;
        private TextBox textBoxGenre;
        private Button buttonUpdateGenre;
        private Button buttonDeleteGenre;
        private Button buttonCloseWindow;
        private TextBox textBox1;
        private Label labelGenreId;
    }
}
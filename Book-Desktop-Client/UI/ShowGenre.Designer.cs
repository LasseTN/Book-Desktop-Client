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
            listViewShowGenres = new ListView();
            Genre = new ColumnHeader();
            Id = new ColumnHeader();
            label1 = new Label();
            buttoGetGenres = new Button();
            buttonCreateGenre = new Button();
            label2 = new Label();
            label3 = new Label();
            textBoxGenre = new TextBox();
            buttonUpdateGenre = new Button();
            buttonDeleteGenre = new Button();
            buttonCloseWindow = new Button();
            textBoxGenreId = new TextBox();
            labelGenreId = new Label();
            labelProcessText = new Label();
            SuspendLayout();
            // 
            // listViewShowGenres
            // 
            listViewShowGenres.BackColor = SystemColors.ScrollBar;
            listViewShowGenres.Columns.AddRange(new ColumnHeader[] { Genre, Id });
            listViewShowGenres.Cursor = Cursors.Hand;
            listViewShowGenres.Location = new Point(65, 99);
            listViewShowGenres.Name = "listViewShowGenres";
            listViewShowGenres.Size = new Size(245, 269);
            listViewShowGenres.TabIndex = 0;
            listViewShowGenres.UseCompatibleStateImageBehavior = false;
            listViewShowGenres.View = View.Details;
            listViewShowGenres.SelectedIndexChanged += listViewShowGenres_SelectedIndexChanged;
            // 
            // Genre
            // 
            Genre.Text = "Genre";
            Genre.Width = 150;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 70;
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
            // buttoGetGenres
            // 
            buttoGetGenres.Location = new Point(65, 396);
            buttoGetGenres.Name = "buttoGetGenres";
            buttoGetGenres.Size = new Size(75, 23);
            buttoGetGenres.TabIndex = 2;
            buttoGetGenres.Text = "Vis genrer";
            buttoGetGenres.UseVisualStyleBackColor = true;
            buttoGetGenres.Click += buttoGetGenres_Click;
            // 
            // buttonCreateGenre
            // 
            buttonCreateGenre.Location = new Point(362, 396);
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
            label2.Location = new Point(362, 26);
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
            label3.Location = new Point(362, 70);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Genre";
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(362, 99);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(116, 23);
            textBoxGenre.TabIndex = 7;
            // 
            // buttonUpdateGenre
            // 
            buttonUpdateGenre.Location = new Point(476, 396);
            buttonUpdateGenre.Name = "buttonUpdateGenre";
            buttonUpdateGenre.Size = new Size(95, 23);
            buttonUpdateGenre.TabIndex = 8;
            buttonUpdateGenre.Text = "Opdater genre";
            buttonUpdateGenre.UseVisualStyleBackColor = true;
            buttonUpdateGenre.Click += buttonUpdateGenre_Click;
            // 
            // buttonDeleteGenre
            // 
            buttonDeleteGenre.Location = new Point(587, 396);
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
            buttonCloseWindow.Location = new Point(587, 443);
            buttonCloseWindow.Name = "buttonCloseWindow";
            buttonCloseWindow.Size = new Size(95, 23);
            buttonCloseWindow.TabIndex = 10;
            buttonCloseWindow.Text = "Luk vinduet";
            buttonCloseWindow.UseVisualStyleBackColor = false;
            buttonCloseWindow.Click += buttonCloseWindow_Click;
            // 
            // textBoxGenreId
            // 
            textBoxGenreId.Location = new Point(362, 177);
            textBoxGenreId.Name = "textBoxGenreId";
            textBoxGenreId.Size = new Size(116, 23);
            textBoxGenreId.TabIndex = 11;
            // 
            // labelGenreId
            // 
            labelGenreId.AutoSize = true;
            labelGenreId.BackColor = SystemColors.Info;
            labelGenreId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGenreId.Location = new Point(362, 150);
            labelGenreId.Name = "labelGenreId";
            labelGenreId.Size = new Size(55, 15);
            labelGenreId.TabIndex = 12;
            labelGenreId.Text = "Genre id";
            // 
            // labelProcessText
            // 
            labelProcessText.AutoSize = true;
            labelProcessText.Location = new Point(65, 443);
            labelProcessText.Name = "labelProcessText";
            labelProcessText.Size = new Size(16, 15);
            labelProcessText.TabIndex = 13;
            labelProcessText.Text = "...";
            // 
            // ShowGenre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(738, 493);
            Controls.Add(labelProcessText);
            Controls.Add(labelGenreId);
            Controls.Add(textBoxGenreId);
            Controls.Add(buttonCloseWindow);
            Controls.Add(buttonDeleteGenre);
            Controls.Add(buttonUpdateGenre);
            Controls.Add(textBoxGenre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonCreateGenre);
            Controls.Add(buttoGetGenres);
            Controls.Add(label1);
            Controls.Add(listViewShowGenres);
            ForeColor = SystemColors.ControlText;
            Name = "ShowGenre";
            Text = "ShowGenrer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewShowGenres;
        private Label label1;
        private Button buttoGetGenres;
        private Button buttonCreateGenre;
        private Label label2;
        private Label label3;
        private TextBox textBoxGenre;
        private Button buttonUpdateGenre;
        private Button buttonDeleteGenre;
        private Button buttonCloseWindow;
        private TextBox textBoxGenreId;
        private Label labelGenreId;
        private Label labelProcessText;
        private ColumnHeader Genre;
        private ColumnHeader Id;
    }
}
namespace Book_Desktop_Client.UI {
    partial class ShowLocations {
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
            label1 = new Label();
            label2 = new Label();
            listViewShowLocations = new ListView();
            Lokation = new ColumnHeader();
            Id = new ColumnHeader();
            label3 = new Label();
            labelGenreId = new Label();
            textBoxLocation = new TextBox();
            textBoxLocationId = new TextBox();
            labelProcessText = new Label();
            buttoGetLocations = new Button();
            buttonCreateLocation = new Button();
            buttonDeleteLocation = new Button();
            buttonCloseWindow = new Button();
            buttonUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 37);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 2;
            label1.Text = "Liste over lokationer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(364, 37);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 6;
            label2.Text = "Tilføj lokation";
            // 
            // listViewShowLocations
            // 
            listViewShowLocations.BackColor = SystemColors.ScrollBar;
            listViewShowLocations.Columns.AddRange(new ColumnHeader[] { Lokation, Id });
            listViewShowLocations.Cursor = Cursors.Hand;
            listViewShowLocations.Location = new Point(60, 83);
            listViewShowLocations.Name = "listViewShowLocations";
            listViewShowLocations.Size = new Size(245, 269);
            listViewShowLocations.TabIndex = 7;
            listViewShowLocations.UseCompatibleStateImageBehavior = false;
            listViewShowLocations.View = View.Details;
            listViewShowLocations.SelectedIndexChanged += listViewShowLocations_SelectedIndexChanged;
            // 
            // Lokation
            // 
            Lokation.Text = "Lokation";
            Lokation.Width = 150;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 70;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(364, 83);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 8;
            label3.Text = "Lokation";
            // 
            // labelGenreId
            // 
            labelGenreId.AutoSize = true;
            labelGenreId.BackColor = SystemColors.Info;
            labelGenreId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGenreId.Location = new Point(364, 149);
            labelGenreId.Name = "labelGenreId";
            labelGenreId.Size = new Size(62, 15);
            labelGenreId.TabIndex = 13;
            labelGenreId.Text = "Loktion id";
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new Point(364, 110);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(116, 23);
            textBoxLocation.TabIndex = 14;
            // 
            // textBoxLocationId
            // 
            textBoxLocationId.Location = new Point(364, 181);
            textBoxLocationId.Name = "textBoxLocationId";
            textBoxLocationId.Size = new Size(116, 23);
            textBoxLocationId.TabIndex = 15;
            // 
            // labelProcessText
            // 
            labelProcessText.AutoSize = true;
            labelProcessText.Location = new Point(60, 445);
            labelProcessText.Name = "labelProcessText";
            labelProcessText.Size = new Size(16, 15);
            labelProcessText.TabIndex = 16;
            labelProcessText.Text = "...";
            // 
            // buttoGetLocations
            // 
            buttoGetLocations.Location = new Point(60, 384);
            buttoGetLocations.Name = "buttoGetLocations";
            buttoGetLocations.Size = new Size(91, 23);
            buttoGetLocations.TabIndex = 17;
            buttoGetLocations.Text = "Vis lokationer";
            buttoGetLocations.UseVisualStyleBackColor = true;
            buttoGetLocations.Click += buttoGetLocations_Click;
            // 
            // buttonCreateLocation
            // 
            buttonCreateLocation.Location = new Point(364, 384);
            buttonCreateLocation.Name = "buttonCreateLocation";
            buttonCreateLocation.Size = new Size(95, 23);
            buttonCreateLocation.TabIndex = 18;
            buttonCreateLocation.Text = "Tilføj lokation";
            buttonCreateLocation.UseVisualStyleBackColor = true;
            buttonCreateLocation.Click += buttonCreateLocation_Click;
            // 
            // buttonDeleteLocation
            // 
            buttonDeleteLocation.Location = new Point(608, 384);
            buttonDeleteLocation.Name = "buttonDeleteLocation";
            buttonDeleteLocation.Size = new Size(95, 23);
            buttonDeleteLocation.TabIndex = 20;
            buttonDeleteLocation.Text = "Slet lokation";
            buttonDeleteLocation.UseVisualStyleBackColor = true;
            buttonDeleteLocation.Click += buttonDeleteLocation_Click;
            // 
            // buttonCloseWindow
            // 
            buttonCloseWindow.BackColor = Color.Salmon;
            buttonCloseWindow.Location = new Point(608, 424);
            buttonCloseWindow.Name = "buttonCloseWindow";
            buttonCloseWindow.Size = new Size(95, 23);
            buttonCloseWindow.TabIndex = 21;
            buttonCloseWindow.Text = "Luk vinduet";
            buttonCloseWindow.UseVisualStyleBackColor = false;
            buttonCloseWindow.Click += buttonCloseWindow_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(477, 384);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(115, 23);
            buttonUpdate.TabIndex = 22;
            buttonUpdate.Text = "Opdater lokation";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += ButtonUpdateLocation_Click;
            // 
            // ShowLocations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(738, 493);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonCloseWindow);
            Controls.Add(buttonDeleteLocation);
            Controls.Add(buttonCreateLocation);
            Controls.Add(buttoGetLocations);
            Controls.Add(labelProcessText);
            Controls.Add(textBoxLocationId);
            Controls.Add(textBoxLocation);
            Controls.Add(labelGenreId);
            Controls.Add(label3);
            Controls.Add(listViewShowLocations);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ShowLocations";
            Text = "ShowLocations";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView listViewShowLocations;
        private ColumnHeader Lokation;
        private ColumnHeader Id;
        private Label label3;
        private Label labelGenreId;
        private TextBox textBoxLocation;
        private TextBox textBoxLocationId;
        private Label labelProcessText;
        private Button buttoGetLocations;
        private Button buttonCreateLocation;
        private Button buttonDeleteLocation;
        private Button buttonCloseWindow;
        private Button buttonUpdate;
    }
}
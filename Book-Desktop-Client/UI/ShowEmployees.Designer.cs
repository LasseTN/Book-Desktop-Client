namespace Book_Desktop_Client.UI {
    partial class ShowEmployees {
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
            listViewShowEmployees = new ListView();
            FirstName = new ColumnHeader();
            LastName = new ColumnHeader();
            Address = new ColumnHeader();
            Phone = new ColumnHeader();
            Email = new ColumnHeader();
            Birthdate = new ColumnHeader();
            Id = new ColumnHeader();
            Medarbejderliste = new Label();
            labelProcessText = new Label();
            textBoxFirstName = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            textBoxLastName = new TextBox();
            lblAddress = new Label();
            textBoxAddress = new TextBox();
            lblMobil = new Label();
            textBoxMobil = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelBirthdate = new Label();
            labelId = new Label();
            textBoxEmployeeId = new TextBox();
            dateTimePickerEmployee = new DateTimePicker();
            buttonCloseWindow = new Button();
            btnGetEmployees = new Button();
            buttonUpdateEmployee = new Button();
            buttonCreateEmployee = new Button();
            buttonDeleteEmployee = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listViewShowEmployees
            // 
            listViewShowEmployees.BackColor = SystemColors.ScrollBar;
            listViewShowEmployees.Columns.AddRange(new ColumnHeader[] { FirstName, LastName, Address, Phone, Email, Birthdate, Id });
            listViewShowEmployees.Cursor = Cursors.Hand;
            listViewShowEmployees.Location = new Point(70, 103);
            listViewShowEmployees.Name = "listViewShowEmployees";
            listViewShowEmployees.Size = new Size(668, 432);
            listViewShowEmployees.TabIndex = 0;
            listViewShowEmployees.UseCompatibleStateImageBehavior = false;
            listViewShowEmployees.View = View.Details;
            listViewShowEmployees.SelectedIndexChanged += listViewShowEmployees_SelectedIndexChanged;
            // 
            // FirstName
            // 
            FirstName.Text = "Fornavn";
            FirstName.Width = 100;
            // 
            // LastName
            // 
            LastName.Text = "Efternavn";
            LastName.Width = 150;
            // 
            // Address
            // 
            Address.Text = "Adresse";
            Address.Width = 100;
            // 
            // Phone
            // 
            Phone.Text = "Mobil";
            Phone.Width = 70;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 100;
            // 
            // Birthdate
            // 
            Birthdate.Text = "Fødselsdato";
            Birthdate.Width = 80;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // Medarbejderliste
            // 
            Medarbejderliste.AutoSize = true;
            Medarbejderliste.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Medarbejderliste.Location = new Point(70, 42);
            Medarbejderliste.Name = "Medarbejderliste";
            Medarbejderliste.Size = new Size(157, 17);
            Medarbejderliste.TabIndex = 2;
            Medarbejderliste.Text = "Liste over medarbejdere";
            // 
            // labelProcessText
            // 
            labelProcessText.AutoSize = true;
            labelProcessText.Location = new Point(70, 626);
            labelProcessText.Name = "labelProcessText";
            labelProcessText.Size = new Size(16, 15);
            labelProcessText.TabIndex = 3;
            labelProcessText.Text = "...";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(880, 103);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(146, 23);
            textBoxFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.Location = new Point(880, 83);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(58, 17);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "Fornavn";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(880, 147);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(67, 17);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Efternavn";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(880, 167);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(146, 23);
            textBoxLastName.TabIndex = 6;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(880, 209);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(56, 17);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Adresse";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(880, 229);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(146, 23);
            textBoxAddress.TabIndex = 8;
            // 
            // lblMobil
            // 
            lblMobil.AutoSize = true;
            lblMobil.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMobil.Location = new Point(880, 268);
            lblMobil.Name = "lblMobil";
            lblMobil.Size = new Size(44, 17);
            lblMobil.TabIndex = 11;
            lblMobil.Text = "Mobil";
            // 
            // textBoxMobil
            // 
            textBoxMobil.Location = new Point(880, 288);
            textBoxMobil.Name = "textBoxMobil";
            textBoxMobil.Size = new Size(146, 23);
            textBoxMobil.TabIndex = 10;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(880, 326);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(42, 17);
            labelEmail.TabIndex = 13;
            labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(880, 352);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(146, 23);
            textBoxEmail.TabIndex = 12;
            // 
            // labelBirthdate
            // 
            labelBirthdate.AutoSize = true;
            labelBirthdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelBirthdate.Location = new Point(880, 392);
            labelBirthdate.Name = "labelBirthdate";
            labelBirthdate.Size = new Size(77, 17);
            labelBirthdate.TabIndex = 15;
            labelBirthdate.Text = "Fødselsdag";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelId.Location = new Point(880, 454);
            labelId.Name = "labelId";
            labelId.Size = new Size(20, 17);
            labelId.TabIndex = 17;
            labelId.Text = "Id";
            // 
            // textBoxEmployeeId
            // 
            textBoxEmployeeId.Location = new Point(880, 474);
            textBoxEmployeeId.Name = "textBoxEmployeeId";
            textBoxEmployeeId.Size = new Size(146, 23);
            textBoxEmployeeId.TabIndex = 16;
            // 
            // dateTimePickerEmployee
            // 
            dateTimePickerEmployee.Location = new Point(880, 417);
            dateTimePickerEmployee.Name = "dateTimePickerEmployee";
            dateTimePickerEmployee.Size = new Size(200, 23);
            dateTimePickerEmployee.TabIndex = 18;
            // 
            // buttonCloseWindow
            // 
            buttonCloseWindow.BackColor = Color.Salmon;
            buttonCloseWindow.Location = new Point(1234, 616);
            buttonCloseWindow.Name = "buttonCloseWindow";
            buttonCloseWindow.Size = new Size(145, 34);
            buttonCloseWindow.TabIndex = 19;
            buttonCloseWindow.Text = "Luk vinduet";
            buttonCloseWindow.UseVisualStyleBackColor = false;
            buttonCloseWindow.Click += buttonCloseWindow_Click;
            // 
            // btnGetEmployees
            // 
            btnGetEmployees.Location = new Point(70, 561);
            btnGetEmployees.Name = "btnGetEmployees";
            btnGetEmployees.Size = new Size(145, 34);
            btnGetEmployees.TabIndex = 20;
            btnGetEmployees.Text = "Vis medarbejdere";
            btnGetEmployees.UseVisualStyleBackColor = true;
            btnGetEmployees.Click += btnGetEmployees_Click;
            // 
            // buttonUpdateEmployee
            // 
            buttonUpdateEmployee.Location = new Point(1057, 561);
            buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            buttonUpdateEmployee.Size = new Size(145, 34);
            buttonUpdateEmployee.TabIndex = 21;
            buttonUpdateEmployee.Text = "Opdater medarbejder";
            buttonUpdateEmployee.UseVisualStyleBackColor = true;
            buttonUpdateEmployee.Click += buttonUpdateEmployee_Click;
            // 
            // buttonCreateEmployee
            // 
            buttonCreateEmployee.Location = new Point(880, 561);
            buttonCreateEmployee.Name = "buttonCreateEmployee";
            buttonCreateEmployee.Size = new Size(145, 34);
            buttonCreateEmployee.TabIndex = 22;
            buttonCreateEmployee.Text = "Tilføj medarbejder";
            buttonCreateEmployee.UseVisualStyleBackColor = true;
            buttonCreateEmployee.Click += buttonCreateEmployee_Click;
            // 
            // buttonDeleteEmployee
            // 
            buttonDeleteEmployee.Location = new Point(1234, 561);
            buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            buttonDeleteEmployee.Size = new Size(145, 34);
            buttonDeleteEmployee.TabIndex = 23;
            buttonDeleteEmployee.Text = "Slet medarbejder";
            buttonDeleteEmployee.UseVisualStyleBackColor = true;
            buttonDeleteEmployee.Click += buttonDeleteEmployee_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(880, 42);
            label1.Name = "label1";
            label1.Size = new Size(123, 17);
            label1.TabIndex = 24;
            label1.Text = "Tilføj medarbejder";
            // 
            // ShowEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1453, 718);
            Controls.Add(label1);
            Controls.Add(buttonDeleteEmployee);
            Controls.Add(buttonCreateEmployee);
            Controls.Add(buttonUpdateEmployee);
            Controls.Add(btnGetEmployees);
            Controls.Add(buttonCloseWindow);
            Controls.Add(dateTimePickerEmployee);
            Controls.Add(labelId);
            Controls.Add(textBoxEmployeeId);
            Controls.Add(labelBirthdate);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(lblMobil);
            Controls.Add(textBoxMobil);
            Controls.Add(lblAddress);
            Controls.Add(textBoxAddress);
            Controls.Add(lblLastName);
            Controls.Add(textBoxLastName);
            Controls.Add(lblFirstName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelProcessText);
            Controls.Add(Medarbejderliste);
            Controls.Add(listViewShowEmployees);
            Cursor = Cursors.Hand;
            Name = "ShowEmployees";
            Text = "Medarbejder administration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewShowEmployees;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader Phone;
        private ColumnHeader Address;
        private ColumnHeader Email;
        private ColumnHeader Id;
        private ColumnHeader Birthdate;
        private Label Medarbejderliste;
        private Label labelProcessText;
        private TextBox textBoxFirstName;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox textBoxLastName;
        private Label lblAddress;
        private TextBox textBoxAddress;
        private Label lblMobil;
        private TextBox textBoxMobil;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelBirthdate;
        private Label labelId;
        private TextBox textBoxEmployeeId;
        private DateTimePicker dateTimePickerEmployee;
        private Button buttonCloseWindow;
        private Button btnGetEmployees;
        private Button buttonUpdateEmployee;
        private Button buttonCreateEmployee;
        private Button buttonDeleteEmployee;
        private Label label1;
    }
}
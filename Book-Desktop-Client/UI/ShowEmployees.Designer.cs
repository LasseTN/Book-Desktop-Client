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
            SuspendLayout();
            // 
            // listViewShowEmployees
            // 
            listViewShowEmployees.Columns.AddRange(new ColumnHeader[] { FirstName, LastName, Address, Phone, Email, Birthdate, Id });
            listViewShowEmployees.Location = new Point(70, 80);
            listViewShowEmployees.Name = "listViewShowEmployees";
            listViewShowEmployees.Size = new Size(488, 292);
            listViewShowEmployees.TabIndex = 0;
            listViewShowEmployees.UseCompatibleStateImageBehavior = false;
            listViewShowEmployees.View = View.Details;
            listViewShowEmployees.SelectedIndexChanged += listViewShowEmployees_SelectedIndexChanged;
            // 
            // FirstName
            // 
            FirstName.Text = "Fornavn";
            // 
            // LastName
            // 
            LastName.Text = "Efternavn";
            // 
            // Address
            // 
            Address.Text = "Adresse";
            // 
            // Phone
            // 
            Phone.Text = "Mobil";
            // 
            // Email
            // 
            Email.Text = "Email";
            // 
            // Birthdate
            // 
            Birthdate.Text = "Fødselsdato";
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
            labelProcessText.Location = new Point(70, 465);
            labelProcessText.Name = "labelProcessText";
            labelProcessText.Size = new Size(16, 15);
            labelProcessText.TabIndex = 3;
            labelProcessText.Text = "...";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(668, 100);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(146, 23);
            textBoxFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.Location = new Point(668, 80);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(58, 17);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "Fornavn";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(668, 144);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(58, 17);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Fornavn";
            lblLastName.Click += lblLastName_Click;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(668, 164);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(146, 23);
            textBoxLastName.TabIndex = 6;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(668, 206);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(56, 17);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Adresse";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(668, 226);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(146, 23);
            textBoxAddress.TabIndex = 8;
            // 
            // lblMobil
            // 
            lblMobil.AutoSize = true;
            lblMobil.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMobil.Location = new Point(668, 265);
            lblMobil.Name = "lblMobil";
            lblMobil.Size = new Size(44, 17);
            lblMobil.TabIndex = 11;
            lblMobil.Text = "Mobil";
            // 
            // textBoxMobil
            // 
            textBoxMobil.Location = new Point(668, 285);
            textBoxMobil.Name = "textBoxMobil";
            textBoxMobil.Size = new Size(146, 23);
            textBoxMobil.TabIndex = 10;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(668, 323);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(42, 17);
            labelEmail.TabIndex = 13;
            labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(668, 349);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(146, 23);
            textBoxEmail.TabIndex = 12;
            // 
            // labelBirthdate
            // 
            labelBirthdate.AutoSize = true;
            labelBirthdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelBirthdate.Location = new Point(668, 389);
            labelBirthdate.Name = "labelBirthdate";
            labelBirthdate.Size = new Size(77, 17);
            labelBirthdate.TabIndex = 15;
            labelBirthdate.Text = "Fødselsdag";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelId.Location = new Point(668, 451);
            labelId.Name = "labelId";
            labelId.Size = new Size(20, 17);
            labelId.TabIndex = 17;
            labelId.Text = "Id";
            // 
            // textBoxEmployeeId
            // 
            textBoxEmployeeId.Location = new Point(668, 471);
            textBoxEmployeeId.Name = "textBoxEmployeeId";
            textBoxEmployeeId.Size = new Size(146, 23);
            textBoxEmployeeId.TabIndex = 16;
            // 
            // dateTimePickerEmployee
            // 
            dateTimePickerEmployee.Location = new Point(668, 414);
            dateTimePickerEmployee.Name = "dateTimePickerEmployee";
            dateTimePickerEmployee.Size = new Size(200, 23);
            dateTimePickerEmployee.TabIndex = 18;
            // 
            // buttonCloseWindow
            // 
            buttonCloseWindow.BackColor = Color.Salmon;
            buttonCloseWindow.Location = new Point(1030, 650);
            buttonCloseWindow.Name = "buttonCloseWindow";
            buttonCloseWindow.Size = new Size(118, 34);
            buttonCloseWindow.TabIndex = 19;
            buttonCloseWindow.Text = "Luk vinduet";
            buttonCloseWindow.UseVisualStyleBackColor = false;
            buttonCloseWindow.Click += buttonCloseWindow_Click;
            // 
            // btnGetEmployees
            // 
            btnGetEmployees.Location = new Point(68, 421);
            btnGetEmployees.Name = "btnGetEmployees";
            btnGetEmployees.Size = new Size(118, 34);
            btnGetEmployees.TabIndex = 20;
            btnGetEmployees.Text = "Vis medarbejdere";
            btnGetEmployees.UseVisualStyleBackColor = true;
            btnGetEmployees.Click += btnGetEmployees_Click;
            // 
            // ShowEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1215, 726);
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
            Name = "ShowEmployees";
            Text = "ShowEmployees";
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
    }
}
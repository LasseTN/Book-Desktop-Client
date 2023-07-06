namespace Book_Desktop_Client.UI {
    partial class ShowBooks {
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
            buttonCloseWindow = new Button();
            SuspendLayout();
            // 
            // buttonCloseWindow
            // 
            buttonCloseWindow.BackColor = Color.Salmon;
            buttonCloseWindow.Location = new Point(619, 378);
            buttonCloseWindow.Name = "buttonCloseWindow";
            buttonCloseWindow.Size = new Size(95, 23);
            buttonCloseWindow.TabIndex = 22;
            buttonCloseWindow.Text = "Luk vinduet";
            buttonCloseWindow.UseVisualStyleBackColor = false;
            buttonCloseWindow.Click += buttonCloseWindow_Click;
            // 
            // ShowBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCloseWindow);
            ForeColor = SystemColors.ControlText;
            Name = "ShowBooks";
            Text = "ShowBooks";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCloseWindow;
    }
}
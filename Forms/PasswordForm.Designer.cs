namespace Handbook_of_amaters_try.Forms
{
    partial class PasswordForm
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
            btEnter = new Button();
            tbPassword = new TextBox();
            lbEnterPassword = new Label();
            SuspendLayout();
            // 
            // btEnter
            // 
            btEnter.Location = new Point(284, 46);
            btEnter.Name = "btEnter";
            btEnter.Size = new Size(37, 29);
            btEnter.TabIndex = 0;
            btEnter.UseVisualStyleBackColor = true;
            btEnter.Click += btEnter_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(12, 46);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(245, 27);
            tbPassword.TabIndex = 1;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // lbEnterPassword
            // 
            lbEnterPassword.AutoSize = true;
            lbEnterPassword.Location = new Point(12, 9);
            lbEnterPassword.Name = "lbEnterPassword";
            lbEnterPassword.Size = new Size(110, 20);
            lbEnterPassword.TabIndex = 2;
            lbEnterPassword.Text = "Enter password";
            // 
            // PasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 85);
            Controls.Add(lbEnterPassword);
            Controls.Add(tbPassword);
            Controls.Add(btEnter);
            Name = "PasswordForm";
            Text = "Administrator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEnter;
        private TextBox tbPassword;
        private Label lbEnterPassword;
    }
}
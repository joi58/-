namespace Пользователь
{
    partial class Form1
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.Next = new System.Windows.Forms.Button();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.Link);
            this.mainPanel.Controls.Add(this.Next);
            this.mainPanel.Controls.Add(this.PasswordField);
            this.mainPanel.Controls.Add(this.LoginField);
            this.mainPanel.Controls.Add(this.Login);
            this.mainPanel.Controls.Add(this.Password);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(288, 307);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.LinkArea = new System.Windows.Forms.LinkArea(20, 30);
            this.Link.Location = new System.Drawing.Point(32, 224);
            this.Link.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(196, 17);
            this.Link.TabIndex = 7;
            this.Link.TabStop = true;
            this.Link.Text = "Не зарегистрированы? Регистрация";
            this.Link.UseCompatibleTextRendering = true;
            this.Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_LinkClicked);
            // 
            // Next
            // 
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Next.Location = new System.Drawing.Point(84, 181);
            this.Next.Margin = new System.Windows.Forms.Padding(2);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(74, 31);
            this.Next.TabIndex = 6;
            this.Next.Text = "Войти";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(117, 146);
            this.PasswordField.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(170, 20);
            this.PasswordField.TabIndex = 5;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            this.LoginField.Location = new System.Drawing.Point(117, 96);
            this.LoginField.Margin = new System.Windows.Forms.Padding(2);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(170, 20);
            this.LoginField.TabIndex = 4;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(8, 88);
            this.Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(72, 26);
            this.Login.TabIndex = 2;
            this.Login.Text = "Логин";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(8, 138);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(89, 26);
            this.Password.TabIndex = 3;
            this.Password.Text = "Пароль";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.Label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 65);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.Brown;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(268, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 20);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // Label1
            // 
            this.Label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(288, 65);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Авторизация";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 307);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.LinkLabel Link;
    }
}


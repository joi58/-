namespace Пользователь
{
    partial class Mainmenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DogovorAuto = new System.Windows.Forms.Label();
            this.DogovorPost = new System.Windows.Forms.Label();
            this.DogovorPred = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuField = new System.Windows.Forms.Label();
            this.Btnclose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 603);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(113, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(827, 553);
            this.panel5.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.DogovorAuto);
            this.panel4.Controls.Add(this.DogovorPost);
            this.panel4.Controls.Add(this.DogovorPred);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(113, 553);
            this.panel4.TabIndex = 4;
            // 
            // DogovorAuto
            // 
            this.DogovorAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DogovorAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DogovorAuto.Location = new System.Drawing.Point(-1, 92);
            this.DogovorAuto.Name = "DogovorAuto";
            this.DogovorAuto.Size = new System.Drawing.Size(115, 64);
            this.DogovorAuto.TabIndex = 1;
            this.DogovorAuto.Text = "      Договор       купли-продаж    автомобиля";
            this.DogovorAuto.Click += new System.EventHandler(this.DogovorAuto_Click);
            // 
            // DogovorPost
            // 
            this.DogovorPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DogovorPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DogovorPost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DogovorPost.Location = new System.Drawing.Point(0, 394);
            this.DogovorPost.Name = "DogovorPost";
            this.DogovorPost.Size = new System.Drawing.Size(114, 64);
            this.DogovorPost.TabIndex = 3;
            this.DogovorPost.Text = "Договор Поставщика";
            this.DogovorPost.Click += new System.EventHandler(this.DogovorPost_Click);
            // 
            // DogovorPred
            // 
            this.DogovorPred.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DogovorPred.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DogovorPred.Location = new System.Drawing.Point(0, 246);
            this.DogovorPred.Name = "DogovorPred";
            this.DogovorPred.Size = new System.Drawing.Size(113, 54);
            this.DogovorPred.TabIndex = 3;
            this.DogovorPred.Text = "Договор  аренды предприятия";
            this.DogovorPred.Click += new System.EventHandler(this.DogovorPred_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(111, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(617, 86);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.MenuField);
            this.panel2.Controls.Add(this.Btnclose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 50);
            this.panel2.TabIndex = 0;
            // 
            // MenuField
            // 
            this.MenuField.AutoSize = true;
            this.MenuField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuField.Location = new System.Drawing.Point(370, 9);
            this.MenuField.Name = "MenuField";
            this.MenuField.Size = new System.Drawing.Size(182, 29);
            this.MenuField.TabIndex = 2;
            this.MenuField.Text = "Главное меню";
            // 
            // Btnclose
            // 
            this.Btnclose.AutoSize = true;
            this.Btnclose.BackColor = System.Drawing.Color.Brown;
            this.Btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnclose.Location = new System.Drawing.Point(912, 0);
            this.Btnclose.Name = "Btnclose";
            this.Btnclose.Size = new System.Drawing.Size(28, 26);
            this.Btnclose.TabIndex = 1;
            this.Btnclose.Text = "X";
            this.Btnclose.UseVisualStyleBackColor = false;
            this.Btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 603);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainmenu";
            this.Text = "Mainmenu";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btnclose;
        private System.Windows.Forms.Label MenuField;
        private System.Windows.Forms.Label DogovorAuto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label DogovorPost;
        private System.Windows.Forms.Label DogovorPred;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}
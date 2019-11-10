namespace Login
{
    partial class RegistrForm
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
            this.button_registr = new System.Windows.Forms.Button();
            this.textBox_userpass = new System.Windows.Forms.TextBox();
            this.textBox_userlogin = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.to_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUSerName = new System.Windows.Forms.TextBox();
            this.textBoxUserSurname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxUserSurname);
            this.panel1.Controls.Add(this.textBoxUSerName);
            this.panel1.Controls.Add(this.button_registr);
            this.panel1.Controls.Add(this.textBox_userpass);
            this.panel1.Controls.Add(this.textBox_userlogin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 434);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button_registr
            // 
            this.button_registr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_registr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_registr.FlatAppearance.BorderSize = 0;
            this.button_registr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_registr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_registr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(84)))), ((int)(((byte)(185)))));
            this.button_registr.Location = new System.Drawing.Point(82, 353);
            this.button_registr.Name = "button_registr";
            this.button_registr.Size = new System.Drawing.Size(262, 33);
            this.button_registr.TabIndex = 5;
            this.button_registr.Text = "Зарегистрироваться";
            this.button_registr.UseVisualStyleBackColor = true;
            this.button_registr.Click += new System.EventHandler(this.button_registr_Click);
            // 
            // textBox_userpass
            // 
            this.textBox_userpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_userpass.Location = new System.Drawing.Point(44, 283);
            this.textBox_userpass.Name = "textBox_userpass";
            this.textBox_userpass.Size = new System.Drawing.Size(330, 47);
            this.textBox_userpass.TabIndex = 4;
            this.textBox_userpass.Enter += new System.EventHandler(this.textBox_userpass_Enter);
            this.textBox_userpass.Leave += new System.EventHandler(this.textBox_userpass_Leave);
            // 
            // textBox_userlogin
            // 
            this.textBox_userlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_userlogin.Location = new System.Drawing.Point(44, 212);
            this.textBox_userlogin.Name = "textBox_userlogin";
            this.textBox_userlogin.Size = new System.Drawing.Size(330, 47);
            this.textBox_userlogin.TabIndex = 3;
            this.textBox_userlogin.Enter += new System.EventHandler(this.textBox_userlogin_Enter);
            this.textBox_userlogin.Leave += new System.EventHandler(this.textBox_userlogin_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(84)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.to_close);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 39);
            this.panel2.TabIndex = 0;
            // 
            // to_close
            // 
            this.to_close.AutoSize = true;
            this.to_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_close.Location = new System.Drawing.Point(396, 9);
            this.to_close.Name = "to_close";
            this.to_close.Size = new System.Drawing.Size(26, 25);
            this.to_close.TabIndex = 1;
            this.to_close.Text = "X";
            this.to_close.Click += new System.EventHandler(this.to_close_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxUSerName
            // 
            this.textBoxUSerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUSerName.Location = new System.Drawing.Point(44, 78);
            this.textBoxUSerName.Name = "textBoxUSerName";
            this.textBoxUSerName.Size = new System.Drawing.Size(330, 47);
            this.textBoxUSerName.TabIndex = 6;
            this.textBoxUSerName.Enter += new System.EventHandler(this.textBoxUSerName_Enter);
            this.textBoxUSerName.Leave += new System.EventHandler(this.textBoxUSerName_Leave);
            // 
            // textBoxUserSurname
            // 
            this.textBoxUserSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserSurname.Location = new System.Drawing.Point(44, 143);
            this.textBoxUserSurname.Name = "textBoxUserSurname";
            this.textBoxUserSurname.Size = new System.Drawing.Size(330, 47);
            this.textBoxUserSurname.TabIndex = 7;
            this.textBoxUserSurname.Enter += new System.EventHandler(this.textBoxUserSurname_Enter);
            this.textBoxUserSurname.Leave += new System.EventHandler(this.textBoxUserSurname_Leave);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(84)))), ((int)(((byte)(185)))));
            this.button1.Location = new System.Drawing.Point(82, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "У меня есть аккаунт. Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 434);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrForm";
            this.Text = "RegistrForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_registr;
        private System.Windows.Forms.TextBox textBox_userpass;
        private System.Windows.Forms.TextBox textBox_userlogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label to_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserSurname;
        private System.Windows.Forms.TextBox textBoxUSerName;
        private System.Windows.Forms.Button button1;
    }
}
namespace Login
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_userpass = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.picture_pass = new System.Windows.Forms.PictureBox();
            this.picture_user = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.to_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_reg = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.button_reg);
            this.panel1.Controls.Add(this.button_login);
            this.panel1.Controls.Add(this.textBox_userpass);
            this.panel1.Controls.Add(this.textBox_username);
            this.panel1.Controls.Add(this.picture_pass);
            this.panel1.Controls.Add(this.picture_user);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 300);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button_login
            // 
            this.button_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(84)))), ((int)(((byte)(185)))));
            this.button_login.Location = new System.Drawing.Point(84, 220);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(203, 33);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "Войти";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_userpass
            // 
            this.textBox_userpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_userpass.Location = new System.Drawing.Point(83, 156);
            this.textBox_userpass.Name = "textBox_userpass";
            this.textBox_userpass.Size = new System.Drawing.Size(205, 47);
            this.textBox_userpass.TabIndex = 4;
            this.textBox_userpass.UseSystemPasswordChar = true;
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_username.Location = new System.Drawing.Point(83, 95);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(205, 47);
            this.textBox_username.TabIndex = 3;
            // 
            // picture_pass
            // 
            this.picture_pass.Image = ((System.Drawing.Image)(resources.GetObject("picture_pass.Image")));
            this.picture_pass.Location = new System.Drawing.Point(25, 156);
            this.picture_pass.Name = "picture_pass";
            this.picture_pass.Size = new System.Drawing.Size(47, 48);
            this.picture_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_pass.TabIndex = 2;
            this.picture_pass.TabStop = false;
            // 
            // picture_user
            // 
            this.picture_user.Image = ((System.Drawing.Image)(resources.GetObject("picture_user.Image")));
            this.picture_user.Location = new System.Drawing.Point(25, 93);
            this.picture_user.Name = "picture_user";
            this.picture_user.Size = new System.Drawing.Size(47, 48);
            this.picture_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_user.TabIndex = 1;
            this.picture_user.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(84)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.to_close);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 39);
            this.panel2.TabIndex = 0;
            // 
            // to_close
            // 
            this.to_close.AutoSize = true;
            this.to_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_close.Location = new System.Drawing.Point(300, 8);
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
            this.label1.Size = new System.Drawing.Size(326, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_reg
            // 
            this.button_reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reg.FlatAppearance.BorderSize = 0;
            this.button_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(84)))), ((int)(((byte)(185)))));
            this.button_reg.Location = new System.Drawing.Point(83, 264);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(203, 24);
            this.button_reg.TabIndex = 6;
            this.button_reg.Text = "У меня еще нет аккаунта";
            this.button_reg.UseVisualStyleBackColor = true;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 300);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label to_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_userpass;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.PictureBox picture_pass;
        private System.Windows.Forms.PictureBox picture_user;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_reg;
    }
}


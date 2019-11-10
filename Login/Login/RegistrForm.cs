using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class RegistrForm : Form
    {
        public RegistrForm()
        {
            InitializeComponent();

            textBoxUSerName.Text = "Введите имя";
            textBoxUSerName.ForeColor = Color.Gray;
            textBoxUserSurname.Text = "Введите фамилию";
            textBoxUserSurname.ForeColor = Color.Gray;
            textBox_userlogin.Text = "Введите логин";
            textBox_userlogin.ForeColor = Color.Gray;
            textBox_userpass.Text = "Введите пароль";
            textBox_userpass.ForeColor = Color.Gray;
        }

        private void to_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void textBoxUSerName_Enter(object sender, EventArgs e)
        {
            if (textBoxUSerName.Text == "Введите имя")
            {
                textBoxUSerName.Text = "";
                textBoxUSerName.ForeColor = Color.Black;
            }

        }

        private void textBoxUSerName_Leave(object sender, EventArgs e)
        {
            if (textBoxUSerName.Text == "")
            {
                textBoxUSerName.Text = "Введите имя";
                textBoxUSerName.ForeColor = Color.Gray;
            }

        }

        private void textBoxUserSurname_Enter(object sender, EventArgs e)
        {
            if (textBoxUserSurname.Text == "Введите фамилию")
            {
                textBoxUserSurname.Text = "";
                textBoxUserSurname.ForeColor = Color.Black;
            }
        }

        private void textBoxUserSurname_Leave(object sender, EventArgs e)
        {
            if (textBoxUserSurname.Text == "")
            {
                textBoxUserSurname.Text = "Введите фамилию";
                textBoxUserSurname.ForeColor = Color.Gray;
            }
        }

        private void textBox_userlogin_Enter(object sender, EventArgs e)
        {
            if (textBox_userlogin.Text == "Введите логин")
            {
                textBox_userlogin.Text = "";
                textBox_userlogin.ForeColor = Color.Black;
            }
        }

        private void textBox_userlogin_Leave(object sender, EventArgs e)
        {
            if (textBox_userlogin.Text == "")
            {
                textBox_userlogin.Text = "Введите логин";
                textBox_userlogin.ForeColor = Color.Gray;
            }
        }

        private void textBox_userpass_Enter(object sender, EventArgs e)
        {
            if (textBox_userpass.Text == "Введите пароль")
            {
                textBox_userpass.Text = "";
                textBox_userpass.ForeColor = Color.Black;
            }
        }

        private void textBox_userpass_Leave(object sender, EventArgs e)
        {
            if (textBox_userpass.Text == "")
            {
                textBox_userpass.Text = "Введите пароль";
                textBox_userpass.ForeColor = Color.Gray;
            }
        }

        private void button_registr_Click(object sender, EventArgs e)
        {
            if (textBoxUSerName.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя!");
                return;
            }

            if (textBoxUserSurname.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию!");
                return;
            }
            if (textBox_userlogin.Text == "Введите логин")
            {
                MessageBox.Show("Введите введите логин!");
                return;
            }

            if (textBox_userpass.Text == "Введите пвроль")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

            if (checkUser())
                return;

            DB database2 = new DB();
            MySqlCommand command2 = new MySqlCommand("INSERT INTO users VALUES (NULL, @login, @pass, @name, @surname)", database2.GetConnection());
            command2.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBox_userlogin.Text;
            command2.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox_userpass.Text;
            command2.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxUSerName.Text;
            command2.Parameters.Add("@surname", MySqlDbType.VarChar).Value = textBoxUserSurname.Text;

            database2.openConnection();
            if (command2.ExecuteNonQuery() == 1)
                MessageBox.Show("Вы успешно зарегистрировались");
            else
                MessageBox.Show("Не удалось зарегистрироваться");
            database2.closeConnection();
        }

        public Boolean checkUser()
        {
            DB database1 = new DB();
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM users WHERE login=@UL", database1.GetConnection());
            command1.Parameters.Add("@UL", MySqlDbType.VarChar).Value = textBox_userlogin.Text;
            
            adapter1.SelectCommand = command1;
            adapter1.Fill(table1);

            if (table1.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует, введите другой");
                return true;
            }


            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginform = new Form1();
            loginform.Show();
        }
    }
}

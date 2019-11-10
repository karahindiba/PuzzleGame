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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void to_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String loginUser = textBox_username.Text;
            String passUser = textBox_userpass.Text;

            DB database1 = new DB();
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM users WHERE login=@UL AND pass=@UP", database1.GetConnection());
            command1.Parameters.Add("@UL", MySqlDbType.VarChar).Value =loginUser;
            command1.Parameters.Add("@UP", MySqlDbType.VarChar).Value = passUser;
            adapter1.SelectCommand = command1;
            adapter1.Fill(table1);

            if (table1.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            

            else
                MessageBox.Show("Ошибка авторизации");
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrForm regform = new RegistrForm();
            regform.Show();
        }
    }
}

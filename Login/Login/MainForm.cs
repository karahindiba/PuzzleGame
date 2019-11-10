using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Login
{
    public partial class MainForm : Form
    {
        Point EmptyPoint;
        ArrayList images = new ArrayList();
        public MainForm()
        {
            EmptyPoint.X = 180;
            EmptyPoint.Y = 180;
            InitializeComponent();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
           

        }



        private void button_start_Click(object sender, EventArgs e)
        {
            foreach (Button b in panel3.Controls)
                b.Enabled = true;

            Image orginal = Image.FromFile(@"C:\Users\gavri.000\Documents\Visual Studio 2017\Projects\Login\Login\images\image.jpg");

            cropImageTomages(orginal, 270, 270);

            AddImagesToButtons(images);
        }

        private void AddImagesToButtons(ArrayList images)
        {
            int i = 0;
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7 };

            arr = suffle(arr);

            foreach (Button b in panel3.Controls)
            {
                if (i < arr.Length)
                {
                    b.Image = (Image)images[arr[i]];
                    i++;
                }
            }
        }

        private int[] suffle(int[] arr)
        {
            Random rand = new Random();
            arr = arr.OrderBy(x => rand.Next()).ToArray();
            return arr;
        }

        private void cropImageTomages(Image orginal, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);

            Graphics graphic = Graphics.FromImage(bmp);

            graphic.DrawImage(orginal, 0, 0, w, h);

            graphic.Dispose();

            int movr = 0, movd = 0;

            for (int x = 0; x < 8; x++)
            {
                Bitmap piece = new Bitmap(90, 90);

                for (int i = 0; i < 90; i++)
                    for (int j = 0; j < 90; j++)
                        piece.SetPixel(i, j,
                            bmp.GetPixel(i + movr, j + movd));

                images.Add(piece);

                movr += 90;

                if (movr == 270)
                {
                    movr = 0;
                    movd += 90;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void MoveButton(Button btn)
        {
            if (((btn.Location.X == EmptyPoint.X - 90 || btn.Location.X == EmptyPoint.X + 90)
                && btn.Location.Y == EmptyPoint.Y)
                || (btn.Location.Y == EmptyPoint.Y - 90 || btn.Location.Y == EmptyPoint.Y + 90)
                && btn.Location.X == EmptyPoint.X)
            {
                Point swap = btn.Location;
                btn.Location = EmptyPoint;
                EmptyPoint = swap;
            }

            if (EmptyPoint.X == 180 && EmptyPoint.Y == 180)
                CheckValid();
        }

        private void CheckValid()
        {
            int count = 0, index;
            foreach (Button btn in panel3.Controls)
            {
                index = (btn.Location.Y / 90) * 3 + btn.Location.X / 90;
                if (images[index] == btn.Image)
                    count++;
            }
            if (count == 8)
                MessageBox.Show("well done you win!");
        }
    }
}

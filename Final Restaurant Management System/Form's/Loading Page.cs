using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Restaurant_Management_System
{
    public partial class Loading_Page : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        Timer t = new Timer();
        double pbUnit;
        int pbWIDTH, pbHEIGHT, pbComplete;
        Bitmap bmp;
        Graphics g;
        public Loading_Page()
        {
            InitializeComponent();
            player.SoundLocation = @"D:\All Work's\Object Oriented Programing\Projects all\Final Restaurant Management System\Music\Kalimba.wav";
        }
        private void Loading_Page_Load(object sender, EventArgs e)
        {
            player.Play();
            pbWIDTH = picboxPB.Width;
            pbHEIGHT = picboxPB.Height;

            pbUnit = pbWIDTH / 100.0;
            pbComplete = 0;

            bmp = new Bitmap(pbWIDTH, pbHEIGHT);

            t.Interval = 50;
            t.Tick += new EventHandler(this.t_tick);
            t.Start();
        }
        private void t_tick(object sender, EventArgs e)
        {
            g = Graphics.FromImage(bmp);
            g.Clear(Color.AliceBlue);

            g.FillRectangle(Brushes.Teal, new Rectangle(0, 0, (int)(pbComplete * pbUnit), pbHEIGHT));

            g.DrawString(pbComplete + "%", new Font("Palatino Linotype", pbHEIGHT / 2), Brushes.Black, new PointF(pbWIDTH / 2 - pbHEIGHT, pbHEIGHT / 10));

            picboxPB.Image = bmp;
            pbComplete++;
            if (pbComplete > 100)
            {
                g.Dispose();
                t.Stop();
                LOGIN_FORM form2 = new LOGIN_FORM();
                this.Hide();
                player.Stop();
                form2.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}

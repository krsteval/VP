using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootTheWords
{
    public class Tank
    {
        public String Zbor { get; set; }

        public int Brzina { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public Bitmap map;
        public Bitmap explosion;

        public int State { get; set; }//0 - se dvizi niz mapata, 1 - ja pomina mapata i ne e pogodeno, -1 - pogodeno e

        public Pen pen;

        public Point tocka1;

        public Tank(int x, int y, int brzina, String zbor)
        {
            X = x;
            Y = y;

            Brzina = brzina;

            Zbor = zbor;
            map = new Bitmap(Properties.Resources.tenk2);
            explosion = new Bitmap(Properties.Resources.khbomb);

            pen = new Pen(Color.LightGreen, 5);

            tocka1 = new Point(580 / 2, 730 - 160);
        }

        public void Move()
        {
            if (State == 0)
            {
                Y += Brzina;
            }
        }

        public void Draw(Graphics g)
        {
            if (State == 0)//Ako state e 0 togas tenkot ne e pogoden
            {
                g.DrawImage(map, X, Y);
                g.DrawString(Zbor, new Font("ArialBlack", 16), new SolidBrush(Color.Black), X-Zbor.Length, Y + map.Height - 10);
            }
        }

        public void Hit(Graphics g)
        {
            g.DrawLine(pen, new Point(X+map.Width/2, Y+map.Height/2), tocka1);
        }
    }
}

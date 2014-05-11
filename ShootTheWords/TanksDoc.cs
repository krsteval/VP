using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootTheWords
{
    public class TanksDoc
    {
        public List<Tank> Tanks { get; set; }

        public int Hits { get; set; }
        public int Missed { get; set; }

        public TanksDoc()
        {
            Tanks = new List<Tank>();
        }

        public void addTank(int x, int y, int brzina, String zbor)
        {
            Tank t = new Tank(x, y, brzina, zbor);
            Tanks.Add(t);
        }

        public void Move(int height)
        {
            foreach (Tank t in Tanks)
            {
                t.Move();
                if (t.Y > (height - 150))
                {
                    t.State = 1;//Ako tenkot pominal state = 1
                }

                if (t.State == -1)
                {
                    Hits += t.Zbor.Length;
                }
            }

            for (int i = Tanks.Count - 1; i >= 0; --i)
            {
                if (Tanks[i].State == 1)//Ako tenkot pominal
                {
                    Tanks.RemoveAt(i);
                    Missed++;
                }

                if (Tanks[i].State == -1)
                {
                    Tanks.RemoveAt(i);
                }
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Tank t in Tanks)
            {
                t.Draw(g);
            }
        }
    }
}

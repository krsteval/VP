using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootTheWords
{
    public partial class Form2 : Form
    {
        private TanksDoc tanksDoc;
        private int generateTank;

        Bitmap background;
        Bitmap turret;
        Bitmap boomImg;

        Random r;
        bool pause;

        int Rate = 20;

        Form1 form1;

        SoundPlayer song;
        SoundPlayer bum;

        bool sounds;

        int brZbor = 0;

        List<string> words;

        OleDbConnection db;
        OleDbCommand getWords;
        OleDbDataReader wordsReader;

        public Form2(int rate, Form1 f)
        {
            InitializeComponent();

            tanksDoc = new TanksDoc();

            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;

            background = new Bitmap(Properties.Resources.dirt_texture_small2);
            turret = new Bitmap(Properties.Resources.tower);
            boomImg = new Bitmap(Properties.Resources.khbomb);

            r = new Random();
            pause = false;

            Rate = rate;

            form1 = f;

            sounds = true;

            btnSound.Image = Properties.Resources.sound;

            song = new SoundPlayer("Laser Shot.wav");
            bum = new SoundPlayer("boom.wav");

            words = new List<string>();

            db = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shot_the_words_DB.accdb");

            db.Open();
            getWords = new OleDbCommand();
            getWords.Connection = db;

            if (rate == 40)
            {
                getWords.CommandText = "SELECT * FROM Words WHERE LEN(zbor)<5";
                
            }
            else if (rate == 30)
            {
                getWords.CommandText = "SELECT * FROM Words WHERE LEN(zbor)<7";
            }
            else
            {
                getWords.CommandText = "SELECT * FROM Words WHERE LEN(zbor)<10";
            }
            wordsReader = getWords.ExecuteReader();

            while (wordsReader.Read())
            {
                words.Add(wordsReader[1].ToString());
            }
            
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawImage(background, 0, 0);

            tanksDoc.Draw(e.Graphics);

            lblLives.Text = string.Format("{0}", (3 - tanksDoc.Missed));
            if (lblLives.Text.Equals("0"))
            {
                //GAME OVER
                timerGame.Stop();
                e.Graphics.DrawString("Game Over", new Font("Arial", 40), new SolidBrush(Color.Blue), new Point(Width / 2 / 2, Width / 2));
                txtWord.Enabled = false;

                Form3 gameOverForm = new Form3(lblPoints.Text, form1, this);
                this.Hide();
                gameOverForm.Show();
            }
            if (Rate == 30)
            {
                lblPoints.Text = string.Format("{0}", tanksDoc.Hits * 1.5);//Medium
            }
            else if (Rate == 20)
            {
                lblPoints.Text = string.Format("{0}", tanksDoc.Hits * 2);//Hard
            }
            else
            {
                lblPoints.Text = string.Format("{0}", tanksDoc.Hits);//Easy
            }

            e.Graphics.DrawImage(turret, new Point((Width / 2) - (turret.Width / 2), Height - turret.Height - panel1.Height - 40));

            if (pause)
            {
                e.Graphics.DrawString("Pause", new Font("Arial", 40), new SolidBrush(Color.Blue), new Point(Width / 3, Width / 2));
                e.Graphics.DrawString("(click to resume)", new Font("Arial", 12), new SolidBrush(Color.Blue), new Point(Width / 3 + 20, Width / 2 + 60));
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            Invalidate();
            tanksDoc.Move(Height);

            foreach (Tank t in tanksDoc.Tanks)
            {
                if ((t.X >= (Width / 2) - (turret.Width / 2) - 32) && (t.X <= (Width / 2) + (turret.Width / 2) - 10) && (t.Y >= (Height - turret.Height - panel1.Height - 80)))
                {
                    boom(boomImg, t.X, t.Y);
                    Thread.Sleep(50);
                    t.State = 1;
                    if (sounds)
                    {
                        bum.Play();
                    }
                }
            }

            if (generateTank % Rate == 0)
            {
                int x = r.Next(30, Width - 100);
                int y = 0;
                brZbor = r.Next(1, words.Count);
                tanksDoc.addTank(x, y, 5, words.ElementAt(brZbor));
            }
            ++generateTank;
        }

        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            if (txtWord.Text.Equals(" "))
            {
                pause = true;
                txtWord.Enabled = false;
                Invalidate();
                timerGame.Stop();
            }

            foreach (Tank t in tanksDoc.Tanks)
            {
                if (txtWord.Text.Equals(t.Zbor))
                {
                    Graphics g = CreateGraphics();
                    txtWord.Text = "";

                    t.Hit(g);
                    boom(boomImg, t.X, t.Y);

                    Thread.Sleep(50);
                    t.State = -1;
                }
            }
        }

        public void boom(Bitmap boom, int X, int Y)
        {
            Graphics g = CreateGraphics();
            g.DrawImage(boom, X, Y);
            if (sounds)
            {
                song.Play();
            }
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            pause = false;
            timerGame.Start();
            txtWord.Enabled = true;
            txtWord.Focus();
            txtWord.Text = "";
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            db.Close();
            form1.Show();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            if (sounds)
            {
                sounds = false;
                btnSound.ForeColor = Color.Red;
                txtWord.Focus();
                btnSound.Image = Properties.Resources.nosound;
            }
            else
            {
                sounds = true;
                btnSound.ForeColor = Color.Black;
                txtWord.Focus();
                btnSound.Image = Properties.Resources.sound;
            }
        }
    }
}

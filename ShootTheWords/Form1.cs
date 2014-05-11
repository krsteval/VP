using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootTheWords
{
    public partial class Form1 : Form
    {
        private TanksDoc tanksDoc;
        private int generateTank;
        Bitmap background;

        Random r;

        public Form1()
        {
            InitializeComponent();

            listBox.Visible = false;

            tanksDoc = new TanksDoc();

            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;

            background = new Bitmap(Properties.Resources.dirt_texture_small2);

            r = new Random();
        }

        private void btnHighscore_Click(object sender, EventArgs e)
        {
            txtBoxDescription.Visible = false;
            listBox.Visible = true;

            OleDbConnection db = new OleDbConnection();
            db.ConnectionString = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shot_the_words_DB.accdb");
            db.Open();

            OleDbCommand getHighScore = new OleDbCommand();
            getHighScore.Connection = db;
            getHighScore.CommandText = "SELECT ime, poeni FROM high_scores ORDER BY poeni DESC";

            OleDbDataReader highScoresReader = getHighScore.ExecuteReader();

            listBox.Items.Clear();

            while(highScoresReader.Read())
            {
                string name = highScoresReader[0].ToString();
                string points = highScoresReader[1].ToString();

                listBox.Items.Add((listBox.Items.Count+1) +"\t" + name + " \t " + points);
            }
        }

        private void btnDescription_Click(object sender, EventArgs e)
        {
            txtBoxDescription.Visible = true;
            listBox.Visible = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawImage(background, 0, 0);

            tanksDoc.Draw(e.Graphics);
        }

        private void timerGameMenu_Tick(object sender, EventArgs e)
        {
            Invalidate();
            tanksDoc.Move(Height);

            if (generateTank % 30 == 0)
            {

                int x = r.Next(30, Width - 100);
                int y = 0;
                tanksDoc.addTank(x, y, 5, "");
            }
            ++generateTank;
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Form2 easyGame = new Form2(40, this);
            this.Hide();
            easyGame.Show();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            Form2 mediumGame = new Form2(30, this);
            this.Hide();
            mediumGame.Show();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Form2 hardGame = new Form2(20, this);
            this.Hide();
            hardGame.Show();
        }
    }
}

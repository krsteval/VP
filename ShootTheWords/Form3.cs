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
    public partial class Form3 : Form
    {
        private TanksDoc tanksDoc;
        private int generateTank;
        Bitmap background;

        Random r;

        Form1 form1;
        Form2 form2;

        OleDbConnection db;

        public Form3(string points, Form1 f1, Form2 f2)
        {
            InitializeComponent();

            tanksDoc = new TanksDoc();

            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;

            background = new Bitmap(Properties.Resources.dirt_texture_small2);

            r = new Random();

            lblPoints.Text = points;

            form1 = f1;
            form2 = f2;

            db = new OleDbConnection();
            db.ConnectionString = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shot_the_words_DB.accdb");
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawImage(background, 0, 0);

            tanksDoc.Draw(e.Graphics);
        }

        private void timerGameOver_Tick(object sender, EventArgs e)
        {
            Invalidate();
            tanksDoc.Move(Height);

            if (generateTank % 30 == 0)
            {
                //Random r = new Random();
                int x = r.Next(30, Width - 100);
                int y = 0;
                int i = r.Next(0, 10);
                tanksDoc.addTank(x, y, 5, "");
            }
            ++generateTank;
        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            form2.Close();
        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            db.Open();

            OleDbCommand putScores = new OleDbCommand();
            putScores.Connection = db;
            putScores.CommandText = "INSERT INTO high_scores (ime, poeni) VALUES ('" + txtName.Text + "', '" + lblPoints.Text + "')";
            putScores.ExecuteNonQuery();
            db.Close();

            MessageBox.Show("The score is saved");

            txtName.Enabled = false;
            btnSaveScore.Enabled = false;
        }
    }
}

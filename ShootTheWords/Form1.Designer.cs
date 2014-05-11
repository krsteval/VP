namespace ShootTheWords
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBoxDescription = new System.Windows.Forms.RichTextBox();
            this.btnHighscore = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.lblImeIgra = new System.Windows.Forms.Label();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnDescription = new System.Windows.Forms.Button();
            this.shot_the_words_DBDataSet = new ShootTheWords.Shot_the_words_DBDataSet();
            this.timerGameMenu = new System.Windows.Forms.Timer(this.components);
            this.high_scoresTableAdapter = new ShootTheWords.Shot_the_words_DBDataSetTableAdapters.high_scoresTableAdapter();
            this.listBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.shot_the_words_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Enabled = false;
            this.txtBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescription.Location = new System.Drawing.Point(50, 316);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(465, 173);
            this.txtBoxDescription.TabIndex = 5;
            this.txtBoxDescription.Text = resources.GetString("txtBoxDescription.Text");
            // 
            // btnHighscore
            // 
            this.btnHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighscore.Location = new System.Drawing.Point(340, 125);
            this.btnHighscore.Name = "btnHighscore";
            this.btnHighscore.Size = new System.Drawing.Size(175, 30);
            this.btnHighscore.TabIndex = 10;
            this.btnHighscore.Text = "View highscore";
            this.btnHighscore.UseVisualStyleBackColor = true;
            this.btnHighscore.Click += new System.EventHandler(this.btnHighscore_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.Transparent;
            this.btnEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.Location = new System.Drawing.Point(90, 125);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(175, 30);
            this.btnEasy.TabIndex = 7;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnHard
            // 
            this.btnHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(90, 235);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(175, 30);
            this.btnHard.TabIndex = 9;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // lblImeIgra
            // 
            this.lblImeIgra.AutoSize = true;
            this.lblImeIgra.BackColor = System.Drawing.Color.Transparent;
            this.lblImeIgra.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeIgra.Location = new System.Drawing.Point(140, 41);
            this.lblImeIgra.Name = "lblImeIgra";
            this.lblImeIgra.Size = new System.Drawing.Size(311, 42);
            this.lblImeIgra.TabIndex = 6;
            this.lblImeIgra.Text = "Shoot the Words";
            // 
            // btnMedium
            // 
            this.btnMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.Location = new System.Drawing.Point(90, 179);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(175, 30);
            this.btnMedium.TabIndex = 8;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnDescription
            // 
            this.btnDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescription.Location = new System.Drawing.Point(340, 179);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Size = new System.Drawing.Size(175, 30);
            this.btnDescription.TabIndex = 11;
            this.btnDescription.Text = "Game description";
            this.btnDescription.UseVisualStyleBackColor = true;
            this.btnDescription.Click += new System.EventHandler(this.btnDescription_Click);
            // 
            // shot_the_words_DBDataSet
            // 
            this.shot_the_words_DBDataSet.DataSetName = "Shot_the_words_DBDataSet";
            this.shot_the_words_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timerGameMenu
            // 
            this.timerGameMenu.Enabled = true;
            this.timerGameMenu.Interval = 41;
            this.timerGameMenu.Tick += new System.EventHandler(this.timerGameMenu_Tick);
            // 
            // high_scoresTableAdapter
            // 
            this.high_scoresTableAdapter.ClearBeforeFill = true;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(50, 316);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(465, 164);
            this.listBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 537);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnDescription);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.btnHighscore);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.lblImeIgra);
            this.Controls.Add(this.btnMedium);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Shoot The Words - Menu";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.shot_the_words_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxDescription;
        private System.Windows.Forms.Button btnHighscore;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Label lblImeIgra;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnDescription;
        private System.Windows.Forms.Timer timerGameMenu;
        private Shot_the_words_DBDataSet shot_the_words_DBDataSet;
        private Shot_the_words_DBDataSetTableAdapters.high_scoresTableAdapter high_scoresTableAdapter;
        private System.Windows.Forms.ListBox listBox;
    }
}


namespace ShootTheWords
{
    partial class Form2
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
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPoints = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnSound = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 41;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSound);
            this.panel1.Controls.Add(this.lblPoints);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblLives);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtWord);
            this.panel1.Location = new System.Drawing.Point(-6, 638);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 62);
            this.panel1.TabIndex = 4;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(449, 15);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(24, 25);
            this.lblPoints.TabIndex = 4;
            this.lblPoints.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Points:";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.Location = new System.Drawing.Point(300, 15);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(24, 25);
            this.lblLives.TabIndex = 2;
            this.lblLives.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "❤";
            // 
            // txtWord
            // 
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(12, 12);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(190, 31);
            this.txtWord.TabIndex = 0;
            this.txtWord.TextChanged += new System.EventHandler(this.txtWord_TextChanged);
            // 
            // btnSound
            // 
            this.btnSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSound.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSound.Location = new System.Drawing.Point(215, 12);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(39, 31);
            this.btnSound.TabIndex = 4;
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 692);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(580, 38);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Shoot the Words - Play";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWord;
    }
}
namespace ShootTheWords
{
    partial class Form3
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
            this.btnTryAgain = new System.Windows.Forms.Button();
            this.btnSaveScore = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblImeIgra = new System.Windows.Forms.Label();
            this.timerGameOver = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTryAgain.Location = new System.Drawing.Point(123, 303);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(191, 41);
            this.btnTryAgain.TabIndex = 13;
            this.btnTryAgain.Text = "Try again";
            this.btnTryAgain.UseVisualStyleBackColor = true;
            this.btnTryAgain.Click += new System.EventHandler(this.btnTryAgain_Click);
            // 
            // btnSaveScore
            // 
            this.btnSaveScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveScore.Location = new System.Drawing.Point(123, 231);
            this.btnSaveScore.Name = "btnSaveScore";
            this.btnSaveScore.Size = new System.Drawing.Size(191, 41);
            this.btnSaveScore.TabIndex = 12;
            this.btnSaveScore.Text = "Save score";
            this.btnSaveScore.UseVisualStyleBackColor = true;
            this.btnSaveScore.Click += new System.EventHandler(this.btnSaveScore_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(199, 179);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(24, 25);
            this.lblPoints.TabIndex = 11;
            this.lblPoints.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Score:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(123, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 31);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "Enter name";
            // 
            // lblImeIgra
            // 
            this.lblImeIgra.AutoSize = true;
            this.lblImeIgra.BackColor = System.Drawing.Color.Transparent;
            this.lblImeIgra.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeIgra.Location = new System.Drawing.Point(116, 34);
            this.lblImeIgra.Name = "lblImeIgra";
            this.lblImeIgra.Size = new System.Drawing.Size(219, 42);
            this.lblImeIgra.TabIndex = 8;
            this.lblImeIgra.Text = "Game Over";
            // 
            // timerGameOver
            // 
            this.timerGameOver.Enabled = true;
            this.timerGameOver.Interval = 41;
            this.timerGameOver.Tick += new System.EventHandler(this.timerGameOver_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 380);
            this.Controls.Add(this.btnTryAgain);
            this.Controls.Add(this.btnSaveScore);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblImeIgra);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Text = "Shoot the Words - Game Over";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTryAgain;
        private System.Windows.Forms.Button btnSaveScore;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblImeIgra;
        private System.Windows.Forms.Timer timerGameOver;
    }
}
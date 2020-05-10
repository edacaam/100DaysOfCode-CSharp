namespace QuizApplication
{
    partial class FrmQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuiz));
            this.PicExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnAgain = new System.Windows.Forms.Button();
            this.rchTxtBoxQuestions = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicExit
            // 
            this.PicExit.Image = ((System.Drawing.Image)(resources.GetObject("PicExit.Image")));
            this.PicExit.Location = new System.Drawing.Point(766, 2);
            this.PicExit.Name = "PicExit";
            this.PicExit.Size = new System.Drawing.Size(31, 29);
            this.PicExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicExit.TabIndex = 13;
            this.PicExit.TabStop = false;
            this.PicExit.Click += new System.EventHandler(this.PicExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.rchTxtBoxQuestions);
            this.panel1.Controls.Add(this.BtnNext);
            this.panel1.Controls.Add(this.BtnD);
            this.panel1.Controls.Add(this.BtnC);
            this.panel1.Controls.Add(this.BtnB);
            this.panel1.Controls.Add(this.BtnA);
            this.panel1.Location = new System.Drawing.Point(66, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 376);
            this.panel1.TabIndex = 14;
            // 
            // BtnNext
            // 
            this.BtnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNext.BackgroundImage")));
            this.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Location = new System.Drawing.Point(613, 253);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(40, 40);
            this.BtnNext.TabIndex = 5;
            this.BtnNext.UseVisualStyleBackColor = true;
            // 
            // BtnD
            // 
            this.BtnD.Location = new System.Drawing.Point(334, 287);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(264, 46);
            this.BtnD.TabIndex = 4;
            this.BtnD.UseVisualStyleBackColor = true;
            // 
            // BtnC
            // 
            this.BtnC.Location = new System.Drawing.Point(52, 287);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(264, 46);
            this.BtnC.TabIndex = 3;
            this.BtnC.UseVisualStyleBackColor = true;
            // 
            // BtnB
            // 
            this.BtnB.Location = new System.Drawing.Point(334, 210);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(264, 48);
            this.BtnB.TabIndex = 2;
            this.BtnB.UseVisualStyleBackColor = true;
            // 
            // BtnA
            // 
            this.BtnA.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnA.Location = new System.Drawing.Point(52, 210);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(264, 48);
            this.BtnA.TabIndex = 1;
            this.BtnA.UseVisualStyleBackColor = false;
            // 
            // BtnAgain
            // 
            this.BtnAgain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAgain.BackgroundImage")));
            this.BtnAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgain.Location = new System.Drawing.Point(12, 12);
            this.BtnAgain.Name = "BtnAgain";
            this.BtnAgain.Size = new System.Drawing.Size(40, 40);
            this.BtnAgain.TabIndex = 6;
            this.BtnAgain.UseVisualStyleBackColor = true;
            this.BtnAgain.Click += new System.EventHandler(this.BtnAgain_Click);
            // 
            // rchTxtBoxQuestions
            // 
            this.rchTxtBoxQuestions.Location = new System.Drawing.Point(52, 39);
            this.rchTxtBoxQuestions.Name = "rchTxtBoxQuestions";
            this.rchTxtBoxQuestions.Size = new System.Drawing.Size(546, 155);
            this.rchTxtBoxQuestions.TabIndex = 6;
            this.rchTxtBoxQuestions.Text = "";
            // 
            // FrmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.BtnAgain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PicExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuiz";
            this.Load += new System.EventHandler(this.FrmQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnAgain;
        private System.Windows.Forms.RichTextBox rchTxtBoxQuestions;
    }
}
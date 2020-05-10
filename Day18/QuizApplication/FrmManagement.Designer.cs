namespace QuizApplication
{
    partial class FrmManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PicExit = new System.Windows.Forms.PictureBox();
            this.PicBack = new System.Windows.Forms.PictureBox();
            this.rchTxtBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.txtCanswer = new System.Windows.Forms.TextBox();
            this.txtWanswer1 = new System.Windows.Forms.TextBox();
            this.txtWanswer2 = new System.Windows.Forms.TextBox();
            this.txtWanswer3 = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblCanswer = new System.Windows.Forms.Label();
            this.lblWanswer1 = new System.Windows.Forms.Label();
            this.lblWanswer2 = new System.Windows.Forms.Label();
            this.lblWanswer3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PicExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // PicExit
            // 
            this.PicExit.Image = ((System.Drawing.Image)(resources.GetObject("PicExit.Image")));
            this.PicExit.Location = new System.Drawing.Point(855, 1);
            this.PicExit.Margin = new System.Windows.Forms.Padding(7);
            this.PicExit.Name = "PicExit";
            this.PicExit.Size = new System.Drawing.Size(40, 39);
            this.PicExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicExit.TabIndex = 14;
            this.PicExit.TabStop = false;
            this.PicExit.Click += new System.EventHandler(this.PicExit_Click);
            // 
            // PicBack
            // 
            this.PicBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBack.Image = ((System.Drawing.Image)(resources.GetObject("PicBack.Image")));
            this.PicBack.Location = new System.Drawing.Point(3, 1);
            this.PicBack.Name = "PicBack";
            this.PicBack.Size = new System.Drawing.Size(53, 53);
            this.PicBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBack.TabIndex = 15;
            this.PicBack.TabStop = false;
            this.PicBack.Click += new System.EventHandler(this.PicBack_Click);
            // 
            // rchTxtBoxQuestion
            // 
            this.rchTxtBoxQuestion.Location = new System.Drawing.Point(212, 79);
            this.rchTxtBoxQuestion.Name = "rchTxtBoxQuestion";
            this.rchTxtBoxQuestion.Size = new System.Drawing.Size(272, 120);
            this.rchTxtBoxQuestion.TabIndex = 16;
            this.rchTxtBoxQuestion.Text = "";
            this.rchTxtBoxQuestion.TextChanged += new System.EventHandler(this.rchTxtBoxQuestion_TextChanged);
            // 
            // txtCanswer
            // 
            this.txtCanswer.BackColor = System.Drawing.Color.PaleGreen;
            this.txtCanswer.Location = new System.Drawing.Point(212, 223);
            this.txtCanswer.Name = "txtCanswer";
            this.txtCanswer.Size = new System.Drawing.Size(272, 35);
            this.txtCanswer.TabIndex = 17;
            this.txtCanswer.TextChanged += new System.EventHandler(this.txtCanswer_TextChanged);
            // 
            // txtWanswer1
            // 
            this.txtWanswer1.BackColor = System.Drawing.Color.IndianRed;
            this.txtWanswer1.Location = new System.Drawing.Point(212, 279);
            this.txtWanswer1.Name = "txtWanswer1";
            this.txtWanswer1.Size = new System.Drawing.Size(272, 35);
            this.txtWanswer1.TabIndex = 18;
            this.txtWanswer1.TextChanged += new System.EventHandler(this.txtWanswer1_TextChanged);
            // 
            // txtWanswer2
            // 
            this.txtWanswer2.BackColor = System.Drawing.Color.IndianRed;
            this.txtWanswer2.Location = new System.Drawing.Point(212, 335);
            this.txtWanswer2.Name = "txtWanswer2";
            this.txtWanswer2.Size = new System.Drawing.Size(272, 35);
            this.txtWanswer2.TabIndex = 19;
            this.txtWanswer2.TextChanged += new System.EventHandler(this.txtWanswer2_TextChanged);
            // 
            // txtWanswer3
            // 
            this.txtWanswer3.BackColor = System.Drawing.Color.IndianRed;
            this.txtWanswer3.Location = new System.Drawing.Point(212, 398);
            this.txtWanswer3.Name = "txtWanswer3";
            this.txtWanswer3.Size = new System.Drawing.Size(272, 35);
            this.txtWanswer3.TabIndex = 20;
            this.txtWanswer3.TextChanged += new System.EventHandler(this.txtWanswer3_TextChanged);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(90, 79);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(116, 29);
            this.lblQuestion.TabIndex = 21;
            this.lblQuestion.Text = "Question:";
            // 
            // lblCanswer
            // 
            this.lblCanswer.AutoSize = true;
            this.lblCanswer.Location = new System.Drawing.Point(19, 220);
            this.lblCanswer.Name = "lblCanswer";
            this.lblCanswer.Size = new System.Drawing.Size(184, 29);
            this.lblCanswer.TabIndex = 22;
            this.lblCanswer.Text = "Correct Answer:";
            // 
            // lblWanswer1
            // 
            this.lblWanswer1.AutoSize = true;
            this.lblWanswer1.Location = new System.Drawing.Point(27, 282);
            this.lblWanswer1.Name = "lblWanswer1";
            this.lblWanswer1.Size = new System.Drawing.Size(176, 29);
            this.lblWanswer1.TabIndex = 23;
            this.lblWanswer1.Text = "Wrong Answer:";
            // 
            // lblWanswer2
            // 
            this.lblWanswer2.AutoSize = true;
            this.lblWanswer2.Location = new System.Drawing.Point(30, 335);
            this.lblWanswer2.Name = "lblWanswer2";
            this.lblWanswer2.Size = new System.Drawing.Size(176, 29);
            this.lblWanswer2.TabIndex = 24;
            this.lblWanswer2.Text = "Wrong Answer:";
            // 
            // lblWanswer3
            // 
            this.lblWanswer3.AutoSize = true;
            this.lblWanswer3.Location = new System.Drawing.Point(27, 383);
            this.lblWanswer3.Name = "lblWanswer3";
            this.lblWanswer3.Size = new System.Drawing.Size(176, 29);
            this.lblWanswer3.TabIndex = 25;
            this.lblWanswer3.Text = "Wrong Answer:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 445);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 90;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(883, 249);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAddQuestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddQuestion.BackgroundImage")));
            this.btnAddQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Location = new System.Drawing.Point(539, 125);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(83, 86);
            this.btnAddQuestion.TabIndex = 27;
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.PowderBlue;
            this.btDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDelete.BackgroundImage")));
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Location = new System.Drawing.Point(772, 125);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(83, 86);
            this.btDelete.TabIndex = 28;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(661, 125);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 86);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Update";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(771, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Delete";
            // 
            // cmbBoxType
            // 
            this.cmbBoxType.FormattingEnabled = true;
            this.cmbBoxType.Items.AddRange(new object[] {
            "History",
            "Science",
            "Entertainment",
            "Art",
            "Geography",
            "Sports"});
            this.cmbBoxType.Location = new System.Drawing.Point(212, 36);
            this.cmbBoxType.Name = "cmbBoxType";
            this.cmbBoxType.Size = new System.Drawing.Size(272, 37);
            this.cmbBoxType.TabIndex = 33;
            this.cmbBoxType.SelectedIndexChanged += new System.EventHandler(this.cmbBoxType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(129, 36);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(74, 29);
            this.lblType.TabIndex = 34;
            this.lblType.Text = "Type:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 700);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Navy;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.Size = new System.Drawing.Size(346, 254);
            this.dataGridView2.TabIndex = 35;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(364, 700);
            this.dataGridView3.Name = "dataGridView3";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Navy;
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView3.Size = new System.Drawing.Size(531, 254);
            this.dataGridView3.TabIndex = 39;
            // 
            // FrmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(907, 966);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbBoxType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblWanswer3);
            this.Controls.Add(this.lblWanswer2);
            this.Controls.Add(this.lblWanswer1);
            this.Controls.Add(this.lblCanswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtWanswer3);
            this.Controls.Add(this.txtWanswer2);
            this.Controls.Add(this.txtWanswer1);
            this.Controls.Add(this.txtCanswer);
            this.Controls.Add(this.rchTxtBoxQuestion);
            this.Controls.Add(this.PicBack);
            this.Controls.Add(this.PicExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FrmManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicExit;
        private System.Windows.Forms.PictureBox PicBack;
        private System.Windows.Forms.RichTextBox rchTxtBoxQuestion;
        private System.Windows.Forms.TextBox txtCanswer;
        private System.Windows.Forms.TextBox txtWanswer1;
        private System.Windows.Forms.TextBox txtWanswer2;
        private System.Windows.Forms.TextBox txtWanswer3;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblCanswer;
        private System.Windows.Forms.Label lblWanswer1;
        private System.Windows.Forms.Label lblWanswer2;
        private System.Windows.Forms.Label lblWanswer3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBoxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}
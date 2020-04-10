namespace Listter
{
    partial class FrmMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovies));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.PicSearch = new System.Windows.Forms.PictureBox();
            this.PicBack = new System.Windows.Forms.PictureBox();
            this.PicExit = new System.Windows.Forms.PictureBox();
            this.PicList = new System.Windows.Forms.PictureBox();
            this.PicDelete = new System.Windows.Forms.PictureBox();
            this.PicAdd = new System.Windows.Forms.PictureBox();
            this.PicUpdate = new System.Windows.Forms.PictureBox();
            this.LblList = new System.Windows.Forms.Label();
            this.LblAdd = new System.Windows.Forms.Label();
            this.LblUpdate = new System.Windows.Forms.Label();
            this.LblDelete = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtDirector = new System.Windows.Forms.TextBox();
            this.CmbYear = new System.Windows.Forms.ComboBox();
            this.CmbLanguage = new System.Windows.Forms.ComboBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblYear = new System.Windows.Forms.Label();
            this.LblDirector = new System.Windows.Forms.Label();
            this.LblLanguage = new System.Windows.Forms.Label();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.LblType = new System.Windows.Forms.Label();
            this.LblStar = new System.Windows.Forms.Label();
            this.TxtStars = new System.Windows.Forms.TextBox();
            this.LblTime = new System.Windows.Forms.Label();
            this.MtxtTime = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 340);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1156, 505);
            this.dataGridView1.TabIndex = 0;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSearch.Location = new System.Drawing.Point(923, 261);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(193, 31);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged_1);
            // 
            // PicSearch
            // 
            this.PicSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicSearch.Image = ((System.Drawing.Image)(resources.GetObject("PicSearch.Image")));
            this.PicSearch.Location = new System.Drawing.Point(1127, 261);
            this.PicSearch.Name = "PicSearch";
            this.PicSearch.Size = new System.Drawing.Size(38, 33);
            this.PicSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSearch.TabIndex = 2;
            this.PicSearch.TabStop = false;
            // 
            // PicBack
            // 
            this.PicBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBack.Image = ((System.Drawing.Image)(resources.GetObject("PicBack.Image")));
            this.PicBack.Location = new System.Drawing.Point(-2, 0);
            this.PicBack.Name = "PicBack";
            this.PicBack.Size = new System.Drawing.Size(55, 53);
            this.PicBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBack.TabIndex = 3;
            this.PicBack.TabStop = false;
            this.PicBack.Click += new System.EventHandler(this.PicBack_Click);
            // 
            // PicExit
            // 
            this.PicExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicExit.Image = ((System.Drawing.Image)(resources.GetObject("PicExit.Image")));
            this.PicExit.Location = new System.Drawing.Point(1148, 12);
            this.PicExit.Name = "PicExit";
            this.PicExit.Size = new System.Drawing.Size(40, 33);
            this.PicExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicExit.TabIndex = 4;
            this.PicExit.TabStop = false;
            this.PicExit.Click += new System.EventHandler(this.PicExit_Click);
            // 
            // PicList
            // 
            this.PicList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicList.Image = ((System.Drawing.Image)(resources.GetObject("PicList.Image")));
            this.PicList.Location = new System.Drawing.Point(426, 117);
            this.PicList.Name = "PicList";
            this.PicList.Size = new System.Drawing.Size(89, 65);
            this.PicList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicList.TabIndex = 5;
            this.PicList.TabStop = false;
            this.PicList.Click += new System.EventHandler(this.PicList_Click);
            // 
            // PicDelete
            // 
            this.PicDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicDelete.Image = ((System.Drawing.Image)(resources.GetObject("PicDelete.Image")));
            this.PicDelete.Location = new System.Drawing.Point(715, 116);
            this.PicDelete.Name = "PicDelete";
            this.PicDelete.Size = new System.Drawing.Size(83, 65);
            this.PicDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicDelete.TabIndex = 6;
            this.PicDelete.TabStop = false;
            // 
            // PicAdd
            // 
            this.PicAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicAdd.Image = ((System.Drawing.Image)(resources.GetObject("PicAdd.Image")));
            this.PicAdd.Location = new System.Drawing.Point(521, 116);
            this.PicAdd.Name = "PicAdd";
            this.PicAdd.Size = new System.Drawing.Size(88, 65);
            this.PicAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicAdd.TabIndex = 7;
            this.PicAdd.TabStop = false;
            this.PicAdd.Click += new System.EventHandler(this.PicAdd_Click);
            // 
            // PicUpdate
            // 
            this.PicUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicUpdate.Image = ((System.Drawing.Image)(resources.GetObject("PicUpdate.Image")));
            this.PicUpdate.Location = new System.Drawing.Point(615, 117);
            this.PicUpdate.Name = "PicUpdate";
            this.PicUpdate.Size = new System.Drawing.Size(94, 65);
            this.PicUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUpdate.TabIndex = 8;
            this.PicUpdate.TabStop = false;
            // 
            // LblList
            // 
            this.LblList.AutoSize = true;
            this.LblList.Location = new System.Drawing.Point(450, 185);
            this.LblList.Name = "LblList";
            this.LblList.Size = new System.Drawing.Size(34, 20);
            this.LblList.TabIndex = 9;
            this.LblList.Text = "List";
            // 
            // LblAdd
            // 
            this.LblAdd.AutoSize = true;
            this.LblAdd.Location = new System.Drawing.Point(544, 184);
            this.LblAdd.Name = "LblAdd";
            this.LblAdd.Size = new System.Drawing.Size(38, 20);
            this.LblAdd.TabIndex = 10;
            this.LblAdd.Text = "Add";
            // 
            // LblUpdate
            // 
            this.LblUpdate.AutoSize = true;
            this.LblUpdate.Location = new System.Drawing.Point(621, 184);
            this.LblUpdate.Name = "LblUpdate";
            this.LblUpdate.Size = new System.Drawing.Size(62, 20);
            this.LblUpdate.TabIndex = 11;
            this.LblUpdate.Text = "Update";
            // 
            // LblDelete
            // 
            this.LblDelete.AutoSize = true;
            this.LblDelete.Location = new System.Drawing.Point(730, 184);
            this.LblDelete.Name = "LblDelete";
            this.LblDelete.Size = new System.Drawing.Size(56, 20);
            this.LblDelete.TabIndex = 12;
            this.LblDelete.Text = "Delete";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(227, 29);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(162, 26);
            this.TxtName.TabIndex = 13;
            // 
            // TxtDirector
            // 
            this.TxtDirector.Location = new System.Drawing.Point(227, 154);
            this.TxtDirector.Name = "TxtDirector";
            this.TxtDirector.Size = new System.Drawing.Size(162, 26);
            this.TxtDirector.TabIndex = 16;
            // 
            // CmbYear
            // 
            this.CmbYear.FormattingEnabled = true;
            this.CmbYear.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.CmbYear.Location = new System.Drawing.Point(227, 116);
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.Size = new System.Drawing.Size(162, 28);
            this.CmbYear.TabIndex = 17;
            // 
            // CmbLanguage
            // 
            this.CmbLanguage.FormattingEnabled = true;
            this.CmbLanguage.Items.AddRange(new object[] {
            "Dutch",
            "English",
            "French",
            "Japanese",
            "Korean",
            "Russian",
            "Turkish"});
            this.CmbLanguage.Location = new System.Drawing.Point(227, 197);
            this.CmbLanguage.Name = "CmbLanguage";
            this.CmbLanguage.Size = new System.Drawing.Size(162, 28);
            this.CmbLanguage.TabIndex = 18;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblName.Location = new System.Drawing.Point(66, 26);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(155, 29);
            this.LblName.TabIndex = 19;
            this.LblName.Text = "Movie Name:";
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblYear.Location = new System.Drawing.Point(80, 116);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(141, 29);
            this.LblYear.TabIndex = 20;
            this.LblYear.Text = "Movie Year:";
            // 
            // LblDirector
            // 
            this.LblDirector.AutoSize = true;
            this.LblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDirector.Location = new System.Drawing.Point(46, 153);
            this.LblDirector.Name = "LblDirector";
            this.LblDirector.Size = new System.Drawing.Size(175, 29);
            this.LblDirector.TabIndex = 21;
            this.LblDirector.Text = "Movie Director:";
            // 
            // LblLanguage
            // 
            this.LblLanguage.AutoSize = true;
            this.LblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblLanguage.Location = new System.Drawing.Point(24, 197);
            this.LblLanguage.Name = "LblLanguage";
            this.LblLanguage.Size = new System.Drawing.Size(197, 29);
            this.LblLanguage.TabIndex = 22;
            this.LblLanguage.Text = "Movie Language:";
            // 
            // CmbType
            // 
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Comedy",
            "Crime",
            "Historical",
            "Horror",
            "Science fiction",
            "Animation",
            "Romance Films"});
            this.CmbType.Location = new System.Drawing.Point(227, 287);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(162, 28);
            this.CmbType.TabIndex = 29;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblType.Location = new System.Drawing.Point(76, 287);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(145, 29);
            this.LblType.TabIndex = 28;
            this.LblType.Text = "Movie Type:";
            // 
            // LblStar
            // 
            this.LblStar.AutoSize = true;
            this.LblStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStar.Location = new System.Drawing.Point(76, 245);
            this.LblStar.Name = "LblStar";
            this.LblStar.Size = new System.Drawing.Size(145, 29);
            this.LblStar.TabIndex = 27;
            this.LblStar.Text = "Movie Stars:";
            // 
            // TxtStars
            // 
            this.TxtStars.Location = new System.Drawing.Point(227, 245);
            this.TxtStars.Name = "TxtStars";
            this.TxtStars.Size = new System.Drawing.Size(162, 26);
            this.TxtStars.TabIndex = 26;
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTime.Location = new System.Drawing.Point(66, 68);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(146, 29);
            this.LblTime.TabIndex = 31;
            this.LblTime.Text = "Movie Time:";
            // 
            // MtxtTime
            // 
            this.MtxtTime.Location = new System.Drawing.Point(227, 72);
            this.MtxtTime.Mask = "90:00";
            this.MtxtTime.Name = "MtxtTime";
            this.MtxtTime.Size = new System.Drawing.Size(162, 26);
            this.MtxtTime.TabIndex = 32;
            this.MtxtTime.ValidatingType = typeof(System.DateTime);
            // 
            // FrmMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1200, 863);
            this.Controls.Add(this.MtxtTime);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.CmbType);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.LblStar);
            this.Controls.Add(this.TxtStars);
            this.Controls.Add(this.LblLanguage);
            this.Controls.Add(this.LblDirector);
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.CmbLanguage);
            this.Controls.Add(this.CmbYear);
            this.Controls.Add(this.TxtDirector);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblDelete);
            this.Controls.Add(this.LblUpdate);
            this.Controls.Add(this.LblAdd);
            this.Controls.Add(this.LblList);
            this.Controls.Add(this.PicUpdate);
            this.Controls.Add(this.PicAdd);
            this.Controls.Add(this.PicDelete);
            this.Controls.Add(this.PicList);
            this.Controls.Add(this.PicExit);
            this.Controls.Add(this.PicBack);
            this.Controls.Add(this.PicSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMovies";
            this.Text = "FrmMovies";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.PictureBox PicSearch;
        private System.Windows.Forms.PictureBox PicBack;
        private System.Windows.Forms.PictureBox PicExit;
        private System.Windows.Forms.PictureBox PicList;
        private System.Windows.Forms.PictureBox PicDelete;
        private System.Windows.Forms.PictureBox PicAdd;
        private System.Windows.Forms.PictureBox PicUpdate;
        private System.Windows.Forms.Label LblList;
        private System.Windows.Forms.Label LblAdd;
        private System.Windows.Forms.Label LblUpdate;
        private System.Windows.Forms.Label LblDelete;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtDirector;
        private System.Windows.Forms.ComboBox CmbYear;
        private System.Windows.Forms.ComboBox CmbLanguage;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.Label LblDirector;
        private System.Windows.Forms.Label LblLanguage;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblStar;
        private System.Windows.Forms.TextBox TxtStars;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.MaskedTextBox MtxtTime;
    }
}
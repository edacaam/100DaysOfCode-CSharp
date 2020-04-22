namespace Listter
{
    partial class FrmBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBooks));
            this.LblSelect = new System.Windows.Forms.Label();
            this.PicSelect = new System.Windows.Forms.PictureBox();
            this.LblBookid = new System.Windows.Forms.Label();
            this.TxtBookid = new System.Windows.Forms.TextBox();
            this.LblPages = new System.Windows.Forms.Label();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.LblType = new System.Windows.Forms.Label();
            this.LblLanguage = new System.Windows.Forms.Label();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.CmbLanguage = new System.Windows.Forms.ComboBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblDelete = new System.Windows.Forms.Label();
            this.LblUpdate = new System.Windows.Forms.Label();
            this.LblAdd = new System.Windows.Forms.Label();
            this.LblList = new System.Windows.Forms.Label();
            this.PicUpdate = new System.Windows.Forms.PictureBox();
            this.PicAdd = new System.Windows.Forms.PictureBox();
            this.PicDelete = new System.Windows.Forms.PictureBox();
            this.PicList = new System.Windows.Forms.PictureBox();
            this.PicExit = new System.Windows.Forms.PictureBox();
            this.PicBack = new System.Windows.Forms.PictureBox();
            this.PicSearch = new System.Windows.Forms.PictureBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtPages = new System.Windows.Forms.TextBox();
            this.BtnPhoto = new System.Windows.Forms.Button();
            this.LblPhoto = new System.Windows.Forms.Label();
            this.TxtPhoto = new System.Windows.Forms.TextBox();
            this.TxtAuthor = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PicSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSelect
            // 
            this.LblSelect.AutoSize = true;
            this.LblSelect.Location = new System.Drawing.Point(595, 302);
            this.LblSelect.Name = "LblSelect";
            this.LblSelect.Size = new System.Drawing.Size(54, 20);
            this.LblSelect.TabIndex = 67;
            this.LblSelect.Text = "Select";
            // 
            // PicSelect
            // 
            this.PicSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicSelect.Image = ((System.Drawing.Image)(resources.GetObject("PicSelect.Image")));
            this.PicSelect.Location = new System.Drawing.Point(580, 234);
            this.PicSelect.Name = "PicSelect";
            this.PicSelect.Size = new System.Drawing.Size(83, 65);
            this.PicSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSelect.TabIndex = 66;
            this.PicSelect.TabStop = false;
            this.PicSelect.Click += new System.EventHandler(this.PicSelect_Click);
            // 
            // LblBookid
            // 
            this.LblBookid.AutoSize = true;
            this.LblBookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBookid.Location = new System.Drawing.Point(114, 42);
            this.LblBookid.Name = "LblBookid";
            this.LblBookid.Size = new System.Drawing.Size(101, 29);
            this.LblBookid.TabIndex = 65;
            this.LblBookid.Text = "Book Id:";
            // 
            // TxtBookid
            // 
            this.TxtBookid.Enabled = false;
            this.TxtBookid.Location = new System.Drawing.Point(221, 45);
            this.TxtBookid.Name = "TxtBookid";
            this.TxtBookid.Size = new System.Drawing.Size(162, 26);
            this.TxtBookid.TabIndex = 64;
            // 
            // LblPages
            // 
            this.LblPages.AutoSize = true;
            this.LblPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPages.Location = new System.Drawing.Point(65, 122);
            this.LblPages.Name = "LblPages";
            this.LblPages.Size = new System.Drawing.Size(150, 29);
            this.LblPages.TabIndex = 62;
            this.LblPages.Text = "Book Pages:";
            // 
            // CmbType
            // 
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "Fantasy",
            "Adventure",
            "Romance",
            "Contemporary",
            "Dystopian",
            "Mystery",
            "Horror",
            "Thriller",
            "Paranormal",
            "Historical fiction",
            "Science Fiction",
            "Memoir",
            "Cooking",
            "Art",
            "Self-help / Personal",
            "Development",
            "Motivational",
            "Health",
            "History",
            "Travel",
            "Guide / How-to",
            "Families & Relationships",
            "Humor",
            "Children’s"});
            this.CmbType.Location = new System.Drawing.Point(221, 257);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(162, 28);
            this.CmbType.TabIndex = 61;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblType.Location = new System.Drawing.Point(70, 257);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(136, 29);
            this.LblType.TabIndex = 60;
            this.LblType.Text = "Book Type:";
            // 
            // LblLanguage
            // 
            this.LblLanguage.AutoSize = true;
            this.LblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblLanguage.Location = new System.Drawing.Point(18, 214);
            this.LblLanguage.Name = "LblLanguage";
            this.LblLanguage.Size = new System.Drawing.Size(188, 29);
            this.LblLanguage.TabIndex = 57;
            this.LblLanguage.Text = "Book Language:";
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAuthor.Location = new System.Drawing.Point(65, 170);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(150, 29);
            this.LblAuthor.TabIndex = 55;
            this.LblAuthor.Text = "Book Author:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblName.Location = new System.Drawing.Point(69, 80);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(146, 29);
            this.LblName.TabIndex = 54;
            this.LblName.Text = "Book Name:";
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
            this.CmbLanguage.Location = new System.Drawing.Point(221, 214);
            this.CmbLanguage.Name = "CmbLanguage";
            this.CmbLanguage.Size = new System.Drawing.Size(162, 28);
            this.CmbLanguage.TabIndex = 53;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(221, 83);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(162, 26);
            this.TxtName.TabIndex = 50;
            // 
            // LblDelete
            // 
            this.LblDelete.AutoSize = true;
            this.LblDelete.Location = new System.Drawing.Point(737, 191);
            this.LblDelete.Name = "LblDelete";
            this.LblDelete.Size = new System.Drawing.Size(56, 20);
            this.LblDelete.TabIndex = 49;
            this.LblDelete.Text = "Delete";
            // 
            // LblUpdate
            // 
            this.LblUpdate.AutoSize = true;
            this.LblUpdate.Location = new System.Drawing.Point(628, 191);
            this.LblUpdate.Name = "LblUpdate";
            this.LblUpdate.Size = new System.Drawing.Size(62, 20);
            this.LblUpdate.TabIndex = 48;
            this.LblUpdate.Text = "Update";
            // 
            // LblAdd
            // 
            this.LblAdd.AutoSize = true;
            this.LblAdd.Location = new System.Drawing.Point(551, 191);
            this.LblAdd.Name = "LblAdd";
            this.LblAdd.Size = new System.Drawing.Size(38, 20);
            this.LblAdd.TabIndex = 47;
            this.LblAdd.Text = "Add";
            // 
            // LblList
            // 
            this.LblList.AutoSize = true;
            this.LblList.Location = new System.Drawing.Point(457, 192);
            this.LblList.Name = "LblList";
            this.LblList.Size = new System.Drawing.Size(34, 20);
            this.LblList.TabIndex = 46;
            this.LblList.Text = "List";
            // 
            // PicUpdate
            // 
            this.PicUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicUpdate.Image = ((System.Drawing.Image)(resources.GetObject("PicUpdate.Image")));
            this.PicUpdate.Location = new System.Drawing.Point(622, 124);
            this.PicUpdate.Name = "PicUpdate";
            this.PicUpdate.Size = new System.Drawing.Size(94, 65);
            this.PicUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUpdate.TabIndex = 45;
            this.PicUpdate.TabStop = false;
            this.PicUpdate.Click += new System.EventHandler(this.PicUpdate_Click);
            // 
            // PicAdd
            // 
            this.PicAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicAdd.Image = ((System.Drawing.Image)(resources.GetObject("PicAdd.Image")));
            this.PicAdd.Location = new System.Drawing.Point(528, 123);
            this.PicAdd.Name = "PicAdd";
            this.PicAdd.Size = new System.Drawing.Size(88, 65);
            this.PicAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicAdd.TabIndex = 44;
            this.PicAdd.TabStop = false;
            this.PicAdd.Click += new System.EventHandler(this.PicAdd_Click);
            // 
            // PicDelete
            // 
            this.PicDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicDelete.Image = ((System.Drawing.Image)(resources.GetObject("PicDelete.Image")));
            this.PicDelete.Location = new System.Drawing.Point(722, 123);
            this.PicDelete.Name = "PicDelete";
            this.PicDelete.Size = new System.Drawing.Size(83, 65);
            this.PicDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicDelete.TabIndex = 43;
            this.PicDelete.TabStop = false;
            this.PicDelete.Click += new System.EventHandler(this.PicDelete_Click);
            // 
            // PicList
            // 
            this.PicList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicList.Image = ((System.Drawing.Image)(resources.GetObject("PicList.Image")));
            this.PicList.Location = new System.Drawing.Point(433, 124);
            this.PicList.Name = "PicList";
            this.PicList.Size = new System.Drawing.Size(89, 65);
            this.PicList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicList.TabIndex = 42;
            this.PicList.TabStop = false;
            this.PicList.Click += new System.EventHandler(this.PicList_Click);
            // 
            // PicExit
            // 
            this.PicExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicExit.Image = ((System.Drawing.Image)(resources.GetObject("PicExit.Image")));
            this.PicExit.Location = new System.Drawing.Point(1155, 19);
            this.PicExit.Name = "PicExit";
            this.PicExit.Size = new System.Drawing.Size(40, 33);
            this.PicExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicExit.TabIndex = 41;
            this.PicExit.TabStop = false;
            this.PicExit.Click += new System.EventHandler(this.PicExit_Click);
            // 
            // PicBack
            // 
            this.PicBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBack.Image = ((System.Drawing.Image)(resources.GetObject("PicBack.Image")));
            this.PicBack.Location = new System.Drawing.Point(5, 7);
            this.PicBack.Name = "PicBack";
            this.PicBack.Size = new System.Drawing.Size(55, 53);
            this.PicBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBack.TabIndex = 40;
            this.PicBack.TabStop = false;
            this.PicBack.Click += new System.EventHandler(this.PicBack_Click);
            // 
            // PicSearch
            // 
            this.PicSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicSearch.Image = ((System.Drawing.Image)(resources.GetObject("PicSearch.Image")));
            this.PicSearch.Location = new System.Drawing.Point(1133, 392);
            this.PicSearch.Name = "PicSearch";
            this.PicSearch.Size = new System.Drawing.Size(38, 33);
            this.PicSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSearch.TabIndex = 39;
            this.PicSearch.TabStop = false;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSearch.Location = new System.Drawing.Point(929, 392);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(193, 31);
            this.TxtSearch.TabIndex = 38;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 433);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1156, 438);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TxtPages
            // 
            this.TxtPages.Location = new System.Drawing.Point(221, 126);
            this.TxtPages.Name = "TxtPages";
            this.TxtPages.Size = new System.Drawing.Size(162, 26);
            this.TxtPages.TabIndex = 68;
            // 
            // BtnPhoto
            // 
            this.BtnPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPhoto.Location = new System.Drawing.Point(389, 297);
            this.BtnPhoto.Name = "BtnPhoto";
            this.BtnPhoto.Size = new System.Drawing.Size(39, 32);
            this.BtnPhoto.TabIndex = 78;
            this.BtnPhoto.Text = "...";
            this.BtnPhoto.UseVisualStyleBackColor = true;
            this.BtnPhoto.Click += new System.EventHandler(this.BtnPhoto_Click);
            // 
            // LblPhoto
            // 
            this.LblPhoto.AutoSize = true;
            this.LblPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPhoto.Location = new System.Drawing.Point(57, 302);
            this.LblPhoto.Name = "LblPhoto";
            this.LblPhoto.Size = new System.Drawing.Size(144, 29);
            this.LblPhoto.TabIndex = 77;
            this.LblPhoto.Text = "Book Photo:";
            // 
            // TxtPhoto
            // 
            this.TxtPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPhoto.Location = new System.Drawing.Point(221, 301);
            this.TxtPhoto.Name = "TxtPhoto";
            this.TxtPhoto.Size = new System.Drawing.Size(162, 29);
            this.TxtPhoto.TabIndex = 76;
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.Location = new System.Drawing.Point(221, 174);
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.Size = new System.Drawing.Size(162, 26);
            this.TxtAuthor.TabIndex = 79;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(862, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 878);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtAuthor);
            this.Controls.Add(this.BtnPhoto);
            this.Controls.Add(this.LblPhoto);
            this.Controls.Add(this.TxtPhoto);
            this.Controls.Add(this.TxtPages);
            this.Controls.Add(this.LblSelect);
            this.Controls.Add(this.PicSelect);
            this.Controls.Add(this.LblBookid);
            this.Controls.Add(this.TxtBookid);
            this.Controls.Add(this.LblPages);
            this.Controls.Add(this.CmbType);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.LblLanguage);
            this.Controls.Add(this.LblAuthor);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.CmbLanguage);
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
            this.Name = "FrmBooks";
            this.Text = "FrmBooks";
            ((System.ComponentModel.ISupportInitialize)(this.PicSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSelect;
        private System.Windows.Forms.PictureBox PicSelect;
        private System.Windows.Forms.Label LblBookid;
        private System.Windows.Forms.TextBox TxtBookid;
        private System.Windows.Forms.Label LblPages;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblLanguage;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.ComboBox CmbLanguage;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblDelete;
        private System.Windows.Forms.Label LblUpdate;
        private System.Windows.Forms.Label LblAdd;
        private System.Windows.Forms.Label LblList;
        private System.Windows.Forms.PictureBox PicUpdate;
        private System.Windows.Forms.PictureBox PicAdd;
        private System.Windows.Forms.PictureBox PicDelete;
        private System.Windows.Forms.PictureBox PicList;
        private System.Windows.Forms.PictureBox PicExit;
        private System.Windows.Forms.PictureBox PicBack;
        private System.Windows.Forms.PictureBox PicSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtPages;
        private System.Windows.Forms.Button BtnPhoto;
        private System.Windows.Forms.Label LblPhoto;
        private System.Windows.Forms.TextBox TxtPhoto;
        private System.Windows.Forms.TextBox TxtAuthor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
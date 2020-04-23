namespace Listter
{
    partial class FrmSeries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeries));
            this.LblSelect = new System.Windows.Forms.Label();
            this.PicSelect = new System.Windows.Forms.PictureBox();
            this.LblSeriesid = new System.Windows.Forms.Label();
            this.TxtSeriesid = new System.Windows.Forms.TextBox();
            this.MtxtTime = new System.Windows.Forms.MaskedTextBox();
            this.LblTime = new System.Windows.Forms.Label();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.LblType = new System.Windows.Forms.Label();
            this.LblStar = new System.Windows.Forms.Label();
            this.TxtStars = new System.Windows.Forms.TextBox();
            this.LblLanguage = new System.Windows.Forms.Label();
            this.LblDirector = new System.Windows.Forms.Label();
            this.LblYear = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.CmbLanguage = new System.Windows.Forms.ComboBox();
            this.CmbYear = new System.Windows.Forms.ComboBox();
            this.TxtDirector = new System.Windows.Forms.TextBox();
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
            this.LblStatus = new System.Windows.Forms.Label();
            this.RBtnFinal = new System.Windows.Forms.RadioButton();
            this.RBtnContinuing = new System.Windows.Forms.RadioButton();
            this.LblSeason = new System.Windows.Forms.Label();
            this.CmbSeason = new System.Windows.Forms.ComboBox();
            this.LblPhoto = new System.Windows.Forms.Label();
            this.TxtPhoto = new System.Windows.Forms.TextBox();
            this.BtnPhoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.LblSelect.Location = new System.Drawing.Point(552, 282);
            this.LblSelect.Name = "LblSelect";
            this.LblSelect.Size = new System.Drawing.Size(54, 20);
            this.LblSelect.TabIndex = 67;
            this.LblSelect.Text = "Select";
            // 
            // PicSelect
            // 
            this.PicSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicSelect.Image = ((System.Drawing.Image)(resources.GetObject("PicSelect.Image")));
            this.PicSelect.Location = new System.Drawing.Point(537, 214);
            this.PicSelect.Name = "PicSelect";
            this.PicSelect.Size = new System.Drawing.Size(83, 65);
            this.PicSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSelect.TabIndex = 66;
            this.PicSelect.TabStop = false;
            this.PicSelect.Click += new System.EventHandler(this.PicSelect_Click);
            // 
            // LblSeriesid
            // 
            this.LblSeriesid.AutoSize = true;
            this.LblSeriesid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSeriesid.Location = new System.Drawing.Point(93, 20);
            this.LblSeriesid.Name = "LblSeriesid";
            this.LblSeriesid.Size = new System.Drawing.Size(115, 29);
            this.LblSeriesid.TabIndex = 65;
            this.LblSeriesid.Text = "Series Id:";
            // 
            // TxtSeriesid
            // 
            this.TxtSeriesid.Enabled = false;
            this.TxtSeriesid.Location = new System.Drawing.Point(214, 20);
            this.TxtSeriesid.Name = "TxtSeriesid";
            this.TxtSeriesid.Size = new System.Drawing.Size(162, 26);
            this.TxtSeriesid.TabIndex = 64;
            // 
            // MtxtTime
            // 
            this.MtxtTime.Location = new System.Drawing.Point(214, 101);
            this.MtxtTime.Mask = "90:00";
            this.MtxtTime.Name = "MtxtTime";
            this.MtxtTime.Size = new System.Drawing.Size(162, 26);
            this.MtxtTime.TabIndex = 63;
            this.MtxtTime.ValidatingType = typeof(System.DateTime);
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTime.Location = new System.Drawing.Point(37, 101);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(171, 29);
            this.LblTime.TabIndex = 62;
            this.LblTime.Text = "Episode Time:";
            // 
            // CmbType
            // 
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "Sitcom",
            "Reality",
            "Documentary",
            "Sports",
            "Educational",
            "Drama",
            "Cartoon",
            "Game Show",
            "Soap Opera"});
            this.CmbType.Location = new System.Drawing.Point(214, 269);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(162, 28);
            this.CmbType.TabIndex = 61;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblType.Location = new System.Drawing.Point(58, 273);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(150, 29);
            this.LblType.TabIndex = 60;
            this.LblType.Text = "Series Type:";
            // 
            // LblStar
            // 
            this.LblStar.AutoSize = true;
            this.LblStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStar.Location = new System.Drawing.Point(58, 231);
            this.LblStar.Name = "LblStar";
            this.LblStar.Size = new System.Drawing.Size(150, 29);
            this.LblStar.TabIndex = 59;
            this.LblStar.Text = "Series Stars:";
            // 
            // TxtStars
            // 
            this.TxtStars.Location = new System.Drawing.Point(214, 227);
            this.TxtStars.Name = "TxtStars";
            this.TxtStars.Size = new System.Drawing.Size(162, 26);
            this.TxtStars.TabIndex = 58;
            // 
            // LblLanguage
            // 
            this.LblLanguage.AutoSize = true;
            this.LblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblLanguage.Location = new System.Drawing.Point(6, 183);
            this.LblLanguage.Name = "LblLanguage";
            this.LblLanguage.Size = new System.Drawing.Size(202, 29);
            this.LblLanguage.TabIndex = 57;
            this.LblLanguage.Text = "Series Language:";
            // 
            // LblDirector
            // 
            this.LblDirector.AutoSize = true;
            this.LblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDirector.Location = new System.Drawing.Point(28, 139);
            this.LblDirector.Name = "LblDirector";
            this.LblDirector.Size = new System.Drawing.Size(180, 29);
            this.LblDirector.TabIndex = 56;
            this.LblDirector.Text = "Series Director:";
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblYear.Location = new System.Drawing.Point(42, 362);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(166, 29);
            this.LblYear.TabIndex = 55;
            this.LblYear.Text = "Release Year:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblName.Location = new System.Drawing.Point(48, 59);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(160, 29);
            this.LblName.TabIndex = 54;
            this.LblName.Text = "Series Name:";
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
            this.CmbLanguage.Location = new System.Drawing.Point(214, 179);
            this.CmbLanguage.Name = "CmbLanguage";
            this.CmbLanguage.Size = new System.Drawing.Size(162, 28);
            this.CmbLanguage.TabIndex = 53;
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
            this.CmbYear.Location = new System.Drawing.Point(214, 362);
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.Size = new System.Drawing.Size(162, 28);
            this.CmbYear.TabIndex = 52;
            // 
            // TxtDirector
            // 
            this.TxtDirector.Location = new System.Drawing.Point(214, 136);
            this.TxtDirector.Name = "TxtDirector";
            this.TxtDirector.Size = new System.Drawing.Size(162, 26);
            this.TxtDirector.TabIndex = 51;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(214, 58);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(162, 26);
            this.TxtName.TabIndex = 50;
            // 
            // LblDelete
            // 
            this.LblDelete.AutoSize = true;
            this.LblDelete.Location = new System.Drawing.Point(694, 171);
            this.LblDelete.Name = "LblDelete";
            this.LblDelete.Size = new System.Drawing.Size(56, 20);
            this.LblDelete.TabIndex = 49;
            this.LblDelete.Text = "Delete";
            // 
            // LblUpdate
            // 
            this.LblUpdate.AutoSize = true;
            this.LblUpdate.Location = new System.Drawing.Point(585, 171);
            this.LblUpdate.Name = "LblUpdate";
            this.LblUpdate.Size = new System.Drawing.Size(62, 20);
            this.LblUpdate.TabIndex = 48;
            this.LblUpdate.Text = "Update";
            // 
            // LblAdd
            // 
            this.LblAdd.AutoSize = true;
            this.LblAdd.Location = new System.Drawing.Point(508, 171);
            this.LblAdd.Name = "LblAdd";
            this.LblAdd.Size = new System.Drawing.Size(38, 20);
            this.LblAdd.TabIndex = 47;
            this.LblAdd.Text = "Add";
            // 
            // LblList
            // 
            this.LblList.AutoSize = true;
            this.LblList.Location = new System.Drawing.Point(414, 172);
            this.LblList.Name = "LblList";
            this.LblList.Size = new System.Drawing.Size(34, 20);
            this.LblList.TabIndex = 46;
            this.LblList.Text = "List";
            // 
            // PicUpdate
            // 
            this.PicUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicUpdate.Image = ((System.Drawing.Image)(resources.GetObject("PicUpdate.Image")));
            this.PicUpdate.Location = new System.Drawing.Point(579, 104);
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
            this.PicAdd.Location = new System.Drawing.Point(485, 103);
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
            this.PicDelete.Location = new System.Drawing.Point(679, 103);
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
            this.PicList.Location = new System.Drawing.Point(390, 104);
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
            this.PicExit.Location = new System.Drawing.Point(1148, -2);
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
            this.PicBack.Location = new System.Drawing.Point(-2, -2);
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
            this.PicSearch.Location = new System.Drawing.Point(1131, 456);
            this.PicSearch.Name = "PicSearch";
            this.PicSearch.Size = new System.Drawing.Size(38, 33);
            this.PicSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSearch.TabIndex = 39;
            this.PicSearch.TabStop = false;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSearch.Location = new System.Drawing.Point(927, 456);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(193, 31);
            this.TxtSearch.TabIndex = 38;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 494);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1156, 513);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStatus.Location = new System.Drawing.Point(47, 317);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(161, 29);
            this.LblStatus.TabIndex = 68;
            this.LblStatus.Text = "Series Status:";
            // 
            // RBtnFinal
            // 
            this.RBtnFinal.AutoSize = true;
            this.RBtnFinal.Location = new System.Drawing.Point(215, 317);
            this.RBtnFinal.Name = "RBtnFinal";
            this.RBtnFinal.Size = new System.Drawing.Size(61, 24);
            this.RBtnFinal.TabIndex = 69;
            this.RBtnFinal.TabStop = true;
            this.RBtnFinal.Text = "Final";
            this.RBtnFinal.UseVisualStyleBackColor = true;
            // 
            // RBtnContinuing
            // 
            this.RBtnContinuing.AutoSize = true;
            this.RBtnContinuing.Location = new System.Drawing.Point(282, 317);
            this.RBtnContinuing.Name = "RBtnContinuing";
            this.RBtnContinuing.Size = new System.Drawing.Size(103, 24);
            this.RBtnContinuing.TabIndex = 70;
            this.RBtnContinuing.TabStop = true;
            this.RBtnContinuing.Text = "Continuing";
            this.RBtnContinuing.UseVisualStyleBackColor = true;
            // 
            // LblSeason
            // 
            this.LblSeason.AutoSize = true;
            this.LblSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSeason.Location = new System.Drawing.Point(14, 408);
            this.LblSeason.Name = "LblSeason";
            this.LblSeason.Size = new System.Drawing.Size(194, 29);
            this.LblSeason.TabIndex = 72;
            this.LblSeason.Text = "Season Number:";
            // 
            // CmbSeason
            // 
            this.CmbSeason.FormattingEnabled = true;
            this.CmbSeason.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.CmbSeason.Location = new System.Drawing.Point(214, 406);
            this.CmbSeason.Name = "CmbSeason";
            this.CmbSeason.Size = new System.Drawing.Size(162, 28);
            this.CmbSeason.TabIndex = 71;
            // 
            // LblPhoto
            // 
            this.LblPhoto.AutoSize = true;
            this.LblPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPhoto.Location = new System.Drawing.Point(50, 460);
            this.LblPhoto.Name = "LblPhoto";
            this.LblPhoto.Size = new System.Drawing.Size(158, 29);
            this.LblPhoto.TabIndex = 74;
            this.LblPhoto.Text = "Series Photo:";
            // 
            // TxtPhoto
            // 
            this.TxtPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPhoto.Location = new System.Drawing.Point(214, 459);
            this.TxtPhoto.Name = "TxtPhoto";
            this.TxtPhoto.Size = new System.Drawing.Size(162, 29);
            this.TxtPhoto.TabIndex = 73;
            // 
            // BtnPhoto
            // 
            this.BtnPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPhoto.Location = new System.Drawing.Point(382, 455);
            this.BtnPhoto.Name = "BtnPhoto";
            this.BtnPhoto.Size = new System.Drawing.Size(39, 32);
            this.BtnPhoto.TabIndex = 75;
            this.BtnPhoto.Text = "...";
            this.BtnPhoto.UseVisualStyleBackColor = true;
            this.BtnPhoto.Click += new System.EventHandler(this.BtnPhoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(845, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1200, 1021);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnPhoto);
            this.Controls.Add(this.LblPhoto);
            this.Controls.Add(this.TxtPhoto);
            this.Controls.Add(this.LblSeason);
            this.Controls.Add(this.CmbSeason);
            this.Controls.Add(this.RBtnContinuing);
            this.Controls.Add(this.RBtnFinal);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblSelect);
            this.Controls.Add(this.PicSelect);
            this.Controls.Add(this.LblSeriesid);
            this.Controls.Add(this.TxtSeriesid);
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
            this.Name = "FrmSeries";
            this.Text = "FrmSeries";
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
        private System.Windows.Forms.Label LblSeriesid;
        private System.Windows.Forms.TextBox TxtSeriesid;
        private System.Windows.Forms.MaskedTextBox MtxtTime;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblStar;
        private System.Windows.Forms.TextBox TxtStars;
        private System.Windows.Forms.Label LblLanguage;
        private System.Windows.Forms.Label LblDirector;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.ComboBox CmbLanguage;
        private System.Windows.Forms.ComboBox CmbYear;
        private System.Windows.Forms.TextBox TxtDirector;
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
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.RadioButton RBtnFinal;
        private System.Windows.Forms.RadioButton RBtnContinuing;
        private System.Windows.Forms.Label LblSeason;
        private System.Windows.Forms.ComboBox CmbSeason;
        private System.Windows.Forms.Label LblPhoto;
        private System.Windows.Forms.TextBox TxtPhoto;
        private System.Windows.Forms.Button BtnPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace Listter
{
    partial class FrmMainpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainpage));
            this.PicSeries = new System.Windows.Forms.PictureBox();
            this.PicBooks = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblVisible = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.PicMovies = new System.Windows.Forms.PictureBox();
            this.CmbListType = new System.Windows.Forms.ComboBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtListName = new System.Windows.Forms.TextBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtListid = new System.Windows.Forms.TextBox();
            this.LblListid = new System.Windows.Forms.Label();
            this.BtnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PicSeries
            // 
            this.PicSeries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicSeries.Image = ((System.Drawing.Image)(resources.GetObject("PicSeries.Image")));
            this.PicSeries.Location = new System.Drawing.Point(672, 59);
            this.PicSeries.Name = "PicSeries";
            this.PicSeries.Size = new System.Drawing.Size(81, 58);
            this.PicSeries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSeries.TabIndex = 2;
            this.PicSeries.TabStop = false;
            this.PicSeries.Click += new System.EventHandler(this.PicSeries_Click);
            // 
            // PicBooks
            // 
            this.PicBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBooks.Image = ((System.Drawing.Image)(resources.GetObject("PicBooks.Image")));
            this.PicBooks.Location = new System.Drawing.Point(672, 59);
            this.PicBooks.Name = "PicBooks";
            this.PicBooks.Size = new System.Drawing.Size(81, 58);
            this.PicBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBooks.TabIndex = 3;
            this.PicBooks.TabStop = false;
            this.PicBooks.Click += new System.EventHandler(this.PicBooks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(172, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose List Type:";
            // 
            // LblVisible
            // 
            this.LblVisible.AutoSize = true;
            this.LblVisible.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblVisible.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblVisible.Location = new System.Drawing.Point(667, 120);
            this.LblVisible.Name = "LblVisible";
            this.LblVisible.Size = new System.Drawing.Size(74, 28);
            this.LblVisible.TabIndex = 5;
            this.LblVisible.Text = "BOOKS";
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUser.ForeColor = System.Drawing.Color.DarkRed;
            this.LblUser.Location = new System.Drawing.Point(379, 36);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(0, 33);
            this.LblUser.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(740, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // PicMovies
            // 
            this.PicMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMovies.Image = ((System.Drawing.Image)(resources.GetObject("PicMovies.Image")));
            this.PicMovies.Location = new System.Drawing.Point(674, 59);
            this.PicMovies.Name = "PicMovies";
            this.PicMovies.Size = new System.Drawing.Size(79, 58);
            this.PicMovies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMovies.TabIndex = 10;
            this.PicMovies.TabStop = false;
            this.PicMovies.Click += new System.EventHandler(this.PicSettings_Click);
            // 
            // CmbListType
            // 
            this.CmbListType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbListType.FormattingEnabled = true;
            this.CmbListType.Items.AddRange(new object[] {
            "Books",
            "Movies",
            "Series"});
            this.CmbListType.Location = new System.Drawing.Point(354, 73);
            this.CmbListType.Name = "CmbListType";
            this.CmbListType.Size = new System.Drawing.Size(188, 33);
            this.CmbListType.TabIndex = 12;
            this.CmbListType.SelectedIndexChanged += new System.EventHandler(this.CmbListType_SelectedIndexChanged);
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCreate.Location = new System.Drawing.Point(284, 216);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(95, 41);
            this.BtnCreate.TabIndex = 13;
            this.BtnCreate.Text = "CREATE";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(602, 263);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(164, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Choose List Name:";
            // 
            // TxtListName
            // 
            this.TxtListName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtListName.Location = new System.Drawing.Point(354, 110);
            this.TxtListName.Name = "TxtListName";
            this.TxtListName.Size = new System.Drawing.Size(188, 31);
            this.TxtListName.TabIndex = 16;
            // 
            // BtnList
            // 
            this.BtnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnList.Location = new System.Drawing.Point(183, 215);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(95, 42);
            this.BtnList.TabIndex = 17;
            this.BtnList.Text = "LISTS";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.Location = new System.Drawing.Point(385, 216);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(95, 41);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.Location = new System.Drawing.Point(486, 216);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(95, 41);
            this.BtnUpdate.TabIndex = 19;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtListid
            // 
            this.TxtListid.Enabled = false;
            this.TxtListid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtListid.Location = new System.Drawing.Point(354, 155);
            this.TxtListid.Name = "TxtListid";
            this.TxtListid.Size = new System.Drawing.Size(188, 31);
            this.TxtListid.TabIndex = 21;
            // 
            // LblListid
            // 
            this.LblListid.AutoSize = true;
            this.LblListid.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblListid.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblListid.Location = new System.Drawing.Point(260, 156);
            this.LblListid.Name = "LblListid";
            this.LblListid.Size = new System.Drawing.Size(80, 28);
            this.LblListid.TabIndex = 20;
            this.LblListid.Text = " List Id:";
            // 
            // BtnView
            // 
            this.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnView.Location = new System.Drawing.Point(337, 263);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(95, 42);
            this.BtnView.TabIndex = 23;
            this.BtnView.Text = "VIEW";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // FrmMainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(787, 592);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.TxtListid);
            this.Controls.Add(this.LblListid);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.TxtListName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.CmbListType);
            this.Controls.Add(this.PicMovies);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.LblVisible);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicBooks);
            this.Controls.Add(this.PicSeries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMainpage";
            this.Load += new System.EventHandler(this.FrmMainpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PicSeries;
        private System.Windows.Forms.PictureBox PicBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblVisible;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox PicMovies;
        private System.Windows.Forms.ComboBox CmbListType;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtListName;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtListid;
        private System.Windows.Forms.Label LblListid;
        private System.Windows.Forms.Button BtnView;
    }
}
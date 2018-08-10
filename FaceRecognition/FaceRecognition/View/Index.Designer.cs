namespace FaceRecognition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AuseBtn = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Recogbtn = new MetroFramework.Controls.MetroTile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AuseBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Recogbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroTile1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.metroTile2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // AuseBtn
            // 
            this.AuseBtn.ActiveControl = null;
            this.AuseBtn.BackColor = System.Drawing.Color.DeepPink;
            this.AuseBtn.Controls.Add(this.pictureBox1);
            this.AuseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuseBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AuseBtn.Location = new System.Drawing.Point(418, 84);
            this.AuseBtn.Name = "AuseBtn";
            this.AuseBtn.Size = new System.Drawing.Size(338, 140);
            this.AuseBtn.TabIndex = 0;
            this.AuseBtn.Text = "Add New Students";
            this.AuseBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.AuseBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.AuseBtn.UseCustomBackColor = true;
            this.AuseBtn.UseCustomForeColor = true;
            this.AuseBtn.UseSelectable = true;
            this.AuseBtn.Click += new System.EventHandler(this.AuseBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DeepPink;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Recogbtn
            // 
            this.Recogbtn.ActiveControl = null;
            this.Recogbtn.BackColor = System.Drawing.Color.DeepPink;
            this.Recogbtn.Controls.Add(this.pictureBox2);
            this.Recogbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Recogbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Recogbtn.Location = new System.Drawing.Point(43, 84);
            this.Recogbtn.Name = "Recogbtn";
            this.Recogbtn.Size = new System.Drawing.Size(342, 140);
            this.Recogbtn.TabIndex = 1;
            this.Recogbtn.Text = "Check Attendances";
            this.Recogbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Recogbtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Recogbtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Recogbtn.UseCustomBackColor = true;
            this.Recogbtn.UseCustomForeColor = true;
            this.Recogbtn.UseSelectable = true;
            this.Recogbtn.UseStyleColors = true;
            this.Recogbtn.UseTileImage = true;
            this.Recogbtn.Click += new System.EventHandler(this.Recogbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.DeepPink;
            this.metroTile1.Controls.Add(this.pictureBox3);
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroTile1.Location = new System.Drawing.Point(43, 249);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(342, 142);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Check Student Attendence";
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(24, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.DeepPink;
            this.metroTile2.Controls.Add(this.pictureBox4);
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroTile2.Location = new System.Drawing.Point(418, 249);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(338, 142);
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Group Recognition";
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseStyleColors = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.GroupRecognitionClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(25, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(83, 87);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(715, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "V 1.0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(792, 485);
            this.ClientSize = new System.Drawing.Size(792, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.Recogbtn);
            this.Controls.Add(this.AuseBtn);
            this.MaximumSize = new System.Drawing.Size(792, 485);
            this.MinimumSize = new System.Drawing.Size(792, 485);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Automated Face Attendance System";
            this.AuseBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Recogbtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroTile1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.metroTile2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile AuseBtn;
        private MetroFramework.Controls.MetroTile Recogbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
    }
}


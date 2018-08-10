namespace FaceRecognition.View
{
    partial class Register
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
            this.cam1 = new Emgu.CV.UI.ImageBox();
            this.btnregister = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.StuTex = new MetroFramework.Controls.MetroTextBox();
            this.StudeID = new MetroFramework.Controls.MetroTextBox();
            this.ConTEx = new MetroFramework.Controls.MetroTextBox();
            this.BatchTex = new MetroFramework.Controls.MetroComboBox();
            this.module1 = new System.Windows.Forms.CheckBox();
            this.module2 = new System.Windows.Forms.CheckBox();
            this.module3 = new System.Windows.Forms.CheckBox();
            this.module4 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cambutton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.cam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cam1
            // 
            this.cam1.Location = new System.Drawing.Point(55, 63);
            this.cam1.Name = "cam1";
            this.cam1.Size = new System.Drawing.Size(199, 169);
            this.cam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cam1.TabIndex = 2;
            this.cam1.TabStop = false;
            this.cam1.Click += new System.EventHandler(this.CaptureImage);
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(349, 432);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(140, 47);
            this.btnregister.TabIndex = 3;
            this.btnregister.Text = "Register Student";
            this.btnregister.UseSelectable = true;
            this.btnregister.Click += new System.EventHandler(this.SaveStudentDetails);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(297, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(421, 311);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Student Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(421, 371);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Student ID";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(50, 309);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Student Batch";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(50, 374);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(160, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Student Notification Email";
            // 
            // StuTex
            // 
            // 
            // 
            // 
            this.StuTex.CustomButton.Image = null;
            this.StuTex.CustomButton.Location = new System.Drawing.Point(332, 1);
            this.StuTex.CustomButton.Name = "";
            this.StuTex.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.StuTex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StuTex.CustomButton.TabIndex = 1;
            this.StuTex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StuTex.CustomButton.UseSelectable = true;
            this.StuTex.CustomButton.Visible = false;
            this.StuTex.Lines = new string[0];
            this.StuTex.Location = new System.Drawing.Point(425, 334);
            this.StuTex.MaxLength = 32767;
            this.StuTex.Name = "StuTex";
            this.StuTex.PasswordChar = '\0';
            this.StuTex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StuTex.SelectedText = "";
            this.StuTex.SelectionLength = 0;
            this.StuTex.SelectionStart = 0;
            this.StuTex.Size = new System.Drawing.Size(354, 23);
            this.StuTex.TabIndex = 15;
            this.StuTex.UseSelectable = true;
            this.StuTex.WaterMark = "Student Name";
            this.StuTex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StuTex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // StudeID
            // 
            // 
            // 
            // 
            this.StudeID.CustomButton.Image = null;
            this.StudeID.CustomButton.Location = new System.Drawing.Point(332, 1);
            this.StudeID.CustomButton.Name = "";
            this.StudeID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.StudeID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StudeID.CustomButton.TabIndex = 1;
            this.StudeID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StudeID.CustomButton.UseSelectable = true;
            this.StudeID.CustomButton.Visible = false;
            this.StudeID.Lines = new string[0];
            this.StudeID.Location = new System.Drawing.Point(426, 397);
            this.StudeID.MaxLength = 32767;
            this.StudeID.Name = "StudeID";
            this.StudeID.PasswordChar = '\0';
            this.StudeID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StudeID.SelectedText = "";
            this.StudeID.SelectionLength = 0;
            this.StudeID.SelectionStart = 0;
            this.StudeID.Size = new System.Drawing.Size(354, 23);
            this.StudeID.TabIndex = 16;
            this.StudeID.UseSelectable = true;
            this.StudeID.WaterMark = "Student ID";
            this.StudeID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StudeID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ConTEx
            // 
            // 
            // 
            // 
            this.ConTEx.CustomButton.Image = null;
            this.ConTEx.CustomButton.Location = new System.Drawing.Point(332, 1);
            this.ConTEx.CustomButton.Name = "";
            this.ConTEx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ConTEx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ConTEx.CustomButton.TabIndex = 1;
            this.ConTEx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ConTEx.CustomButton.UseSelectable = true;
            this.ConTEx.CustomButton.Visible = false;
            this.ConTEx.Lines = new string[0];
            this.ConTEx.Location = new System.Drawing.Point(55, 399);
            this.ConTEx.MaxLength = 32767;
            this.ConTEx.Name = "ConTEx";
            this.ConTEx.PasswordChar = '\0';
            this.ConTEx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConTEx.SelectedText = "";
            this.ConTEx.SelectionLength = 0;
            this.ConTEx.SelectionStart = 0;
            this.ConTEx.Size = new System.Drawing.Size(354, 23);
            this.ConTEx.TabIndex = 18;
            this.ConTEx.UseSelectable = true;
            this.ConTEx.WaterMark = "Email";
            this.ConTEx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ConTEx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BatchTex
            // 
            this.BatchTex.FormattingEnabled = true;
            this.BatchTex.ItemHeight = 23;
            this.BatchTex.Items.AddRange(new object[] {
            "1 Year",
            "2 Year",
            "3 Year"});
            this.BatchTex.Location = new System.Drawing.Point(55, 334);
            this.BatchTex.Name = "BatchTex";
            this.BatchTex.PromptText = "Select Batch";
            this.BatchTex.Size = new System.Drawing.Size(354, 29);
            this.BatchTex.TabIndex = 19;
            this.BatchTex.UseSelectable = true;
            this.BatchTex.SelectedIndexChanged += new System.EventHandler(this.LoadSubjects);
            // 
            // module1
            // 
            this.module1.AutoSize = true;
            this.module1.Location = new System.Drawing.Point(658, 74);
            this.module1.Name = "module1";
            this.module1.Size = new System.Drawing.Size(84, 17);
            this.module1.TabIndex = 20;
            this.module1.Text = "select batch";
            this.module1.UseVisualStyleBackColor = true;
            this.module1.CheckedChanged += new System.EventHandler(this.Module1_CheckedChanged);
            // 
            // module2
            // 
            this.module2.AutoSize = true;
            this.module2.Location = new System.Drawing.Point(658, 109);
            this.module2.Name = "module2";
            this.module2.Size = new System.Drawing.Size(84, 17);
            this.module2.TabIndex = 21;
            this.module2.Text = "select batch";
            this.module2.UseVisualStyleBackColor = true;
            this.module2.CheckedChanged += new System.EventHandler(this.Module2_CheckedChanged);
            // 
            // module3
            // 
            this.module3.AutoSize = true;
            this.module3.Location = new System.Drawing.Point(658, 144);
            this.module3.Name = "module3";
            this.module3.Size = new System.Drawing.Size(84, 17);
            this.module3.TabIndex = 22;
            this.module3.Text = "select batch";
            this.module3.UseVisualStyleBackColor = true;
            this.module3.CheckedChanged += new System.EventHandler(this.Module3_CheckedChanged);
            // 
            // module4
            // 
            this.module4.AutoSize = true;
            this.module4.Location = new System.Drawing.Point(659, 180);
            this.module4.Name = "module4";
            this.module4.Size = new System.Drawing.Size(84, 17);
            this.module4.TabIndex = 23;
            this.module4.Text = "select batch";
            this.module4.UseVisualStyleBackColor = true;
            this.module4.CheckedChanged += new System.EventHandler(this.Module4_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(418, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(530, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 114);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(418, 216);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(96, 39);
            this.metroButton1.TabIndex = 26;
            this.metroButton1.Text = "Clear";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.ClearImages);
            // 
            // cambutton
            // 
            this.cambutton.Location = new System.Drawing.Point(55, 238);
            this.cambutton.Name = "cambutton";
            this.cambutton.Size = new System.Drawing.Size(199, 42);
            this.cambutton.TabIndex = 27;
            this.cambutton.Text = "Start";
            this.cambutton.UseSelectable = true;
            this.cambutton.Click += new System.EventHandler(this.cambuttonClick);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 485);
            this.Controls.Add(this.cambutton);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.module4);
            this.Controls.Add(this.module3);
            this.Controls.Add(this.module2);
            this.Controls.Add(this.module1);
            this.Controls.Add(this.BatchTex);
            this.Controls.Add(this.ConTEx);
            this.Controls.Add(this.StudeID);
            this.Controls.Add(this.StuTex);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.cam1);
            this.Name = "Register";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "User Register Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closewindow);
            ((System.ComponentModel.ISupportInitialize)(this.cam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox cam1;
        private MetroFramework.Controls.MetroButton btnregister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox StuTex;
        private MetroFramework.Controls.MetroTextBox StudeID;
        private MetroFramework.Controls.MetroTextBox ConTEx;
        private MetroFramework.Controls.MetroComboBox BatchTex;
        private System.Windows.Forms.CheckBox module1;
        private System.Windows.Forms.CheckBox module2;
        private System.Windows.Forms.CheckBox module3;
        private System.Windows.Forms.CheckBox module4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton cambutton;
    }
}
namespace FaceRecognition.View
{
    partial class Recognition
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
            this.disImage = new System.Windows.Forms.PictureBox();
            this.capimagebox = new Emgu.CV.UI.ImageBox();
            this.registerSucessMessage = new System.Windows.Forms.Label();
            this.batchCode = new MetroFramework.Controls.MetroComboBox();
            this.subjectList = new MetroFramework.Controls.MetroComboBox();
            this.camButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.disImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capimagebox)).BeginInit();
            this.SuspendLayout();
            // 
            // disImage
            // 
            this.disImage.Location = new System.Drawing.Point(86, 166);
            this.disImage.Name = "disImage";
            this.disImage.Size = new System.Drawing.Size(188, 202);
            this.disImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.disImage.TabIndex = 3;
            this.disImage.TabStop = false;
            // 
            // capimagebox
            // 
            this.capimagebox.Location = new System.Drawing.Point(427, 72);
            this.capimagebox.Name = "capimagebox";
            this.capimagebox.Size = new System.Drawing.Size(328, 320);
            this.capimagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.capimagebox.TabIndex = 2;
            this.capimagebox.TabStop = false;
            // 
            // registerSucessMessage
            // 
            this.registerSucessMessage.AutoSize = true;
            this.registerSucessMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerSucessMessage.ForeColor = System.Drawing.Color.LightCoral;
            this.registerSucessMessage.Location = new System.Drawing.Point(129, 432);
            this.registerSucessMessage.Name = "registerSucessMessage";
            this.registerSucessMessage.Size = new System.Drawing.Size(76, 31);
            this.registerSucessMessage.TabIndex = 4;
            this.registerSucessMessage.Text = "Scan";
            // 
            // batchCode
            // 
            this.batchCode.FormattingEnabled = true;
            this.batchCode.ItemHeight = 23;
            this.batchCode.Items.AddRange(new object[] {
            "1 Year",
            "2 Year",
            "3 Year"});
            this.batchCode.Location = new System.Drawing.Point(23, 72);
            this.batchCode.Name = "batchCode";
            this.batchCode.PromptText = "Select Year";
            this.batchCode.Size = new System.Drawing.Size(320, 29);
            this.batchCode.TabIndex = 5;
            this.batchCode.UseSelectable = true;
            this.batchCode.SelectedIndexChanged += new System.EventHandler(this.SelectYear);
            // 
            // subjectList
            // 
            this.subjectList.FormattingEnabled = true;
            this.subjectList.ItemHeight = 23;
            this.subjectList.Location = new System.Drawing.Point(23, 120);
            this.subjectList.Name = "subjectList";
            this.subjectList.PromptText = "Subject";
            this.subjectList.Size = new System.Drawing.Size(320, 29);
            this.subjectList.TabIndex = 6;
            this.subjectList.UseSelectable = true;
            this.subjectList.SelectedIndexChanged += new System.EventHandler(this.SubjectIndexChnage);
            // 
            // camButton
            // 
            this.camButton.Location = new System.Drawing.Point(86, 388);
            this.camButton.Name = "camButton";
            this.camButton.Size = new System.Drawing.Size(188, 41);
            this.camButton.TabIndex = 7;
            this.camButton.Text = "Start";
            this.camButton.UseSelectable = true;
            this.camButton.Click += new System.EventHandler(this.Startrecognition);
            // 
            // Recognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 485);
            this.Controls.Add(this.camButton);
            this.Controls.Add(this.subjectList);
            this.Controls.Add(this.batchCode);
            this.Controls.Add(this.registerSucessMessage);
            this.Controls.Add(this.capimagebox);
            this.Controls.Add(this.disImage);
            this.Name = "Recognition";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Recognition Student Face";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.stopCamera);
            ((System.ComponentModel.ISupportInitialize)(this.disImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capimagebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox disImage;
        private Emgu.CV.UI.ImageBox capimagebox;
        private System.Windows.Forms.Label registerSucessMessage;
        private MetroFramework.Controls.MetroComboBox batchCode;
        private MetroFramework.Controls.MetroComboBox subjectList;
        private MetroFramework.Controls.MetroButton camButton;
    }
}
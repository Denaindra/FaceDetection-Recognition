namespace FaceRecognition.View
{
    partial class GroupRecognition
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
            this.pictureFrame = new Emgu.CV.UI.ImageBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureFrame
            // 
            this.pictureFrame.Location = new System.Drawing.Point(126, 113);
            this.pictureFrame.Name = "pictureFrame";
            this.pictureFrame.Size = new System.Drawing.Size(495, 310);
            this.pictureFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFrame.TabIndex = 2;
            this.pictureFrame.TabStop = false;
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.DeepPink;
            this.metroButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButton3.Location = new System.Drawing.Point(318, 63);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(107, 44);
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "Recognition Image";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseCustomForeColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseStyleColors = true;
            this.metroButton3.Click += new System.EventHandler(this.RecognitionImage);
            // 
            // GroupRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 446);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.pictureFrame);
            this.Name = "GroupRecognition";
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "GroupRecognition";
            ((System.ComponentModel.ISupportInitialize)(this.pictureFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Emgu.CV.UI.ImageBox pictureFrame;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}
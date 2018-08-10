namespace FaceRecognition.View
{
    partial class ViewAttendence
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.subjects = new MetroFramework.Controls.MetroComboBox();
            this.Viewbtn = new MetroFramework.Controls.MetroButton();
            this.DataTable = new MetroFramework.Controls.MetroGrid();
            this.Number = new System.Windows.Forms.Label();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.IDTextBox = new MetroFramework.Controls.MetroTextBox();
            this.eligibleText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // subjects
            // 
            this.subjects.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.subjects.FormattingEnabled = true;
            this.subjects.ItemHeight = 23;
            this.subjects.Items.AddRange(new object[] {
            "CF",
            "DCCN",
            "MIT",
            "IPF",
            "CGM",
            "DBMS",
            "SE",
            "ELS",
            "AAF",
            "CSSD",
            "AAF",
            "ADBCSA"});
            this.subjects.Location = new System.Drawing.Point(23, 63);
            this.subjects.Name = "subjects";
            this.subjects.PromptText = "Subject Code";
            this.subjects.Size = new System.Drawing.Size(200, 29);
            this.subjects.TabIndex = 1;
            this.subjects.UseSelectable = true;
            // 
            // Viewbtn
            // 
            this.Viewbtn.BackColor = System.Drawing.Color.White;
            this.Viewbtn.Location = new System.Drawing.Point(23, 146);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(200, 37);
            this.Viewbtn.TabIndex = 4;
            this.Viewbtn.Text = "View";
            this.Viewbtn.UseCustomBackColor = true;
            this.Viewbtn.UseCustomForeColor = true;
            this.Viewbtn.UseSelectable = true;
            this.Viewbtn.UseStyleColors = true;
            this.Viewbtn.Click += new System.EventHandler(this.Viewbtn_Click);
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToResizeRows = false;
            this.DataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataTable.EnableHeadersVisualStyles = false;
            this.DataTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataTable.Location = new System.Drawing.Point(309, 74);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataTable.Size = new System.Drawing.Size(444, 263);
            this.DataTable.TabIndex = 5;
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number.Location = new System.Drawing.Point(88, 204);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(57, 63);
            this.Number.TabIndex = 7;
            this.Number.Text = "0";
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.White;
            this.metroButton2.Location = new System.Drawing.Point(23, 397);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(200, 35);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Remove Attendence";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // IDTextBox
            // 
            // 
            // 
            // 
            this.IDTextBox.CustomButton.Image = null;
            this.IDTextBox.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.IDTextBox.CustomButton.Name = "";
            this.IDTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.IDTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IDTextBox.CustomButton.TabIndex = 1;
            this.IDTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IDTextBox.CustomButton.UseSelectable = true;
            this.IDTextBox.CustomButton.Visible = false;
            this.IDTextBox.Lines = new string[0];
            this.IDTextBox.Location = new System.Drawing.Point(23, 111);
            this.IDTextBox.MaxLength = 32767;
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.PasswordChar = '\0';
            this.IDTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IDTextBox.SelectedText = "";
            this.IDTextBox.SelectionLength = 0;
            this.IDTextBox.SelectionStart = 0;
            this.IDTextBox.Size = new System.Drawing.Size(200, 23);
            this.IDTextBox.TabIndex = 10;
            this.IDTextBox.UseSelectable = true;
            this.IDTextBox.WaterMark = "Student ID";
            this.IDTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IDTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // eligibleText
            // 
            this.eligibleText.AutoSize = true;
            this.eligibleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eligibleText.Location = new System.Drawing.Point(51, 274);
            this.eligibleText.Name = "eligibleText";
            this.eligibleText.Size = new System.Drawing.Size(0, 17);
            this.eligibleText.TabIndex = 11;
            // 
            // ViewAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 446);
            this.Controls.Add(this.eligibleText);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.Viewbtn);
            this.Controls.Add(this.subjects);
            this.Name = "ViewAttendence";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "View Attendence";
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox subjects;
        private MetroFramework.Controls.MetroButton Viewbtn;
        private MetroFramework.Controls.MetroGrid DataTable;
        private System.Windows.Forms.Label Number;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox IDTextBox;
        private System.Windows.Forms.Label eligibleText;
    }
}
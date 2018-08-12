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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.subjects = new MetroFramework.Controls.MetroComboBox();
            this.Viewbtn = new MetroFramework.Controls.MetroButton();
            this.DataTable = new MetroFramework.Controls.MetroGrid();
            this.Number = new System.Windows.Forms.Label();
            this.IDTextBox = new MetroFramework.Controls.MetroTextBox();
            this.eligibleText = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.BatchCode = new MetroFramework.Controls.MetroComboBox();
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
            "IPE",
            "CGM",
            "DBMS",
            "SE",
            "ELS",
            "MITP",
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
            this.Viewbtn.Location = new System.Drawing.Point(23, 332);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(200, 37);
            this.Viewbtn.TabIndex = 4;
            this.Viewbtn.Text = "View";
            this.Viewbtn.UseCustomBackColor = true;
            this.Viewbtn.UseCustomForeColor = true;
            this.Viewbtn.UseSelectable = true;
            this.Viewbtn.UseStyleColors = true;
            this.Viewbtn.Click += new System.EventHandler(this.ViewDetails);
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToResizeRows = false;
            this.DataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataTable.EnableHeadersVisualStyles = false;
            this.DataTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataTable.Location = new System.Drawing.Point(301, 201);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataTable.Size = new System.Drawing.Size(444, 233);
            this.DataTable.TabIndex = 5;
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number.Location = new System.Drawing.Point(88, 142);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(57, 63);
            this.Number.TabIndex = 7;
            this.Number.Text = "0";
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
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(294, 28);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DateSelected);
            // 
            // BatchCode
            // 
            this.BatchCode.AutoCompleteCustomSource.AddRange(new string[] {
            "1 Year",
            "2 Year",
            "3 Year"});
            this.BatchCode.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BatchCode.FormattingEnabled = true;
            this.BatchCode.ItemHeight = 23;
            this.BatchCode.Items.AddRange(new object[] {
            "1 Year",
            "2 Year",
            "3 Year"});
            this.BatchCode.Location = new System.Drawing.Point(533, 28);
            this.BatchCode.Name = "BatchCode";
            this.BatchCode.PromptText = "Batch";
            this.BatchCode.Size = new System.Drawing.Size(200, 29);
            this.BatchCode.TabIndex = 14;
            this.BatchCode.UseSelectable = true;
            // 
            // ViewAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 446);
            this.Controls.Add(this.BatchCode);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.eligibleText);
            this.Controls.Add(this.IDTextBox);
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
        private MetroFramework.Controls.MetroTextBox IDTextBox;
        private System.Windows.Forms.Label eligibleText;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MetroFramework.Controls.MetroComboBox BatchCode;
    }
}
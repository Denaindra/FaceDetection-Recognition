using FaceRecognition.Controller;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognition.View
{
    public partial class ViewAttendence : MetroForm
    {
        private FaceController faceController = new FaceController();
        private string batch;
        private List<DateTime> registertime;
        private List<string> mailList;
        private readonly String[] firstYearSubjects = { "CF", "DCCN", "MIT", "IPE" };
        private readonly String[] secondYearSubjects = { "CGM", "DBMS", "SE", "ELS" };
        private readonly String[] thirudYearSubjects = { "AAF", "CSSD", "MITP", "ADBCSA" };

        public ViewAttendence()
        {
            InitializeComponent();
        }
        private void ViewDetails(object sender, EventArgs e)
        {


            DataTable.DataSource = faceController.GetStudentAttendenceList(faceController.GetStudentID(IDTextBox.Text), subjects.Text);
            var studentCount = faceController.TotalCount(faceController.GetStudentID(IDTextBox.Text), subjects.Text);
            
            Number.Text = studentCount.ToString();
            eligibleText.Text = studentCount >= 20 ? "Student is eligible" :  "Student is not eligible";
        }


        private void DateSelected(object sender, DateRangeEventArgs e)
        {
            if (!subjects.Text.Equals(string.Empty) && !BatchCode.Text.Equals(string.Empty))
            {
                var selectedDate = e.Start;
                DataTable.DataSource = faceController.GetDayAttendenceStudentList(subjects.Text, BatchCode.Text, selectedDate);
            }
            else {
                MessageBox.Show("Please fill the Subject and Batch code", "Warring");
            }
        }
    }
}

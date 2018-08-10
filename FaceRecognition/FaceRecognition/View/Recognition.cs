using Emgu.CV;
using Emgu.CV.Structure;
using FaceRecognition.Controller;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading;
using System.Windows.Forms;

namespace FaceRecognition.View
{
    public partial class Recognition : MetroForm
    {
        private Capture capture;
        private bool captureSate;
        private ImageResizeAdaptee adpater = new ImageResizeApter();
        private Image<Bgr, byte> currentFrame;
        private FaceController faceController = new FaceController();
        private List<int> imageids = new List<int>();
        private readonly String[] firstYearSubjects = { "CF", "DCCN", "MIT", "IPF" };
        private readonly String[] secondYearSubjects = { "CGM", "DBMS", "SE", "ELS" };
        private readonly String[] thirudYearSubjects = { "AAF", "CSSD", "AAF", "ADBCSA" };
        public Recognition()
        {
            Application.DoEvents();
            InitializeComponent();
        }
        private void ProcessFrame(object sender, EventArgs e)
        {
            if (captureSate)
            {
                currentFrame = capture.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                faceController.StartFacerecognition(currentFrame);
                capimagebox.Image = faceController.GetRecognizedImage();
                faceController.SetNameAsempty();

                //check user recognized or not
                if (faceController.UserID() != 0)
                {
                    //recognized user alredy avaialebel in the system
                    if (!faceController.Checkperson(faceController.UserID(), batchCode.Text, subjectList.Text))
                    {
                        registerSucessMessage.Text = "Registered :)  See you soon ";
                        disImage.Image = Image.FromFile(Application.StartupPath + "/faces/" + faceController.UserID() + "_A" + ".png");
                        faceController.AddStudentToSheet(faceController.UserID(), batchCode.Text, faceController.GetCurrentTime(), faceController.GetCurrentDate(), subjectList.Text);
                        faceController.SetNameAsempty();
                        registerSucessMessage.Text = "Next Please ... ";

                        Thread.Sleep(5000);
                    }
                    else {
                        disImage.InitialImage = null;
                        Thread.Sleep(5000);
                        registerSucessMessage.Text = string.Empty;
                    }


                }
            }
        }

        private void stopCamera(object sender, FormClosingEventArgs e)
        {
            if (capture != null)
            {
                capture.Dispose();
            }
        }

        private void Startrecognition(object sender, EventArgs e)
        {
            if (!batchCode.Text.Equals(string.Empty) && !subjectList.Text.Equals(string.Empty))
            {
                try
                {
                    if (capture == null)
                    {
                        try
                        {
                            capture = new Capture();
                        }
                        catch (NullReferenceException excpt)
                        {
                            MessageBox.Show(excpt.Message);
                        }
                    }
                    if (capture != null)
                    {
                        if (captureSate)
                        {
                            camButton.Text = "Start";
                            Application.Idle -= ProcessFrame;
                        }
                        else
                        {
                            camButton.Text = "Stop";
                            Application.Idle += ProcessFrame;
                        }

                        captureSate = !captureSate;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Warring", "Please select a Bacth and subject");
            }
        }
        private string GetModule(string subject)
        {
            if (batchCode.SelectedIndex == 0)
            {
                var index = Array.IndexOf(firstYearSubjects, subject) + 1;
                return "module" + index.ToString();
            }
            else if (batchCode.SelectedIndex == 1)
            {
                var index = Array.IndexOf(secondYearSubjects, subject) + 1;
                return "module" + index.ToString();
            }
            else
            {
                var index = Array.IndexOf(thirudYearSubjects, subject) + 1;
                return "module" + index.ToString();
            }

        }
        private void SelectYear(object sender, EventArgs e)
        {
            if (batchCode.SelectedIndex == 0)
            {
                subjectList.Items.Clear();
                subjectList.Items.AddRange(firstYearSubjects);
            }
            else if (batchCode.SelectedIndex == 1)
            {
                subjectList.Items.Clear();
                subjectList.Items.AddRange(secondYearSubjects);
            }
            else
            {
                subjectList.Items.Clear();
                subjectList.Items.AddRange(thirudYearSubjects);
            }
            MessageBox.Show("Please select a subject for " + batchCode.Text, batchCode.Text);
        }

        private void SubjectIndexChnage(object sender, EventArgs e)
        {
            var subject = "Subjects." + GetModule(subjectList.Text) + " = 1";
            faceController.LoadFaceDetatils(batchCode.Text, subject);
        }
    }
}

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
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using FaceRecognition.Controller;

namespace FaceRecognition.View
{
    public partial class Register : MetroForm
    {

        private Capture capture;
        private bool captureSate;
        private List<int> checkList = new List<int>();
        private Image[] faceImages = new Image[3];
        private FaceController faceController = new FaceController();
        private Image<Bgr, Byte> ImageFrame;
        private Bitmap cropImage;
        private static string Pattern="^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        private readonly String[] firstYearSubjects = {"CF","DCCN","MIT","IPF" };
        private readonly String[] secondYearSubjects = {"CGM","DBMS","SE","ELS"};
        private readonly String[] thirudYearSubjects = { "AAF", "CSSD", "AAF","ADBCSA" };

      

        public Register()
        {
            InitializeComponent();
       
        }
        private void StratCam()
        {
            if (capture == null)
            {
                try
                {
                    capture = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show("Vision Camera not detected");
                }
            }
            if (capture != null)
            {
                if (captureSate)
                {
                    cambutton.Text = "Start";
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    cambutton.Text = "Stop";
                    Application.Idle += ProcessFrame;
                }
                captureSate = !captureSate;
            } 
        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (captureSate)
            {
                ImageFrame = capture.QueryFrame();
                faceController.FaceProcess(ImageFrame);
                cam1.Image = ImageFrame;
            }
        }
        private void CaptureImage(object sender, EventArgs e)
        {
            
            cropImage = faceController.CropImage();
            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = cropImage;
                faceImages[0] = cropImage;
            }
            else if (pictureBox2.Image == null)
            {
                pictureBox2.Image = cropImage;
                faceImages[1] = cropImage;
            }
            else if (pictureBox3.Image == null)
            {
                pictureBox3.Image = cropImage;
                faceImages[2] = cropImage;
            }
            else {
                MessageBox.Show("We added all 3 images, if you need to add again please press clear button below","Warring");
            }
        }

        private void SaveStudentDetails(object sender, EventArgs e)
        {
            try
            {
                if (StuTex.Text != "" && StudeID.Text != "" && BatchTex.Text != "" && ConTEx.Text != "" && System.Text.RegularExpressions.Regex.IsMatch(ConTEx.Text, Pattern)!=false && ConTEx.Text !="")
                {
                    faceController.Userregister(StuTex.Text, StudeID.Text, BatchTex.Text, ConTEx.Text, checkList ,faceImages);
                    MessageBox.Show("Sucessfully registered");
                }
                else
                {
                    MessageBox.Show("Fill all blanks and make sure email corrent validations ----");
                }
           }
            catch (Exception ex) {
                MessageBox.Show("There something not going well Plses check again");
            }
        }
        private void closewindow(object sender, FormClosingEventArgs e)
        {
            if (capture != null)
            {
      
                    capture.Dispose();
             
            
            }
        }

        private void Module1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkList.Contains(0))
            {
                checkList.Remove(0);
            }
            else {
                checkList.Add(0);
            }
            
        }

        private void Module2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkList.Contains(1))
            {
                checkList.Remove(1);
            }
            else
            {
                checkList.Add(1);
            }
        }

        private void Module3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkList.Contains(2))
            {
                checkList.Remove(2);
            }
            else
            {
                checkList.Add(2);
            }
        }

        private void Module4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkList.Contains(3))
            {
                checkList.Remove(3);
            }
            else
            {
                checkList.Add(3);
            }
        }

        private void ClearImages(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            Array.Clear(faceImages, 0, 3);
        }

        private void cambuttonClick(object sender, EventArgs e)
        {
            StratCam();
        }

        private void LoadSubjects(object sender, EventArgs e)
        {
            if (BatchTex.SelectedIndex == 0)
            {
                module1.Text = firstYearSubjects[0];
                module2.Text = firstYearSubjects[1];
                module3.Text = firstYearSubjects[2];
                module4.Text = firstYearSubjects[3];

            }
            else if (BatchTex.SelectedIndex == 1)
            {
                module1.Text = secondYearSubjects[0];
                module2.Text = secondYearSubjects[1];
                module3.Text = secondYearSubjects[2];
                module4.Text = secondYearSubjects[3];
            }
            else {
                module1.Text = thirudYearSubjects[0];
                module2.Text = thirudYearSubjects[1];
                module3.Text = thirudYearSubjects[2];
                module4.Text = thirudYearSubjects[3];
            }
        }
    }
}

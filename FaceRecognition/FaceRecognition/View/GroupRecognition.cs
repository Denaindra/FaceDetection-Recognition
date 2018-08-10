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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognition.View
{
    public partial class GroupRecognition : MetroForm
    {
        private FaceController faceController = new FaceController();
        private Image<Bgr, byte> currentFrame;

        public GroupRecognition()
        {
            InitializeComponent();
        }
        private void RecognitionImage(object sender, EventArgs e)
        {
            faceController.LoadFaceDetatils("3 Year", "Subjects.module4 = 1");
            currentFrame = ((Image<Bgr, byte>)pictureFrame.Image);
            faceController.StartFacerecognition(currentFrame);
            pictureFrame.Image = faceController.GetRecognizedImage();

            var UserId = faceController.GetImageIds();

            foreach (string id in UserId)
            {
                if (!faceController.Checkperson(Convert.ToInt32(id), "3 Year", "ADBCSA"))
                {
                    faceController.AddStudentToSheet(Convert.ToInt32(id), "3 Year", faceController.GetCurrentTime(), faceController.GetCurrentDate(), "ADBCSA");
                    MessageBox.Show("ID " + faceController.GetID(id) + " Student added", "Sucess");
                }
                else
                {
                    MessageBox.Show("ID "+faceController.GetID(id) + " Student alredy attended to this class", "Warring");
                }
            }

            
  
        }
    }
}

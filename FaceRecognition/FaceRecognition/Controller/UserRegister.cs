using Emgu.CV;
using Emgu.CV.Structure;
using FaceRecognition.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognition.Controller
{
    public class UserRegister
    {
        private Bitmap cropImage;
        private String FileName;
        private int currentStudenID;
        private Image<Bgr, byte> resizedImage;
        private string Filepath;
        private Bitmap resizeIma; 
        private DataBase conn = new DataBase();
        private static UserRegister instant = new UserRegister();

        public UserRegister() {
            //conn.DataConnection();
        }
        public void setCropImage(Bitmap image)
        {            
            this.cropImage = image;
        }
        public void RenameFile(int extension) {
            switch (extension)
            {
                case 0:
                    this.FileName = currentStudenID.ToString() + "_" + "A";
                    break;
                case 1:
                    this.FileName = currentStudenID.ToString() + "_" + "B";
                    break;
                case 2:
                    this.FileName = currentStudenID.ToString() + "_" + "C";
                    break;
            }
         
        }
        public void GetFilenumber() {
          this.currentStudenID = conn.GetLastStudenID();
        }
        public void StoreFile() {
            Image<Bgr, Byte> myImage = new Image<Bgr, Byte>(cropImage);
            resizedImage = myImage.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
            resizedImage.Save("faces/" + this.FileName + ".png");
        }
        public void RegisterUserDetails(string name, string address, string batch, string email,List<int>subjects)
        {
         
            conn.AddStudentDetails(name, address, batch, email);
            GetFilenumber();
            this.Filepath = "/faces/" + this.currentStudenID;
            conn.AddStudentSubjects(this.currentStudenID, subjects);
        }
        public static UserRegister getInstance() {
            return instant;
        }
        public Bitmap resizeimage() {
            this.resizeIma = this.resizedImage.ToBitmap();
            return this.resizeIma;
        }
        public void CurrentDate() { 
        
        }
       
    }
}

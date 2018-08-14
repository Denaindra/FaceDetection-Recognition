using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

namespace FaceRecognition.Controller
{
   public class FaceDetection
    {
       private Image<Gray, byte> grayImage;
       private HaarCascade harr;
       private Bitmap mapImage;
       private Bitmap cropImage;
       private Image<Bgr, Byte> ImageFrame;
       private static Size size = new Size(25, 25);
       private const double ScaleFactor = 1.4;
       private const int minMabours = 4;
       private int i = 0;
       private static FaceDetection instance = new FaceDetection();

       public FaceDetection() { 
       
       }
       public void SetCurrentFrame(Image<Bgr, Byte> ImageFrame)
       {
           this.ImageFrame = ImageFrame;
       }
       public void ImageGray()
       {
            //image grascale
           this.grayImage = this.ImageFrame.Convert<Gray, byte>();
       }
       public void HarrCasCade() {
            //Face Detector
            var faces = this.grayImage.DetectHaarCascade(harr, ScaleFactor, minMabours, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, size)[0];
           i++;
            //Action for each element detected
            foreach (var face in faces)
           {
               try
               {
                   Rectangle rects = face.rect;
                    if (rects.Height > 350 && rects.Width > 350)
                    {
                        //draw the face detected channel with green color
                        this.ImageFrame.Draw(face.rect, new Bgr(Color.Green), 2);
                       this.cropImage = this.mapImage.Clone(face.rect, PixelFormat.Format8bppIndexed);

                    //Image<Bgr, Byte> ImageFrame = new Image<Bgr, Byte>(cropImage).Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC); ;
                    //ImageFrame.Save("test1.png");
                }
               }
               catch (Exception ex)
               {
                   string a = ex.ToString();
                }
            }
       }
       public void ImageToBitmap() {
           this.mapImage = grayImage.ToBitmap();
       }
       public void LoadHarrCascade() {
            //Load haarcascades for face detection
            harr = new HaarCascade("haarcascade_frontalface_default.xml");
       }
       public Bitmap GetCropImage() {
           return this.cropImage;
       }
       public static FaceDetection getInstance()
       {
           return instance;
       }
   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace FaceRecognition.Controller
{
    public class UserRecognition
    {
        private Image<Bgr, Byte> currentFrame;
        private HaarCascade face;
        private EigenObjectRecognizer recognizer;
        private MCvTermCriteria termCrit;
        private MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        private Image<Gray, byte> result = null;
        private Image<Gray, byte> gray = null;
        private List<Image<Gray, byte>> trainingfaces = new List<Image<Gray, byte>>();
        //private List<string> labels = new List<string>();
        private List<string> IDofPersons = new List<string>();
        private int ContTrain, numberOfLabels, t;
        private string ID = null;
        private string IDs = null;
        private MCvAvgComp[][] facedReco;
        private static UserRecognition instants = new UserRecognition();
        private List<string> imageids = new List<string>();
        private double scaleFactor = 1.2;
        private int minNabours = 10;
     

        public UserRecognition()
        {

        }
        public List<string> GetImageIDs()
        {
            return imageids.Distinct().ToList();
        }
        public void SetImageIDs(List<string> imageids)
        {
            this.imageids = imageids;
        }
        public void LoadHrrcascade()
        {
            //Load haarcascades for face detection
            face = new HaarCascade("haarcascade_frontalface_default.xml");
        }
        public void Loadfaces()
        {
            //Load of previus trainned faces and labels for each image
            trainingfaces.Clear();
            try
            {
                var Idlist = imageids.Distinct().ToList();
                numberOfLabels = Idlist.Count();
                ContTrain = numberOfLabels;
                for (int a = 0; a < numberOfLabels; a++)
                {
                    trainingfaces.Add(new Image<Gray, byte>(Application.StartupPath + "/faces/" + Idlist[a] + "_A" + ".png"));
                    trainingfaces.Add(new Image<Gray, byte>(Application.StartupPath + "/faces/" + Idlist[a] + "_B" + ".png"));
                    trainingfaces.Add(new Image<Gray, byte>(Application.StartupPath + "/faces/" + Idlist[a] + "_C" + ".png"));
                }
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
        }
        public int GetContTrain()
        {
            return ContTrain;
        }
        public void Addname()
        {
            IDofPersons.Add("");
        }
        public void setImage(Image<Bgr, Byte> cuFrame)
        {
            currentFrame = cuFrame;
        }
        public void convert2Gray()
        {
             gray = currentFrame.Convert<Gray, Byte>();
        }
        public void FaceDetector()
        {
            //detect face detection
            facedReco = this.gray.DetectHaarCascade(
            this.face,
            this.scaleFactor,
            this.minNabours,
            Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
            new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facedReco[0])
            {
                try
                {
                        t++;
                    //resized image
                        result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    //draw the face detected in the 0th (gray) channel with green color
                    currentFrame.Draw(f.rect, new Bgr(Color.Green), 2);
                        if (this.trainingfaces.ToArray().Length != 0)
                        {
                        //TermCriteria for face recognition with numbers of trained images like maxIteration
                            termCrit = new MCvTermCriteria(GetContTrain(), 0.001);
                        //Eigen face recognizer
                            EigenObjectRecognizers eginrecog = new EigenObjectRecognizers(this.trainingfaces.ToArray(), imageids.ToArray(), 3000, ref termCrit);
                            ID = eginrecog.Recognize(result);
                        //Draw the label for each face detected and recognized
                        currentFrame.Draw(ID, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));
                        }
                    
                        IDofPersons[t - 1] = ID;
                        IDofPersons.Add("");
          
                }
                catch (Exception ex)
                {
                    String a = ex.ToString();
                }
            }
        }
        public void setT()
        {
            t = 0;
        }
        //Load user IDs
        public void nameContainer()
        {
            for (int x = 0; x < this.facedReco[0].Length; x++)
            {
                IDs = IDs + IDofPersons[x] + ", ";
            }
        }
        public Image<Bgr, Byte> getCuurentframe()
        {
            return currentFrame;
        }
        public void Clearname()
        {
            IDofPersons.Clear();
        }
        public void SetNameEmpty()
        {
            IDs = "";
        }
        public static UserRecognition getinstances()
        {
            return instants;
        }
        //Get Curent UserID
        public int GetUSerID()
        {
            if (ID != null && ID != "")
            {
                 return Int32.Parse(ID);
            }
            return 0;
        }

    }
}

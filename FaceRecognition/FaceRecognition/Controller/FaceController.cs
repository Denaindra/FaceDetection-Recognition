using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FaceRecognition.Model;
using System.Data;
using ClosedXML.Excel;

namespace FaceRecognition.Controller
{
    public class FaceController
    {

        private static FaceDetection facede;
        private static UserRegister UseRe;
        private static UserRecognition userRecognition;
        private static DataBase database;
        private static ParentNotify notify;
        private static DateHelper date;
        private static TimeHelper timeCurrent;
        private List<int> StidentID = new List<int>();
        private Bitmap resizedimage;

        public FaceController()
        {
            FaceDetect();
            facede.LoadHarrCascade();
          
        }
        public static void FaceDetect() {
           
           facede = FaceDetection.getInstance();
           UseRe = UserRegister.getInstance();
           database = DataBase.getInstances();
           userRecognition = UserRecognition.getinstances();
           notify = ParentNotify.getinstances();
           date = DateHelper.getinstance();
           timeCurrent = TimeHelper.getInstances();
        }
        public void FaceProcess(Image<Bgr, Byte> ImageFrame)
        {
            facede.SetCurrentFrame(ImageFrame);
            facede.ImageGray();
            facede.ImageToBitmap();
            facede.HarrCasCade();
        }
        public void Userregister(string name,string address,string batch,string email ,List<int> subjects,Image[]studentFaces){

            UseRe.RegisterUserDetails(name, address, batch, email, subjects);

            for (int i = 0; i < studentFaces.Length; i++)
            {
                UseRe.setCropImage((Bitmap)studentFaces[i]);
                UseRe.RenameFile(i);
                UseRe.StoreFile();
            }

        }
        public void LoadFaceDetatils(string batch,string subject) {
            userRecognition.SetImageIDs(database.LoadImageIDs(batch,subject));
            userRecognition.LoadHrrcascade();
            userRecognition.Loadfaces();
        }

        public DataTable GetDayAttendenceStudentList(string subject, string batch,DateTime selectedDate)
        {
            return database.GetDayStudentAttendece(subject,batch,selectedDate);
        }

        public void StartFacerecognition(Image<Bgr, byte> currentFrame)
        {
            userRecognition.Addname();
            userRecognition.setImage(currentFrame);
            userRecognition.convert2Gray();
            userRecognition.FaceDetector();
            userRecognition.setT();
            userRecognition.nameContainer();
        }
        public int UserID() {
            return userRecognition.GetUSerID();
        }
        public Image<Bgr, byte> GetRecognizedImage()
        {
            return userRecognition.getCuurentframe();
        }
        public List<string> GetImageIds()
        {
            return userRecognition.GetImageIDs();
        }
        public void SetNameAsempty(){
            userRecognition.SetNameEmpty();
        }
        public void Resize_Image() {
            this.resizedimage=UseRe.resizeimage();  
        }
        public Bitmap CropImage(){
           return facede.GetCropImage();
        }
        public bool Checkperson(int ID,string batchCode,string subject) {
           return database.CheckPresetage(ID,batchCode,subject);
        }
     
        public void AddStudentToSheet(int StudentID,string batch,DateTime time,DateTime date,string subject) {
            database.MakeAttendecs(StudentID,batch,time,date,subject);
        }
        public DateTime GetCurrentDate() {
           return date.Convert2Date();
        }
        public string getBatchCode(int StudentID) {
          return database.GetbatchCode(StudentID);
        }
        public string GetID(string id)
        {
            return database.GetIDFromStudentID(id);
        }
        public string GetStudentID(string id)
        {
            return database.GetStudentID(id);
        }
        public DateTime GetCurrentTime() {
            return timeCurrent.getCurrentTime();
        }
        public DataTable GetStudentAttendenceList(string studentId, string subjectCode)
        {
           return database.GetStudentAttendences(studentId, subjectCode);
        }
        public int TotalCount(string studentId, string subject)
        {
            return database.TotoalStudents(studentId,subject);
        }
        public string GetMail(string studentID)
        {
            return database.Getstudentmail(studentID);
        }
        public void GenerateReports(DataTable table)
        {
            XLWorkbook wb = new XLWorkbook();
            DataTable dt = table;

            wb.Worksheets.Add(dt, "WorksheetName");
            wb.SaveAs(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"/"+DateTime.Today.DayOfWeek+"_"+"report"+".xlsx");
        }

      
    }
}

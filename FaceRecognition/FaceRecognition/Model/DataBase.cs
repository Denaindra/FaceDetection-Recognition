using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Emgu.CV;
using Emgu.CV.Structure;
namespace FaceRecognition.Model
{
    public class DataBase
    {
        private static DataBase db = new DataBase();
        private SqlConnection cnn;
        private SqlCommand com;
        private string sql = null;
        private string batchCode;
        private string email;
        private string name;
        private const string connetionString = "Data Source=DESKTOP-FACGP3T;Initial Catalog=StRecognize;Integrated Security=True";
        List<string> imageID = new List<string>();
        List<int> subjects = new List<int>();
        List<string> studentmail = new List<string>();
        List<DateTime> currenttime = new List<DateTime>();

        public DataBase()
        {

        }
        public void AddStudentDetails(string name, string id, string batch, string email)
        {
            sql = "insert into StudentDetails (BatchCode,StudentName,ID,Email) values (@BatCode,@Stname,@Id,@conNu)";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                com = new SqlCommand(sql, cnn);
                com.Parameters.Add("@BatCode", SqlDbType.NChar).Value = batch;
                com.Parameters.Add("@Stname", SqlDbType.NChar).Value = name;
                com.Parameters.Add("@id", SqlDbType.NChar).Value = id;
                com.Parameters.Add("@conNu", SqlDbType.NChar).Value = email;
                com.ExecuteNonQuery();
                com.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
        }
        public void AddStudentSubjects(int fileID, List<int> subjects)
        {

            sql = "insert into Subjects (StudentID,module1,module2,module3,module4) values (@StudentID,@module1,@module2,@module3,@module4)";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                com = new SqlCommand(sql, cnn);
                com.Parameters.Add("@StudentID", SqlDbType.Int).Value = fileID;

                if (subjects.Contains(0))
                {
                    com.Parameters.Add("@module1", SqlDbType.Int).Value = 1;
                }
                else
                {
                    com.Parameters.Add("@module1", SqlDbType.Int).Value = 0;
                }

                if (subjects.Contains(1))
                {
                    com.Parameters.Add("@module2", SqlDbType.Int).Value = 1;
                }
                else
                {
                    com.Parameters.Add("@module2", SqlDbType.Int).Value = 0;
                }
                if (subjects.Contains(2))
                {
                    com.Parameters.Add("@module3", SqlDbType.Int).Value = 1;
                }
                else
                {
                    com.Parameters.Add("@module3", SqlDbType.Int).Value = 0;
                }
                if (subjects.Contains(3))
                {
                    com.Parameters.Add("@module4", SqlDbType.Int).Value = 1;
                }
                else
                {
                    com.Parameters.Add("@module4", SqlDbType.Int).Value = 0;
                }

                com.ExecuteNonQuery();
                com.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }

        }
        public int GetLastStudenID()
        {
            int id = 0;
            sql = "SELECT TOP 1 StudentID FROM StudentDetails ORDER BY StudentID DESC";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            com = new SqlCommand(sql, cnn);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                id = (int)reader["StudentID"];
            }
            com.Dispose();
            cnn.Close();
            return id;
        }
        public static DataBase getInstances()
        {
            return db;
        }
        public List<string> LoadImageIDs(string batch, string subject)
        {
            imageID.Clear();
            sql = "select StudentDetails.StudentID from StudentDetails Right join Subjects on Subjects.StudentID = StudentDetails.StudentID where StudentDetails.BatchCode = '" + batch + "' and " + subject;// Subjects.AM = 1";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            com = new SqlCommand(sql, cnn);
            SqlDataReader DataReader = com.ExecuteReader();
            while (DataReader.Read())
            {
                imageID.Add((DataReader["StudentID"].ToString()));
                imageID.Add((DataReader["StudentID"].ToString()));
                imageID.Add((DataReader["StudentID"].ToString()));
            }
            com.Dispose();
            cnn.Close();
            return imageID;
        }
        public bool CheckPresetage(int StudentID,string batchCode,string subject)
        {
            try
            {
                sql = "Select COUNT(StudentID) from RegisterDetails Where StudentID='" + StudentID+ "' and Batch='"+batchCode+"' and  Subjects='"+subject+"'";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                com = new SqlCommand(sql, cnn);

                var result = (Int32)com.ExecuteScalar() == 0;
                com.Dispose();
                cnn.Close();

                if (result)
                {
                    return false;
                }
                else {
                    return true;
                }
            
           

            }
            catch (Exception ex)
            {
    
            }
            return true;
        }
        public void MakeAttendecs(int StudentID, string Batch, DateTime time, DateTime date,string subject)
        {

            sql = "insert into RegisterDetails (StudentID,Batch,ETime,ReDate,Subjects) values (@stID,@BatCode,@time,@date,@subject)";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                com = new SqlCommand(sql, cnn);
                com.Parameters.Add("@stID", SqlDbType.Int).Value = StudentID;
                com.Parameters.Add("@BatCode", SqlDbType.VarChar).Value = Batch;
                com.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
                com.Parameters.Add("@time", SqlDbType.DateTime).Value = time;
                com.Parameters.Add("@subject", SqlDbType.VarChar).Value = subject;

                com.ExecuteNonQuery();
                com.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }

        }
        public string Parentemail()
        {
            return email;
        }
        public string Getname()
        {
            return name;
        }
        public string GetbatchCode(int StudentID)
        {
            try
            {
                sql = "Select Email,BatchCode,StudentName from StudentDetails Where StudentID=" + StudentID;
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                com = new SqlCommand(sql, cnn);
                SqlDataReader DataReader = com.ExecuteReader();
                while (DataReader.Read())
                {
                    email = Convert.ToString(DataReader["Email"]);
                    batchCode = Convert.ToString(DataReader["BatchCode"]);
                    name = Convert.ToString(DataReader["StudentName"]);
                }
                com.Dispose();
                cnn.Close();

                return batchCode;
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
            return "";
        }
        public DataTable GetStudentAttendences(string studentID, string subjectCode)
        {
            DataTable tabl = new DataTable();
            try
            {
                sql = "select * from RegisterDetails where StudentID='" + studentID + "' and Subjects='" + subjectCode + "'";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                com = new SqlCommand(sql, cnn);
                SqlDataAdapter Sda = new SqlDataAdapter();
                Sda.SelectCommand = com;
                Sda.Fill(tabl);

                com.Dispose();
                cnn.Close();
                return tabl;

            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }

            return tabl;
        }
        public int TotoalStudents(string studetID, string subjects)
        {
            sql = "select count(*) from RegisterDetails where StudentID='" + studetID + "' and Subjects='" + subjects + "'";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            com = new SqlCommand(sql, cnn);
            Int32 count = (Int32)com.ExecuteScalar();
            com.Dispose();
            cnn.Close();
            return count;
        }
        public String GetIDFromStudentID(string StudentID)
        {
            try
            {
                string ID = string.Empty;
                sql = "Select ID from StudentDetails Where StudentID='"+ StudentID+"'";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                com = new SqlCommand(sql, cnn);
                SqlDataReader DataReader = com.ExecuteReader();
                while (DataReader.Read())
                {
                  ID = Convert.ToString(DataReader["ID"]);
                }
                com.Dispose();
                cnn.Close();

                return ID;
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
            return "";
        }

        public String GetStudentID(string StudentID)
        {
            try
            {
                string ID = string.Empty;
                sql = "Select StudentID from StudentDetails Where ID='" + StudentID + "'";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                com = new SqlCommand(sql, cnn);
                SqlDataReader DataReader = com.ExecuteReader();
                while (DataReader.Read())
                {
                    ID = Convert.ToString(DataReader["StudentID"]);
                }
                com.Dispose();
                cnn.Close();

                return ID;
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
            return "";
        }

        public List<string> Getstudentmail(string batchcode)
        {
            studentmail.Clear();
            currenttime.Clear();

            sql = "SELECT StudentDetails.Email,RegisterDetails.ETime FROM StudentDetails INNER JOIN RegisterDetails ON StudentDetails.StudentID=RegisterDetails.StudentID";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            com = new SqlCommand(sql, cnn);
            SqlDataReader DataReader = com.ExecuteReader();
            while (DataReader.Read())
            {
                studentmail.Add(Convert.ToString(DataReader["Email"]));
                currenttime.Add(Convert.ToDateTime(DataReader["ETime"].ToString()));
            }
            com.Dispose();
            cnn.Close();
            return studentmail;
        }
        public List<int> GetSudentSubjects(int studentID)
        {
            return subjects;

        }
        public List<DateTime> Getcurrentlist(string batchcode)
        {
            return currenttime;
        }
        public void DeletaeAttendece()
        {
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand command = new SqlCommand("DELETE FROM RegisterDetails", cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }
        public bool CheckUserAuthontication(string username, string password)
        {
            int temp = 0;

            cnn = new SqlConnection(connetionString);
            cnn.Open();
            com = new SqlCommand("Select count(*) from UserLogin Where Username=@Username and Password=@Password", cnn);
            com.Parameters.AddWithValue("Username", username);
            com.Parameters.AddWithValue("Password", password);
            temp = (int)com.ExecuteScalar();
            cnn.Close();

            if (temp == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}

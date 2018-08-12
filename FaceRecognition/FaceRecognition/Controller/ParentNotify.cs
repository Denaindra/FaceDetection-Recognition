using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognition.Controller
{
   public class ParentNotify
   {
      
       private static ParentNotify instants = new ParentNotify();
       private TimeHelper time = new TimeHelper();
       private DateHelper date = new DateHelper();


       public ParentNotify() { 
       
       }
       public void SendMessage(string parentmail,DateTime currentTime) {

           try
           {
               MailMessage mail = new MailMessage("thisarafyp@gmail.com", parentmail, "School Attendence", " Your child has arrived at the class on "+ currentTime);
               SmtpClient client = new SmtpClient("smtp.gmail.com");
               client.Port = 587;
               client.Credentials = new System.Net.NetworkCredential("thisarafyp@gmail.com", "thisara123");
               client.EnableSsl = true;
               client.Send(mail);
           }
           catch (Exception ex)
           {
               string a = ex.ToString();
           }
       }
       public static ParentNotify getinstances()
       {
           return instants;
       }

 
   }
}

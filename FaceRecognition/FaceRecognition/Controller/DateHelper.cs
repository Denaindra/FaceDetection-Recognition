using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognition.Controller
{
    public class DateHelper
    {
        static private DateHelper instance=new DateHelper();
        private DateTime today;
        private string date;
        
        public DateHelper() {
             today = DateTime.Now;
             date = today.ToString("yyyy-MM-dd");
        }
        public static DateHelper getinstance() {
            return instance;
        }
        public DateTime Convert2Date(){
            return today = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
         }
        public string getDatenow() {
            return date;
        }
       
    }
}

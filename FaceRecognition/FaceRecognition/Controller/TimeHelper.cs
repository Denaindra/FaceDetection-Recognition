using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognition.Controller
{
    public class TimeHelper
    {
        private DateTime currentTime;
        private string time;
        static private TimeHelper insTime = new TimeHelper();
        public TimeHelper() { 
        
        }
        public DateTime getCurrentTime() {
            time = DateTime.Now.ToString("h:mm:ss");
            return currentTime = DateTime.ParseExact(time,"h:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
        }
        public static TimeHelper getInstances() {
            return insTime;
        }
    }
}

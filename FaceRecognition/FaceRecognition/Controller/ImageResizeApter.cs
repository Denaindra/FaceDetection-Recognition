using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognition.Controller
{
    class ImageResizeApter : ImageResizeAdaptee
    {
        public ImageResizeApter() { 
        
        }

        public  Image<Bgr, Byte> ImageResize(Image<Bgr, Byte> ImageFrame)
        {
          Image<Bgr, byte> resizedImage = ImageFrame.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
          return resizedImage;
        }
    }
}

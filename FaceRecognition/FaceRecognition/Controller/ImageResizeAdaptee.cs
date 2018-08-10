using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognition.Controller
{
    interface ImageResizeAdaptee
    {
        Image<Bgr, Byte> ImageResize(Image<Bgr, Byte> ImageFrame);
    }
}

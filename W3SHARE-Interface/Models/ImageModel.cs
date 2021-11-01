using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W3SHARE_Interface.Models
{
    public class ImageModel
    {
        public int ID { get; set; }
        public string  Geolocation { get; set; }
        public string Tags { get; set; }
        public DateTime CaptureDate { get; set; }
        public string CapturedBy { get; set; }
        public string ImageURL { get; set; }
        public string User { get; set; }

    }
}

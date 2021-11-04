using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using W3SHARE_Interface.Models;

namespace W3SHARE_Interface.Pages.User
{
    public partial class Feed
    {
        public IEnumerable<ImageDTO> ImageList { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadImages();
            return base.OnInitializedAsync();
        }

        private void LoadImages()
        {

            ImageDTO I_1 = new ImageDTO
            {
                ID = 1,
                Geolocation = " Potchefstroom ",
                Tags = "#Nature #LoveLife",
                CaptureDate = new DateTime(1980, 10, 5),
                CapturedBy = "Janco",
                ImageURL = @"DemoData/1.png"
            };

            ImageDTO I_2 = new ImageDTO
            {
                ID = 2,
                Geolocation = " Klerksdorp ",
                Tags = "#Nature #LoveLife",
                CaptureDate = new DateTime(1980, 10, 5),
                CapturedBy = "Janco",
                ImageURL = @"DemoData/2.png"
            };

            ImageDTO I_3 = new ImageDTO
            {
                ID = 3,
                Geolocation = " Parys ",
                Tags = "#Nature #LoveLife",
                CaptureDate = new DateTime(1980, 10, 5),
                CapturedBy = "Janco",
                ImageURL = "DemoData/3.png"
            };

            ImageDTO I_4 = new ImageDTO
            {
                ID = 3,
                Geolocation = " Parys ",
                Tags = "#Nature #LoveLife",
                CaptureDate = new DateTime(1980, 10, 5),
                CapturedBy = "Janco",
                ImageURL = "DemoData/3.png"
            };


            ImageList = new List<ImageDTO> { I_1 , I_2 ,I_3,I_4 };
        }
    }
}

    

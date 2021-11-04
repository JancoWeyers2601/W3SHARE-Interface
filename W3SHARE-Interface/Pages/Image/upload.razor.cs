using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using W3SHARE_Interface.Models;
using W3SHARE_Interface.Repo;

namespace W3SHARE_Interface.Pages.Image
{
    public partial class Upload
    {
        public string  CapturedBy { get; set; }
        public string Tags { get; set; }
        public string Url { get; set; }

        public void  UploadBTN()
        {

            ImageRepo imageRepo = new ImageRepo();

            ImageDTO image = new ImageDTO();

            image.CaptureDate = DateTime.Now;
            image.CapturedBy = this.CapturedBy;
            image.Tags = this.Tags;
            image.ImageURL = this.Url;

            imageRepo.AddImage(image);

            NavManager.NavigateTo("/Feed");
        }
    }
}

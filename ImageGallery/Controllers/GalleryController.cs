using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ImageGallery.Models;
using SimImageGallery.Models;

namespace ImageGallery.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var hikingImageTags = new List<ImageTag>();
            var cityImageTags = new List<ImageTag>();

            var tag1 = new ImageTag()
            {
                Description = "Adventure",
                Id = 0
            };

            var tag2 = new ImageTag()
            {
                Description = "Urban",
                Id = 1
            };

            var tag3 = new ImageTag()
            {
                Description = "Providence",
                Id = 2
            };

            hikingImageTags.Add(tag1);
            cityImageTags.AddRange(new List<ImageTag> { tag2, tag3 });

            var imageList = new List<GalleryImage>()
            {
                new GalleryImage()
                {
                    Title = "Hiking Trip",
                    Url = "https://backroads-web.s3.amazonaws.com/images/search/thumbnail/french-italian-alps-walking-hiking-tour.jpg",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },

                new GalleryImage()
                {
                    Title = "On the Trail",
                    Url = "https://gunnewsdaily.com/wp-content/uploads/2017/06/trail.jpg",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },

                new GalleryImage()
                {
                    Title = "Downtown",
                    Url = "https://www.omnihotels.com/-/media/images/hotels/pvddtn/activities/pvddtn-omni-providence-cityscape.jpg?h=660&la=en&w=1170",
                    Created = DateTime.Now,
                    Tags = cityImageTags
                }
            };

            var model = new GalleryIndexModel()
            {
                Images = imageList,
                SearchQuery = ""
            };
            return View(model);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using SimImageGallery.Data;
using SimImageGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleImageGallery.Services
{
    public class ImageService : IImage
    {
        private readonly SimImageGalleryDbContext _ctx;

        public ImageService(SimImageGalleryDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<GalleryImage> GetAll()
        {
            return _ctx.GalleryImages.Include(img => img.Tags);
        }
                
        public IEnumerable<GalleryImage> GetWithTag(string tag)
        {
            return GetAll().Where(img => img.Tags.Any(t => t.Description == tag));
        }

        public GalleryImage GetById(int id)
        {
            return _ctx.GalleryImages.Find(id);
        }
    }
}

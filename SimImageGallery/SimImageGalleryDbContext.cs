using System;
using Microsoft.EntityFrameworkCore;
using SimImageGallery.Models;

namespace SimImageGallery.Data
{
    public class SimImageGalleryDbContext : DbContext
    {
        public SimImageGalleryDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }
    }
}

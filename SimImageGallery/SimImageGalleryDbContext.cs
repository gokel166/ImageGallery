using System;
using Microsoft.EntityFrameworkCore;

namespace SimImageGallery.Data
{
    public class SimImageGalleryDbContext : DbContext
    {
        public SimImageGalleryDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}

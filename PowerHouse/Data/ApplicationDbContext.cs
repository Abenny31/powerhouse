using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PowerHouse.Models;

namespace PowerHouse.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ImagesModel> imagesDbSet { get; set; }

        public DbSet<FormData> formDataDbSet { get; set; }


    }
}
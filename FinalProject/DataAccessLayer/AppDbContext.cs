using FinalProject.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
               
        }

        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<SliderBg> SliderBg { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<FirstSliderHome> FirstSliderHome { get; set; }
        public DbSet<NoticeLeft> NoticeLeft { get; set; }
        public DbSet<NoticeRight> NoticeRight { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<AllCourse> AllCourse { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}

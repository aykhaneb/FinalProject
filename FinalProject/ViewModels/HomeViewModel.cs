using FinalProject.DataAccessLayer.Entities;

namespace FinalProject.ViewModels
{
    public class HomeViewModel
    {
        public List<FirstSliderHome> FirstSliderHome { get; set; }
        public List<NoticeLeft> NoticeLeft { get; set; }
        public List<NoticeRight> NoticeRights { get; set; }
        public List<Course> Courses { get; set; }
        public List<AllCourse> AllCourses { get; set; }
        public List<Event> Events { get; set; }
        public List<Carousel> Carousels { get; set; }
        public List<Blog> Blogs { get; set; }

    }
}

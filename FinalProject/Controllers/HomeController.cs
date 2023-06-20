using FinalProject.DataAccessLayer;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var firstsliders = _dbContext.FirstSliderHome.ToList();
            var noticelefts = _dbContext.NoticeLeft.ToList();
            var noticerights = _dbContext.NoticeRight.ToList();
            var courses = _dbContext.Course.ToList();
            var allcourses = _dbContext.AllCourse.ToList();
            var events = _dbContext.Events.ToList();
            var carousels = _dbContext.Carousels.ToList();
            var blogs = _dbContext.Blogs.ToList();
            var homeViewModel = new HomeViewModel
            {
                FirstSliderHome = firstsliders,
                NoticeLeft = noticelefts,
                NoticeRights = noticerights,
                Courses = courses,
                AllCourses = allcourses,
                Events = events,
                Carousels = carousels,
                Blogs = blogs,
            };
            return View(homeViewModel);
        }
    }
}

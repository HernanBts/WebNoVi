using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNoVi.Models;
using WebNoVi.ModelView;

namespace WebNoVi.Controllers
{
    public class HomeController : Controller
    {
        private CenoviContext db = new CenoviContext();

        public ActionResult Index()
        {
            
            IndexSPAView indexSPAView = new IndexSPAView();

            List<Story> storiesList= new List<Story>();
            var stories = db.Stories.ToList();
            foreach (var story in stories)
            {
                var storyView = new Story
                {
                    Title = story.Title,
                    Description = story.Description,
                    Body = story.Body,
                    Date = story.Date,
                    Hour = story.Hour,
                    Comment = story.Comment,
                    StoryId = story.StoryId
                };
                storiesList.Add(storyView);
            }

            List<New> newsList = new List<New>();
            var news = db.News.ToList();
            foreach (var item in news)
            {
                var newView = new New
                {
                    Title = item.Title,
                    Resume = item.Resume,
                    Body = item.Body,
                    Date = item.Date,
                    Hour = item.Hour,
                    Image = item.Image,
                    NewId = item.NewId
                };
                newsList.Add(newView);
            }

            List<Tool> toolsList = new List<Tool>();
            var tools = db.Tools.ToList();
            foreach (var item in tools)
            {
                var toolView = new Tool
                {
                    Title = item.Title,
                    Description = item.Description,
                    Link = item.Link
                };
                toolsList.Add(toolView);
            }
            indexSPAView.Stories = storiesList;
            indexSPAView.News = newsList;
            indexSPAView.Tools = toolsList;

            return View(indexSPAView);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
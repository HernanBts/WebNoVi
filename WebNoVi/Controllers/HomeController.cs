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
        private int sizeOfListsPulls = 3;

        public ActionResult Index()
        {
            int cn = 0;
            IndexSPAView indexSPAView = new IndexSPAView();
            
            List<Service> services = new List<Service>();
            var service = db.Services.ToList();
            foreach (var item in service)
            {
                var servicesSiew = new Service
                {
                    ServiceId = item.ServiceId,
                    Title = item.Title,
                    Resume = item.Resume,
                    Image = item.Image
                };
                services.Add(servicesSiew);
            }

            List<Event> events = new List<Event>();
            var @event = db.Events.OrderByDescending(i => i.Date).ToList();
            foreach (var item in @event)
            {
                if(sizeOfListsPulls == cn)
                {
                    break;
                }
                var eventView = new Event
                {
                    EventId = item.EventId,
                    Title = item.Title,
                    Date = item.Date,
                    Hour = item.Hour,
                    Description = item.Description,
                    Image = item.Image
                };
                events.Add(eventView);
                cn++;
            }

            cn = 0;
            List<Story> stories= new List<Story>();
            var story = db.Stories.OrderByDescending(i => i.Date).ToList();
            foreach (var item in story)
            {
                if (sizeOfListsPulls == cn)
                {
                    break;
                }
                var storyView = new Story
                {
                    Title = item.Title,
                    Description = item.Description,
                    Body = item.Body,
                    Date = item.Date,
                    Hour = item.Hour,
                    Comment = item.Comment,
                    StoryId = item.StoryId
                };
                stories.Add(storyView);
                cn++;
            }

            cn = 0;
            List<New> news = new List<New>();
            var @new = db.News.OrderByDescending(i => i.Date).ToList();
            foreach (var item in @new)
            {
                if (sizeOfListsPulls == cn)
                {
                    break;
                }
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
                news.Add(newView);
                cn++;
            }

            cn = 0;
            List<Tool> tools = new List<Tool>();
            var tool = db.Tools.ToList();
            
            foreach (var item in tool)
            {
                var toolView = new Tool
                {
                    ToolId = item.ToolId,
                    Title = item.Title,
                    Description = item.Description,
                    Link = item.Link
                };
                tools.Add(toolView);
            }

            indexSPAView.Services = services;
            indexSPAView.Events = events;
            indexSPAView.Stories = stories;
            indexSPAView.News = news;
            indexSPAView.Tools = tools;

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
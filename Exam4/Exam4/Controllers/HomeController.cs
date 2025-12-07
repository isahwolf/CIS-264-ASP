using System.Diagnostics;
using System.Threading.Tasks;
using Exam4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exam4.Controllers
{
    public class HomeController : Controller
    {
        TaskManagerContext db;

        public HomeController(TaskManagerContext context)
        {
            db = context;

        }


        public IActionResult Index()
        {
            var model = new TaskViewModel
            {
                TaskItems = db.TaskItems
                .OrderBy(t => t.Priority)
                .ToList()
            };

            return View(model);
        }

        public IActionResult Add(TaskItem task)
        {
            try
            {
                if (task.Id == 0)
                {
                    db.Add(task);
                }
                else
                {
                    TaskItem t = db.TaskItems.FirstOrDefault(t => t.Id == task.Id);
                    if (t != null)
                    {
                        t.Description = task.Description;
                        t.Priority = task.Priority;
                        t.Completed = task.Completed;
                    }
                }
                db.SaveChanges();
            }
            catch 
            {
                TempData["message"] = "Enter task and priority";
            }

            var model = new TaskViewModel
            {
                TaskItems = db.TaskItems
                .OrderBy(t => t.Priority)
                .ToList()
            };

            return View("Index", model);
        }

        public IActionResult Complete(int id)
        {
            TaskItem task = db.TaskItems.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.Completed = DateTime.Now;
                db.SaveChanges();
            }
            var model = new TaskViewModel
            {
                TaskItems = db.TaskItems
                .OrderBy(t => t.Priority)
                .ToList()
            };

            return View("Index", model);
        }

        public IActionResult DeleteComplete(int id)
        {
            var completedTasks = db.TaskItems.Where(t => t.Completed.HasValue).ToList();

            db.TaskItems.RemoveRange(completedTasks);
            db.SaveChanges();

            var model = new TaskViewModel
            {
                TaskItems = db.TaskItems
                .OrderBy(t => t.Priority)
                .ToList()
            };

            return View("Index", model);
        }
    }
}

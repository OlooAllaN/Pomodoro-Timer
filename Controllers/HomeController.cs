using Microsoft.AspNetCore.Mvc;
using Pomodoro.UiServices;

namespace Pomodoro.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Responsible for accessing data in our service layer 
        /// </summary>
        private readonly IMakePomodoroUiService lazyMakePomdoroTimerUiService;

        /// <summary>
        /// A home controller constructor for communicating with our 
        /// data access layer through constructor injection. 
        /// </summary>
        /// <param name="lazyMakePomdoroTimerUiService"></param>
        public HomeController(IMakePomodoroUiService lazyMakePomdoroTimerUiService)
        {
            this.lazyMakePomdoroTimerUiService = lazyMakePomdoroTimerUiService;
        }

        /// <summary>
        /// Gets application index page.
        /// </summary>
        /// <returns></returns>
        public ViewResult Index(int? userId)
        {
            var model = lazyMakePomdoroTimerUiService.GetPomdoroTimerView(userId);
            return View(model);
        }

        /// <summary>
        /// Gets application home page.
        /// </summary>
        /// <param name="userId"> The user Id.</param>
        /// <returns></returns>
        public JsonResult CreateTask(int userId, string taskText)
        {
            var task = lazyMakePomdoroTimerUiService.CreateTask(userId, taskText);

            return new JsonResult(new
            {
                Data = new
                {
                    task
                }
            });
        }

        /// <summary>
        /// Gets application home page.
        /// </summary>
        /// <param name="userName"> The new user name.</param>
        /// <returns></returns>
        public JsonResult CreateUser(string userName)
        {
            var user = lazyMakePomdoroTimerUiService.CreateUser(userName);
            return new JsonResult(new
            {
                Data = new
                {
                    newUserId = user.Id,
                    newUserName = user.Name
                }
            });
        }

        /// <summary>
        /// Gets application home page.
        /// </summary>
        /// <param name="userId"> The user Id.</param>
        /// <returns></returns>
        public PartialViewResult MakePomodoroTimer(string userName)
        {
            var user = lazyMakePomdoroTimerUiService.CreateUser(userName);
            var model = lazyMakePomdoroTimerUiService.GetPomdoroTimerView(user.Id);
            return PartialView("_PomodoroTimer", model);
        }

    }
}

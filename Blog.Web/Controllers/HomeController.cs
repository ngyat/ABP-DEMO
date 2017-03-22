using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Blog.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BlogControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}
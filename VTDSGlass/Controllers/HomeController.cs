using Glass.Mapper.Sc;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VTDSGlass.Controllers
{
    public class HomeController : Controller
    {
        private readonly RenderingContext _renderingContext;

        public HomeController()
        {
            _renderingContext = RenderingContext.Current;
        }
        // GET: Home
        public ActionResult Index()
        {
            var glassModel = _renderingContext.Rendering.Item.GlassCast<Template1>();
            var vm = new Models.Template1ViewModel();
            vm.Title = glassModel.Title;
            return View(vm);
        }
    }
}
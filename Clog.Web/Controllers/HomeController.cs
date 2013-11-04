using Clog.Data;
using Clog.Data.Contracts;
using Clog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clog.Web.Controllers
{
    public class HomeController : BaseController
    {
		public HomeController(IClogUnitOfWork uow)
		{
			Uow = uow;
		}

        public ActionResult Index()
        {
			var logs = Uow.Logs.GetAll();
			
			return View(logs);
        }
    }
}

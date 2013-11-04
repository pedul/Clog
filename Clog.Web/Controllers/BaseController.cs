using Clog.Data.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clog.Web.Controllers
{
    public abstract class BaseController : Controller
    {
		protected IClogUnitOfWork Uow { get; set; }
    }
}

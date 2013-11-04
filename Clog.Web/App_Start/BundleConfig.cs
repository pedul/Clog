using System.Web;
using System.Web.Optimization;

namespace Clog.Web
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new StyleBundle("~/bundles/css").Include(
						"~/Content/site.css",
						"~/Content/bootstrap/bootstrap.css",
						"~/Context/bootstrap/bootstrap-theme.css"));

			bundles.Add(new ScriptBundle("~/bundles/js").Include(
						"~/Scripts/jquery-{version}.js",
						"~/Scripts/bootstrap.js"));
		}
	}
}
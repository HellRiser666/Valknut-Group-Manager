using System.Web;
using System.Web.Optimization;

namespace Wesley.ValknutGroupManager.Start
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new StyleBundle("~/bundles/bootstrap").Include(
                        "~/Content/css/bootstrap-theme.css",
                        "~/Content/css/bootstrap-theme.min.css",
                        "~/Content/css/bootstrap.css",
                        "~/Content/css/bootstrap.min.css",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                        "~/Scripts/custom.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                        "~/Content/Site.css"));

        }
    }
}
using System.Web;
using System.Web.Optimization;

namespace wmcb.web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                "~/Scripts/underscore-min.js",
                "~/Scripts/angular.min.js",
                "~/Scripts/angular-sanitize.min.js",
                "~/Scripts/angular/controllers/Controller.js"
                , "~/Scripts/angular/services/wmcbService.js"));
            bundles.Add(new ScriptBundle("~/bundles/index").Include(
                        "~/Scripts/mustache.js",
                        "~/Scripts/wmbc/index.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            bundles.Add(new ScriptBundle("~/bundles/gallery").Include(
                 "~/Scripts/bootstrap-image-gallery.min.js",
               "~/Scripts/wmcb/gallery.js"
               ));

            bundles.Add(new StyleBundle("~/Content/css/gallery").Include(
                    "~/Content/ekko-lightbox.min.css"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/bootsnipp.css"));
           
        }
    }
}

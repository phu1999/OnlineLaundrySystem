using System.Web;
using System.Web.Optimization;

namespace OnlineLaundrySystem
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            #region Template Desing

            bundles.Add(new ScriptBundle("~/template/js").Include(
                    "~/Scripts/jquery-2.2.3.min.js",
                    "~/Scripts/responsiveslides.min.js",
                    "~/Scripts/move-top.js",
                    "~/Scripts/easing.js",
                    "~/Scripts/SmoothScroll.min.js",
                    "~/Scripts/jquery.swipebox.min.js",
                    "~/Scripts/jquery.adipoli.min.js",
                    "~/Scripts/counter.js",
                    "~/Scripts/jquery-ui.js",
                    "~/Scripts/owl.carousel.js",
                    "~/Scripts/bootstrap.js"
                    ));

            bundles.Add(new StyleBundle("~/template/css").Include(
                    "~/Content/css/bootstrap.css",
                    "~/Content/css/swipebox.css",
                    "~/Content/css/style.css",
                    "~/Content/css/fontawesome-all.min.css",
                    "~/Content/css/jquery-ui.css",
                    "~/Content/css/owl.carousel.css"
                    ));

            #endregion
        }
    }
}

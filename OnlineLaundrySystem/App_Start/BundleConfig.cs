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


            // Bundle for home template
            bundles.Add(new ScriptBundle("~/Content/template/js").Include(
                    "~/Content/template/js/all.min.js",
                    "~/Content/template/js/jquery-2.2.3.min.js",
                    "~/Content/template/js/responsiveslides.min.js",
                    "~/Content/template/js/move-top.js",
                    "~/Content/template/js/easing.js",
                    "~/Content/template/js/SmoothScroll.min.js",
                    "~/Content/template/js/jquery.swipebox.min.js",
                    "~/Content/template/js/jquery.adipoli.min.js",
                    "~/Content/template/js/counter.js",
                    "~/Content/template/js/jquery-ui.js",
                    "~/Content/template/js/owl.carousel.js",
                    "~/Content/template/js/bootstrap.js",
                    "~/Content/template/js/fontawesome.min.js",
                    "~/Content/template/js/popper.js"
                    ));
            bundles.Add(new StyleBundle("~/Content/template/css").Include(
                    "~/Content/template/css/bootstrap.css",
                    "~/Content/template/css/swipebox.css",
                    "~/Content/template/css/style.css",
                    "~/Content/template/css/fontawesome.min.css",
                    "~/Content/template/css/jquery-ui.css",
                    "~/Content/template/css/owl.carousel.css",
                    "~/Content/template/css/counter.css",
                    "~/Content/template/css/all.min.css"
                    ));
            // Bundle for admin template
            bundles.Add(new ScriptBundle("~/Content/admin-template/js").Include(
                    "~/Content/admin-template/js/scripts.js",
                    "~/Content/admin-template/js/fontawesome.min.js"
                    ));
            bundles.Add(new StyleBundle("~/Content/admin-template/css").Include(
                    "~/Content/admin-template/css/fontawesome.min.css",
                    "~/Content/admin-template/css/styles.css"
                    ));
        }
    }
}

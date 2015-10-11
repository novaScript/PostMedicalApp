using System.Web;
using System.Web.Optimization;

namespace PostMedicalAPP
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/extras").Include(
                      "~/Scripts/isotope.pkgd.min.js",
                      "~/Scripts/owl.carousel.min.js",
                      "~/Scripts/wow.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/ccs/animate.css",
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/flexslider.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/main.css",
                      "~/Content/css/owl.carousel.css",
                      "~/Content/css/owl.theme.css",
                      "~/Content/css/owl.transitions.css",
                      "~/Content/css/style-postmedical.css"));
            BundleTable.EnableOptimizations = false;
        }
    }
}

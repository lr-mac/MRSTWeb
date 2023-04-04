using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;

namespace Proiect_TWEB.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
               bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                                    "~/Content/css/bootstrap.min.css", new CssRewriteUrlTransform()));

               bundles.Add(new StyleBundle("~/bundles/icons/css").Include(
                                    "~/Content/css/icons.min.css", new CssRewriteUrlTransform()));

               bundles.Add(new StyleBundle("~/bundles/app/css").Include(
                                    "~/Content/css/app.min.css", new CssRewriteUrlTransform()));

               bundles.Add(new ScriptBundle("~/bundles/vendor/js").Include(
                                    "~/Content/js/vendor.min.js"));

               bundles.Add(new ScriptBundle("~/bundles/jquery-knob/jquery/js").Include(
                                    "~/Content/libs/jquery-knob/jquery.knob.min.js"));

               bundles.Add(new ScriptBundle("~/bundles/peity/jquery/js").Include(
                                    "~/Content/libs/peity/jquery.peity.min.js"));

               bundles.Add(new ScriptBundle("~/bundles/jquery-sparkline/js").Include(
                                    "~/Content/libs/jquery-sparkline/jquery.sparkline.min.js"));

               bundles.Add(new ScriptBundle("~/bundles/dashboard/js").Include(
                                    "~/Content/js/pages/dashboard-1.init.js"));

               bundles.Add(new ScriptBundle("~/bundles/app/js").Include(
                                    "~/Content/js/app.min.js"));
          }
    }
}

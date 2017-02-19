﻿using System.Web.Optimization;

namespace STIFE.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/app/jquery.mb.YTPlayer.js",
                "~/Scripts/app/jquery.easing.min.js",
                "~/Scripts/app/custom.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.unobtrusive*",
                "~/Scripts/jquery.validate*"));

            // Verwenden Sie die Entwicklungsversion von Modernizr zum Entwickeln und Erweitern Ihrer Kenntnisse. Wenn Sie dann
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/Content/css/bootstrap.css",
                 "~/Content/css/bootstrap-custom.css",
                 "~/Content/css/Site.css"));

#if DEBUG
            BundleTable.EnableOptimizations = false;
#else
                        BundleTable.EnableOptimizations = true;
#endif
        }
    }
}
﻿using System.Web;
using System.Web.Optimization;

namespace ContactWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/js/lib/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/js/lib/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                            "~/js/lib/jquery.dataTables.min.js",
                            "~/js/lib/dataTables.bootstrap4.min.js",
                            "~/js/lib/dataTables.colReorder.min.js"));

          
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootstrap.min.css",
                      "~/css/dataTables.bootstrap4.min.css",
                      "~/css/dataTables.colReorder.min.js",
                      "~/css/site.css"));
        }
    }
}

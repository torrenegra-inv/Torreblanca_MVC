using System.Web.Optimization;

namespace SimpleBlog
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/admin/styles")
                .Include("~/Content/Styles/bootstrap.css")
                .Include("~/Content/Styles/Admin.css"));

            bundles.Add(new StyleBundle("~/styles")
                .Include("~/Content/Styles/bootstrap.css")
                .Include("~/Content/Styles/Site.css"));

            bundles.Add(new StyleBundle("~/admin/scripts")
                .Include("~/Scripts/jquery-2.1.4.js")
                .Include("~/Scripts/jquery.validate.js")
                .Include("~/Scripts/jquery.validate.unobtrusive.js")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/areas/Admin/Scripts/Forms.js"));

            bundles.Add(new StyleBundle("~/scripts")
               .Include("~/Scripts/jquery-2.1.4.js")
               .Include("~/Scripts/jquery.validate.js")
               .Include("~/Scripts/jquery.validate.unobtrusive.js")
               .Include("~/Scripts/bootstrap.js"));
        }
    }
}
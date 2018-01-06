using System.Web;
using System.Web.Optimization;

namespace Materialize
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;
            //Custom bundles.
            bundles.Add(new ScriptBundle("~/Scripts/js").Include("~/Scripts/*.js"));
            //Order of the script bundles call.
            var ordemScript = new BundleFileSetOrdering("meuScript");
            ordemScript.Files.Add("jquery-3.2.1.min.js");
            ordemScript.Files.Add("materialize.min.js");
            bundles.FileSetOrderList.Insert(0, ordemScript);

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/*.css"));
            //Order of the script bundles call.
            var ordemCss = new BundleFileSetOrdering("meuScript");
            ordemCss.Files.Add("materialize.min.css");
            ordemCss.Files.Add("comum.css");
            bundles.FileSetOrderList.Insert(0, ordemCss);
        }
    }
}

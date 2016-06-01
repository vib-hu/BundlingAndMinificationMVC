using System.Web;
using System.Web.Optimization;

namespace BundlingAnndMinificiation.App_Start
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundle/jquery").
                Include("~/Scripts/jquery-{version}.js").
                Include("~/Scripts/bootstrap.js"));
            BundleTable.EnableOptimizations = true;
        }
    }
}
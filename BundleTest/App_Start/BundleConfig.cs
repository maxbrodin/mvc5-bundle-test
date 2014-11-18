using System.Web.Optimization;

namespace BundleTest
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();            
            
            bundles.Add(new ScriptBundle("~/bundles/library")
                .IncludeDirectory("~/Scripts/Libraries", "*.js", true));
        }
    }
}


using System.IO;
using System.Reflection;
using JSIL;
using JSIL.Internal;
using SL2JS.Proxies;

namespace SL2JS
{
    public class SilverlightAssemblyResolver : AssemblyResolver
    {
        public SilverlightAssemblyResolver(string mainAssemblyPath)
            : base(new[] { mainAssemblyPath, "C:\\Program Files\\Microsoft Silverlight\\4.0.60310.0" })
        {
            this.AddSearchDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }
    }

}
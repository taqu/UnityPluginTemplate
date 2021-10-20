using System.Runtime.InteropServices;

namespace Plugin01
{
    public class Plugin01
    {
#if UNITY_IPHONE
        public const string PluginName = "__Internal";
#else
#   if DEBUG
        public const string PluginName = "plugin01d";
#   else
        public const string PluginName = "plugin01";
#   endif
#endif

        [DllImport(PluginName)]
        public static extern int get_value();
    }
}

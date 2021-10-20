using System.Runtime.InteropServices;

namespace Plugin00
{
    public class Plugin00
    {
#if UNITY_IPHONE
        public const string PluginName = "__Internal";
#else
#   if DEBUG
        public const string PluginName = "plugin00d";
#   else
        public const string PluginName = "plugin00";
#   endif
#endif

        [DllImport(PluginName)]
        public static extern int get_value();
    }
}
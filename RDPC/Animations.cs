using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace RDPC
{
    internal static class Animations
    {

        public static String[] LoadingArr = new String[] { "Loading", "Loading.", "Loading..", "Loading..." };
        public static String[] ConnectingArr = new String[] { "Connecting", "Connecting.", "Connecting..", "Connecting..." };
        public static String[] SignOffArr = new String[] { "Logging Off in 3.", "Logging Off in 2..", "Logging Off in 1...", "Logging Off!" };
        public static String[] ShutdownArr = new String[] { "Shutdown in 3.", "Shutdown in 2..", "Shutdown in 1...", "Shutdown!" };
        public static String[] RebootArr = new String[] { "Reboot in 3.", "Reboot in 2..", "Reboot in 1...", "Reboot!" };
        public static string RDPConfig = "screen mode id:i:2\r\nuse multimon:i:0\r\ndesktopwidth:i:800\r\ndesktopheight:i:600\r\nsession bpp:i:32\r\nwinposstr:s:0,3,0,0,800,600\r\ncompression:i:1\r\nkeyboardhook:i:2\r\naudiocapturemode:i:0\r\nvideoplaybackmode:i:1\r\nconnection type:i:7\r\nnetworkautodetect:i:1\r\nbandwidthautodetect:i:1\r\ndisplayconnectionbar:i:1\r\nusername:s:NewUser\r\nenableworkspacereconnect:i:0\r\ndisable wallpaper:i:0\r\nallow font smoothing:i:0\r\nallow desktop composition:i:0\r\ndisable full window drag:i:1\r\ndisable menu anims:i:1\r\ndisable themes:i:0\r\ndisable cursor setting:i:0\r\nbitmapcachepersistenable:i:1\r\nfull address:s:1232\r\naudiomode:i:0\r\nredirectprinters:i:1\r\nredirectcomports:i:0\r\nredirectsmartcards:i:1\r\nredirectclipboard:i:1\r\nredirectposdevices:i:0\r\nautoreconnection enabled:i:1\r\nauthentication level:i:2\r\nprompt for credentials:i:0\r\nnegotiate security layer:i:1\r\nremoteapplicationmode:i:0\r\nalternate shell:s:\r\nshell working directory:s:\r\ngatewayhostname:s:\r\ngatewayusagemethod:i:4\r\ngatewaycredentialssource:i:4\r\ngatewayprofileusagemethod:i:0\r\npromptcredentialonce:i:0\r\ngatewaybrokeringtype:i:0\r\nuse redirection server name:i:0\r\nrdgiskdcproxy:i:0\r\nkdcproxyname:s:\r\n";

        public static void Shake(Form form) {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 2;
            for (int i = 0; i < 10; i++) {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }
    }
}

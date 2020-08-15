using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AscendingNET
{
    static class Program
    {

        static string _releaseNotes =
        @"v0.1 Initial Addition Set.
        Next Steps:
            add menu form for level & type selection
            profiles & exp bar
            answer acceptance & reward
        Next Next Steps:
            convert to ASP
            add multiplayer
            convert to Java/Javascript
";


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMath());
        }
    }
}

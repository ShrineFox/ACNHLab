using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACNHLab
{
    static class Program
    {
        public static Status status;
        public static List<string> processList = new List<string>()
            {

            };
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Treeview.SetupImageList();
            Application.Run(new ACNHLab());
        }
    }
}

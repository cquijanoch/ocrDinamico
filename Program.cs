using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gestures
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new MainForm());
        }
    }
}

using System;
using System.Threading;
using System.Windows.Forms;

namespace SimpleTrayRunner
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Prevent Multiple Instances
            var mutex = new Mutex(true, "SimpleTrayRunnerInstance", out bool createdNew);
            if (!createdNew) { return; }
            GC.KeepAlive(mutex);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}

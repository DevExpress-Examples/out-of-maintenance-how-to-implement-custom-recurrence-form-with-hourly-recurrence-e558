// Developer Express Code Central Example:
// How to implement custom Recurrence form with hourly recurrence
// 
// This sample illustrates how to create custom Recurrence form, which contains
// Hourly recurrence pattern
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E558

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
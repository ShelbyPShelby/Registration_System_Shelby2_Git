//Shelby Shelby
//Date:4/2/19
//Dr.Tyson McMillan
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_System_Shelby
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
            Application.Run(new Teacher());
            Application.Run(new Section());
            Application.Run(new Registration());
            Application.Run(new Student_Update_Form());
        }
    }
}

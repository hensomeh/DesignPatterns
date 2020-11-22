using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace A20_Ex03_Shmuel_204286793_Hen_313468654
{
     // $G$ THE-001 (-21) your grade on diagrams document - 79. please see comments inside the document. 50% of your grade).
     public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}

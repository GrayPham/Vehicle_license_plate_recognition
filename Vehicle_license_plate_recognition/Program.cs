using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_license_plate_recognition.OfficeStaff;
using Vehicle_license_plate_recognition.OfficeStaff.Customer;

namespace Vehicle_license_plate_recognition
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormForgotPassword());
        }
    }
}

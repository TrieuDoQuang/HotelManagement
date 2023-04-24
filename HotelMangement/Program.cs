using HotelMangement.DanhMucForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMangement
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
            Application.Run(new FormLogin());
            //Application.Run(new FormRoom());
            //Application.Run(new FormBookingDetail());
            //Application.Run(new FormUserDetail());
            //Application.Run(new FormRole());
            //Application.Run(new FormUser());
        }
    }
}

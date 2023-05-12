using HotelMangement.DanhMucForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelMangement.Interface;

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
            //Application.Run(new FormLogin());
            //Application.Run(new FormRoom());
            //Application.Run(new FormBookingDetail());
            Application.Run(new FormUserDetail());
            //Application.Run(new FormUser());
            //Application.Run(new AdminInterface());
            //Application.Run(new CustomerInterface());
            //Application.Run(new FormService());
            //Application.Run(new FormProduct());

        }
    }
}

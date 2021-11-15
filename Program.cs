using Management_Hotel.View.ViewManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Management_Hotel.View;
using Management_Hotel.View.ViewReceptionist;
using Management_Hotel.View.ViewReceptionist.ViewFormOrder;
using Management_Hotel.View.ViewReceptionist.ViewFormOrderFood;
using Management_Hotel.Control;

namespace Management_Hotel
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConnectionController.init();
            Form form = new FormSwapRoom();
            Application.Run(form);
        }
        
    }
}

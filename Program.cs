﻿using Management_Hotel.View.ViewManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Management_Hotel.View;
using Management_Hotel.View.ViewLabourer;
using Management_Hotel.View.ViewReceptionist;
using Management_Hotel.View.ViewReceptionist.ViewFormOrder;
using Management_Hotel.View.ViewReceptionist.ViewFormOrderFood;


namespace Management_Hotel
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormMenuReceptionist());
            Application.Run(new FormLogin());
        }
        
    }
}

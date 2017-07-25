﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TziporahStore
{
    static class Program
    {
        public static ItemsForm Items { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
               [STAThread]
                static void Main()
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

            Items = new ItemsForm();

                    Application.Run(new LoginForm());


               }
        
    }
}

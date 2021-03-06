﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace complex_calculator
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
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit); 
        }
        static void OnProcessExit(object sender, EventArgs e)
        {
            MessageBox.Show("https://github.com/gproduct/c-_calculator/", "GitHub code",
            MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}

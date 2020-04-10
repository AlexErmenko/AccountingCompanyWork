﻿using System;

using UI.Views;

using static System.Windows.Forms.Application;

namespace UI
{
  public static class Program
  {
    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
      EnableVisualStyles();
      SetCompatibleTextRenderingDefault(defaultValue: false);
      Run(mainForm: new Start());
    }
  }
}
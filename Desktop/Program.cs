using System;

using Desktop.Views;

using static System.Windows.Forms.Application;

namespace Desktop
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

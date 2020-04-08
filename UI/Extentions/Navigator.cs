using System;
using System.Windows.Forms;

namespace UI.Extentions
{
  public static class Navigator
  {
    public static void Nav(this Form from, in Form to)
    {
      from.Hide();
      to.Show();
    }
  }
}

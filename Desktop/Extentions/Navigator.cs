using System;
using System.Windows.Forms;

namespace Desktop.Extentions
{
  public static class Navigator
  {
    public static void Nav(this Form from, in Form to)
    {
      from.Hide();
      to.Show();
    }
  }

  public static class ValidationExtention
  {
    public static void Validate(this TextBox textBox,string errorMessage, out string value) => value = string.IsNullOrEmpty(textBox.Text) ? throw new FormatException(errorMessage) : textBox.Text;
  }
}

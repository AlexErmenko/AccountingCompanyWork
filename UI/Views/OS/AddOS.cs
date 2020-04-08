using System;
using System.Windows.Forms;

using UI.Models;

using OperatingSystem = UI.Models.OperatingSystem;

namespace UI.Views.OS
{
  public partial class AddOS : Form
  {
    private readonly SoftwareFirmContext context;

    public AddOS()
    {
      InitializeComponent();
      context = new SoftwareFirmContext();
    }

    private void SaveOsBtn_Click(object sender, EventArgs e)
    {
      string os = textBox1.Text;
      string capacity = textBox2.Text;
      if(string.IsNullOrEmpty(value: os))
      {
        textBox1.Select();
        return;
      }

      context.OperatingSystems.AddAsync(entity: new OperatingSystem
      {
        Name = Name,
        Capacity = capacity
      });
      context.SaveChangesAsync();
      Hide();
    }
  }
}

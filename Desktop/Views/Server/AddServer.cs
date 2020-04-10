using System;
using System.Windows.Forms;

using Castle.Core.Internal;

using UI.Models;

namespace UI.Views.Server
{
  public partial class AddServer : Form
  {
    private readonly SoftwareFirmContext _context;

    public AddServer()
    {
      InitializeComponent();
      _context = new SoftwareFirmContext();
    }

    private void SaveServerBtn_Click(object sender, EventArgs e)
    {
      string serverName = serverNameTextBox.Text;
      if(serverName.IsNullOrEmpty())
      {
        serverNameTextBox.Select();
        return;
      }

      _context.Servers.AddAsync(entity: new Models.Server
      {
        Name = serverName
      });
      _context.SaveChangesAsync();
      Hide();
    }
  }
}

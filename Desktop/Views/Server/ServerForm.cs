using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using Equin.ApplicationFramework;

using Microsoft.EntityFrameworkCore;

using UI.Models;

using static UI.Extentions.Navigator;

namespace UI.Views.Server
{
  /// <summary>
  ///     !TODO: на одном сервере может находиться несколь БД
  /// </summary>
  public partial class ServerForm : Form
  {
    private readonly SoftwareFirmContext _context;

    public ServerForm()
    {
      InitializeComponent();
      _context = new SoftwareFirmContext();
    }

    private async void ServerForm_Load(object sender, EventArgs e) => await Binding();

    private void GoBack_Click(object sender, EventArgs e) => this.Nav(to: new Main());

    private async Task Binding() => serverBindingSource.DataSource =
                                    new BindingListView<Models.Server>(list: await _context.Servers.ToListAsync());

    private async void RemoveServerBtn_Click(object sender, EventArgs e)
    {
      if(ServerGridView.SelectedRows.Count > 0)
      {
        var id = (int)ServerGridView.SelectedRows[index: 0].Cells[index: 0].Value;
        var server = await _context.Servers.FindAsync(id);
        _context.Servers.Remove(entity: server);
        await _context.SaveChangesAsync();
        await Binding();
        ServerGridView.Refresh();
      }
    }

    private async void AddServerBtn_Click(object sender, EventArgs e)
    {
      var form = new AddServer();
      if(form.ShowDialog() == DialogResult.OK)
      {
        await Binding();
        ServerGridView.Refresh();
      }
    }
  }
}

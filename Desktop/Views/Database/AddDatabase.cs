using System;
using System.Windows.Forms;

using Castle.Core.Internal;

using Equin.ApplicationFramework;

using Microsoft.EntityFrameworkCore;

using UI.Models;

namespace Desktop.Views.Database
{
  public partial class AddDatabase : Form
  {
    private readonly SoftwareFirmContext _context;

    public AddDatabase()
    {
      InitializeComponent();
      _context = new SoftwareFirmContext();
    }

    private async void SaveDatabaseBtn_Click(object sender, EventArgs e)
    {
      var databaseName = nameTextBox.Text;
      UI.Models.Server server = ( (ObjectView<UI.Models.Server>)serverBindingSource.Current ).Object;

      if(databaseName.IsNullOrEmpty())
      {
        nameTextBox.Select();
        return;
      }

      var dataBase = new DataBase
      {
        Name = databaseName,
        IdServer = server.Id
      };
      await _context.Databases.AddAsync(entity: dataBase);
      await _context.SaveChangesAsync();
      Hide();
    }

    private async void AddDatabase_Load(object sender, EventArgs e)
    {
      serverBindingSource.DataSource = new BindingListView<UI.Models.Server>(list: await _context.Servers.ToListAsync());
    }
  }
}

using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Equin.ApplicationFramework;

using Microsoft.EntityFrameworkCore;

using UI.Models;

using static UI.Extentions.Navigator;

namespace UI.Views.Database
{
  /// <summary>
  ///     !TODO:Пункт курсового: одной БД могут пользоваться несколько программ
  /// </summary>
  public partial class DatabaseForm : Form
  {
    private readonly SoftwareFirmContext _context;

    public DatabaseForm()
    {
      InitializeComponent();
      _context = new SoftwareFirmContext();
    }

    private async Task Binding() => dataBaseBindingSource.DataSource = new BindingListView<DataBase>(list: await _context.Databases.ToListAsync());

    private async void dataBaseBindingSource_PositionChanged(object sender, EventArgs e)
    {
      var current = ( (ObjectView<DataBase>)dataBaseBindingSource.Current ).Object;
      /*var query = from software in _context.Softwares
   join sdb in _context.SoftwareDatabases on software.Id equals sdb.IdSoftware
   where sdb.IdDataBase == current.Id
   select software;*/

      IQueryable<Models.Software> query = from software in _context.Softwares
                                          join sdb in _context.SoftwareDatabases on software.Id equals sdb.IdSoftware
                                          where sdb.IdDataBase == current.Id
                                          select software;

      softwareBindingSource.DataSource = new BindingListView<Models.Software>(list: await query.ToListAsync());
    }

    private async void DatabaseForm_Load(object sender, EventArgs e) => await Binding();

    private void GoBack_Click(object sender, EventArgs e) => this.Nav(to: new Main());

    private async void AddDatabaseBtn_Click(object sender, EventArgs e)
    {
      var form = new AddDatabase();
      if(form.DialogResult == DialogResult.OK)
      {
        await Binding();
        dataBaseDataGridView.Refresh();
      }
    }

    private async void RemoveDatabaseBtn_Click(object sender, EventArgs e)
    {
      if(dataBaseDataGridView.SelectedRows.Count > 0)
      {
        var id = (int)dataBaseDataGridView.SelectedRows[index: 0].Cells[index: 0].Value;
        var database = await _context.Databases.FirstOrDefaultAsync(predicate: it => it.Id == id);
        _context.Databases.Remove(entity: database);
        await _context.SaveChangesAsync();
        await Binding();
        dataBaseDataGridView.Refresh();
      }
    }
  }
}

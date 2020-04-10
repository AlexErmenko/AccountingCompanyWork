using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Equin.ApplicationFramework;

using Microsoft.EntityFrameworkCore;

using UI.Models;

using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;

using static Desktop.Extentions.Navigator;

namespace Desktop.Views.Database
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

    private async Task Binding() => dataBaseBindingSource.DataSource =
                                    new BindingListView<DataBase>(list: await _context.Databases.ToListAsync());

    private void dataBaseBindingSource_PositionChanged(object sender, EventArgs e)
    {
      DataBase current = ( (ObjectView<DataBase>)dataBaseBindingSource.Current ).Object;

      var q = _context.Softwares.Join(inner: _context.SoftwareDatabases, outerKeySelector: data => data.Id,
                                      innerKeySelector: softwareDatabase => softwareDatabase.IdSoftware,
                                      resultSelector: (data, dataBaseSoftware) => new
                                      {
                                        data,
                                        dataBaseSoftware
                                      })
                      .Where(predicate: t => t.dataBaseSoftware.IdDataBase == current.Id)
                      .Select(selector: t => t.data).ToList();

      var bindingListView = new BindingListView<UI.Models.Software>(list: q);

      // softwareBindingSource.DataSource = bindingListView;
      // dataGridView1.Refresh();
      // _context.Softwares.Include(it => it.SoftwareDatabases).;
      /*var query = from software in _context.Softwares
 join sdb in _context.SoftwareDatabases on software.Id equals sdb.IdSoftware
 where sdb.IdDataBase == current.Id
 select software;*/
      // var query = from software in _context.Softwares
      // join sdb in _context.SoftwareDatabases on software.Id equals sdb
      // .IdSoftware
      // where sdb.IdDataBase == current.Id
      // select software;

      // var softwares = query.ToList();
      // if (softwares.Any())
      // {
      // softwareBindingSource.DataSource   = new BindingListView<UI.Models.Software>(list: softwares);
      // RemoveSoftwareFromDatabase.Enabled = true;
      // } else
      // {
      // RemoveSoftwareFromDatabase.Enabled = false;
      // }
    }

    private async void DatabaseForm_Load(object sender, EventArgs e) => await Binding();

    private void GoBack_Click(object sender, EventArgs e) => this.Nav(to: new Main());

    private async void AddDatabaseBtn_Click(object sender, EventArgs e)
    {
      var form = new AddDatabase();
      if(form.ShowDialog() == DialogResult.OK)
      {
        await Binding();
        dataBaseDataGridView.Refresh();
      }
    }

    private async void RemoveDatabaseBtn_Click(object sender, EventArgs e)
    {
      DataBase current = ( (ObjectView<DataBase>)dataBaseBindingSource.Current ).Object;

      var query = from software in _context.Softwares
                  join sdb in _context.SoftwareDatabases on software.Id equals sdb.IdSoftware
                  where sdb.IdDataBase == current.Id
                  select software;

      if(!query.Any())
      {
        _context.Databases.Remove(entity: current);
        await _context.SaveChangesAsync();
        await Binding();
        dataBaseDataGridView.Refresh();
      } else
      {
        MessageBox.Show(text: "Неможливо видалити дану базу данных, так оскільки на неї силаються деякі прогррамні додати",
                        caption: "Попередження!", buttons: OK, icon: Warning);
      }
    }
  }
}

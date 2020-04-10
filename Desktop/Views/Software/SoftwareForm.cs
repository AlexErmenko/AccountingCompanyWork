using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Desktop.Views.Database;

using Equin.ApplicationFramework;

using Microsoft.EntityFrameworkCore;

using UI.Models;

using static Desktop.Extentions.Navigator;

namespace Desktop.Views.Software
{
  /// <summary>
  ///     !TODO:Пункт курсового: у одной программы может быть много баз данныз
  /// </summary>
  public partial class SoftwareForm : Form
  {
    private readonly SoftwareFirmContext context;

    public SoftwareForm()
    {
      InitializeComponent();
      context = new SoftwareFirmContext();
    }

    // var q = from row in Context.Softwares.ToList()
    // join sdb in Context.SoftwareDatabases.ToList() on row.Id equals sdb.IdSoftware
    // select new {sdb.IdSoftwareNavigation};
    private async void SoftwareForm_Load(object sender, EventArgs e) => await Binding();

    private async Task Binding() => softwareBindingSource.DataSource =
                                    new BindingListView<UI.Models.Software>(list: await context
                                                                                            .Softwares
                                                                                            .ToListAsync());

    private void softwareBindingSource_PositionChanged(object sender, EventArgs e)
    {
      UI.Models.Software current = ( (ObjectView<UI.Models.Software>)softwareBindingSource.Current ).Object;

      /* Sql
       select DB.*
         from [DataBase] DB
         inner join SoftwareDataBase SDB on SDB.IdDataBase = DB.Id
         where IdSoftware = 1;
         */
      /*Linq*/
      var q = context.Databases.Join(inner: context.SoftwareDatabases, outerKeySelector: data => data.Id,
                                     innerKeySelector: softwareDatabase => softwareDatabase.IdDataBase,
                                     resultSelector: (data, softwareDatabase) => new
                                     {
                                       data,
                                       softwareDatabase
                                     })
                     .Where(predicate: t => t.softwareDatabase.IdSoftware == current.Id)
                     .Select(selector: t => t.data).ToList();

      /**/
      var bindingListView = new BindingListView<DataBase>(list: q);
      dataBaseBindingSource.DataSource = bindingListView;
      dataGridView1.Refresh();
    }

    private void GoBack_Click(object sender, EventArgs e) => this.Nav(to: new Main());

    /// <summary>
    ///     Use case: приложению больше не нужна данная база её нужно удалить
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void RemoveDatabaseFromSoftwareBtn_Click(object sender, EventArgs e)
    {
      UI.Models.Software software = ( (ObjectView<UI.Models.Software>)softwareBindingSource.Current ).Object;
      DataBase dataBase = ( (ObjectView<DataBase>)dataBaseBindingSource.Current ).Object;
      SoftwareDataBase firstOrDefaultAsync =
          await context.SoftwareDatabases.FirstOrDefaultAsync(predicate: it => it.IdDataBase == dataBase.Id &&
                                                                               it.IdSoftware == software.Id);
      context.Remove(entity: firstOrDefaultAsync);
      await context.SaveChangesAsync();
      await Binding();
      SoftwareGridView.Refresh();
    }

    private async void AddDatabaseToSoftwareBtn_Click(object sender, EventArgs e)
    {
      var form = new AddDatabase();

      if(form.ShowDialog() == DialogResult.OK)
      {
        await Binding();
        SoftwareGridView.Refresh();
        dataGridView1.Refresh();
      }
    }

    private void choiseExistDatabase_Click(object sender, EventArgs e) { }

    private void AddSoftwareBtn_Click(object sender, EventArgs e) { }

    private void RemoveSoftwareBtn_Click(object sender, EventArgs e) { }
  }
}

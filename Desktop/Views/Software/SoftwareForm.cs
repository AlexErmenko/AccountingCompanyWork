using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Equin.ApplicationFramework;

using Microsoft.EntityFrameworkCore;

using UI.Models;

using static UI.Extentions.Navigator;

namespace UI.Views.Software
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

    public async Task Binding() => softwareBindingSource.DataSource =
                                   new BindingListView<Models.Software>(list: await context.Softwares.ToListAsync());

    private void softwareBindingSource_PositionChanged(object sender, EventArgs e)
    {
      var current = ( (ObjectView<Models.Software>)softwareBindingSource.Current ).Object;

      /* Sql
       select DB.*
         from [DataBase] DB
         inner join SoftwareDataBase SDB on SDB.IdDataBase = DB.Id
         where IdSoftware = 1;
         */
      /*Linq*/
      List<DataBase> q = context.Databases.Join(inner: context.SoftwareDatabases, outerKeySelector: data => data.Id,
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
    }

    private void GoBack_Click(object sender, EventArgs e) => this.Nav(to: new Main());
  }
}

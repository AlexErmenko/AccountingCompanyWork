using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Desktop.Views.Database;
using Desktop.Views.OS;
using Desktop.Views.Server;
using Desktop.Views.Software;
using Desktop.Views.User;

using Equin.ApplicationFramework;

using Microsoft.EntityFrameworkCore;

using UI.Models;

using static System.Windows.Forms.Application;

using static Desktop.Extentions.Navigator;

namespace Desktop.Views
{
  /// <summary>
  ///     Главное окно
  ///     !TODO:Пункт курсового: один пользователь пользуется многими программами
  /// </summary>
  public partial class Main : Form
  {
    /// <summary>
    ///     Контекст базы данных
    /// </summary>
    private readonly SoftwareFirmContext _context;

    /// <summary>
    ///     Конструктор
    /// </summary>
    public Main()
    {
      InitializeComponent();
      _context = new SoftwareFirmContext();
    }

    /// <summary>
    ///     Переход на форму для работы с пользователями
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void usersNavigation_Click(object sender, EventArgs e) => this.Nav(to: new UsersForm());

    /// <summary>
    ///     Переход на форму для работы с базами данных
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void databasesNavigation_Click(object sender, EventArgs e) => this.Nav(to: new DatabaseForm());

    /// <summary>
    ///     Переход на форму для работы с серверами
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void serversNavigation_Click(object sender, EventArgs e) => this.Nav(to: new ServerForm());

    /// <summary>
    ///     Переход на форму для работы с программным обеспечением
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void softwareNavigation_Click(object sender, EventArgs e) => this.Nav(to: new SoftwareForm());

    /// <summary>
    ///     Добавление операционной системы
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void operatingSystemNavigation_Click(object sender, EventArgs e)
    {
      var form = new AddOS();
      form.ShowDialog();
      throw new NotImplementedException();
    }

    /// <summary>
    ///     Инициализируем данные для клиента
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void Main_Load(object sender, EventArgs e) => await Binding();

    private async Task Binding()
    {
      var users = await _context.Users.ToListAsync();
      userBindingSource.DataSource = new BindingListView<UI.Models.User>(list: users);
      UsersGridView.Refresh();
      SoftwareGridView.Refresh();
    }

    /// <summary>
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void RemoveSoftwareFromUserBtn_Click(object sender, EventArgs e)
    {
      var software = (UI.Models.Software)softwaresBindingSource.Current;
      if(software != null)
      {
        software.IdUser = null;
        _context.Softwares.Update(entity: software);
        await _context.SaveChangesAsync();
      }
      await Binding();
    }

    private UI.Models.User GetUser() => ( (ObjectView<UI.Models.User>)userBindingSource.Current ).Object;

    /// <summary>
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AddSoftwareForUserBtn_Click(object sender, EventArgs e) => new SoftwareAddForm(this, GetUser().Id).Show();

    /// <summary>
    /// При выборе пользователя у которого нет приложений блок на кнопку удаления
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void userBindingSource_PositionChanged(object sender, EventArgs e) => RemoveSoftwareFromUserBtn.Enabled = GetUser().Softwares.Any();

    private void Main_FormClosing(object sender, FormClosingEventArgs e) => Exit();

    /// <summary>
    ///     Открывает форму для выбора существующего приложения для добавления его пользователю
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SelectSoftwareForUserBtn_Click(object sender, EventArgs e) => new ChoiseSoftwareForm(from: this, id: GetUser().Id).Show();
  }
}

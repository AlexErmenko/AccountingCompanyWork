using System;
using System.Windows.Forms;

using Equin.ApplicationFramework;

using Microsoft.EntityFrameworkCore;

using UI.Models;
using UI.Views.Database;
using UI.Views.OS;
using UI.Views.Server;
using UI.Views.Software;
using UI.Views.User;

using static UI.Extentions.Navigator;

namespace UI.Views
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
    }

    /// <summary>
    ///     Инициализируем данные для клиента
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void Main_Load(object sender, EventArgs e) =>
        userBindingSource.DataSource = new BindingListView<Models.User>(list: await _context.Users.ToListAsync());
  }
}

using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Equin.ApplicationFramework;

using Microsoft.EntityFrameworkCore;

using UI.Models;

using static System.Windows.Forms.DialogResult;

using static Desktop.Extentions.Navigator;

namespace Desktop.Views.User
{
  /// <summary>
  /// 
  /// </summary>
  public partial class UsersForm : Form
  {
    /// <summary>
    ///     Контекст БД
    /// </summary>
    private readonly SoftwareFirmContext _context;

    /// <summary>
    ///     Конструктор
    /// </summary>
    public UsersForm()
    {
      InitializeComponent();
      _context = new SoftwareFirmContext();
    }

    /// <summary>
    ///     Загрузка данных
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void UsersForm_Load(object sender, EventArgs e) => await SetBinding();

    /// <summary>
    ///     Вернутся на предыдущую форму
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GoBackBtn_Click(object sender, EventArgs e) => this.Nav(to: new Main());

    /// <summary>
    ///     Добавление пользователя
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void AddUserBtn_Click(object sender, EventArgs e)
    {
      var userAddForm = new UserAddForm();
      var dialogResult = userAddForm.ShowDialog();
      if(dialogResult == Yes)
      {
        await SetBinding();
        UsersGridView.Refresh();
      }
    }

    /// <summary>
    ///     Удаление пользователя
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void RemoveUserBtn_Click(object sender, EventArgs e)
    {
      if(UsersGridView.SelectedRows.Count > 0)
      {
        var id = (int)UsersGridView.SelectedRows[index: 0].Cells[index: 0].Value;
        var user = await _context.Users.FindAsync(id);
        _context.Users.Remove(entity: user);
        await _context.SaveChangesAsync();
        await SetBinding();
        UsersGridView.Refresh();
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private async Task SetBinding()
    {
      await _context.Users.LoadAsync();
      var bindingListView = new BindingListView<UI.Models.User>(list: _context.Users.ToList());
      userBindingSource.DataSource = bindingListView;
    }
  }
}

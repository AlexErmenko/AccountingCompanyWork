using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using Desktop.Extentions;

using Equin.ApplicationFramework;

using Microsoft.EntityFrameworkCore;

using UI.Models;

using OperatingSystem = UI.Models.OperatingSystem;

namespace Desktop.Views.Software
{
  public partial class ChoiseSoftwareForm : Form
  {
    private readonly int _id;
    private readonly SoftwareFirmContext _context;

    public ChoiseSoftwareForm(Form from, int id)
    {
      InitializeComponent();
      from.Hide();
      _id = id;
      _context = new SoftwareFirmContext();
    }

    private async void ChoiseSoftwareForm_Load(object sender, EventArgs e) => await Binding();

    private async Task Binding() => operatingSystemBindingSource.DataSource = new BindingListView<OperatingSystem>(list: await _context.OperatingSystems.ToListAsync());

    private async void AcceptSelect_Click(object sender, EventArgs e)
    {
      //Получаем данные
      var software = (UI.Models.Software)softwaresBindingSource.Current;
      var user = await _context.Users.FindAsync(_id);
      //Добавляем приложение пользователю и сохраняем в бд изменения
      software.IdUser = _id;
      user.Softwares.Add(item: software);
      _context.Update(entity: user);
      await _context.SaveChangesAsync().ConfigureAwait(continueOnCapturedContext: true);
      //Назад к главному окну
      this.Nav(to: new Main());
    }
  }
}

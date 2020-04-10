using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.Extentions;
using Equin.ApplicationFramework;
using Microsoft.EntityFrameworkCore;
using UI.Models;
using OperatingSystem = UI.Models.OperatingSystem;

namespace Desktop.Views.Software
{
  public partial class SoftwareAddForm : Form
  {
    private readonly SoftwareFirmContext _context;
    private readonly int                 _userId;

    public SoftwareAddForm(Form from, int userId)
    {
      InitializeComponent();
      _context = new SoftwareFirmContext();
      _userId  = userId;
      from.Hide();
    }

    private async Task Binding()
    {
      var operatingSystems = await _context.OperatingSystems.ToListAsync();
      operatingSystemBindingSource.DataSource = new BindingListView<OperatingSystem>(operatingSystems);
    }

    // throw new NotImplementedException()
    private async void SoftwareAddForm_Load(object sender, EventArgs e) => await Binding();

    private async void AddSoftwareForUserBtn_Click(object sender, EventArgs e)
    {
      var idOc = ((ObjectView<OperatingSystem>) operatingSystemBindingSource.Current).Object.Id;
      try
      {
        //Проверки: не ввели значение для name, такое имя и операционная система уже существуют
        SoftwareNameTextBox.Validate("Ви не ввели назву додатку", out var name);
        UI.Models.Software nameExist =
                await _context.Softwares.SingleOrDefaultAsync(software => software.Name.Equals(name) &&
                                                                          software.IdOperatingSystem == idOc);
        if (nameExist != null) throw new DuplicateNameException("Програма з таким ім'ям вже існує");

        //Валидация прошла успешно
        //Создаём новое приложение, получаем пользователя, добавляем ему приложение, обновляем значение в бд и сохраняем
        var            newSoftware = new UI.Models.Software {IdOperatingSystem = idOc, IdUser = _userId, Name = name};
        await _context.Softwares.AddAsync(newSoftware);
        await _context.SaveChangesAsync();

        //Возвращаемся на главную
        this.Nav(new Main());
      }
      catch (FormatException formatException)
      {
        MessageBox.Show(formatException.Message, "Не коректні дані", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      catch (DuplicateNameException duplicateNameException)
      {
        MessageBox.Show(duplicateNameException.Message, "Не коректні дані", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
      }
    }
  }
}
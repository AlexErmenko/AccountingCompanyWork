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
    public int Id { get; }
    public SoftwareFirmContext Context { get; set; }

    public ChoiseSoftwareForm(Form from, int id)
    {
      InitializeComponent();
      from.Hide();
      Id = id;
      Context = new SoftwareFirmContext();
    }

    private async void ChoiseSoftwareForm_Load(object sender, EventArgs e) => await Binding();

    private async Task Binding() => operatingSystemBindingSource.DataSource =
                                    new BindingListView<OperatingSystem>(list: await Context
                                                                                         .OperatingSystems.ToListAsync());

    private async void AcceptSelect_Click(object sender, EventArgs e)
    {
      OperatingSystem os = ( (ObjectView<OperatingSystem>)operatingSystemBindingSource.Current ).Object;
      var software = (UI.Models.Software)softwaresBindingSource.Current;
      UI.Models.User user = await Context.Users.FindAsync(Id);
      software.IdUser = Id;
      user.Softwares.Add(item: software);
      Context.Update(entity: user);
      await Context.SaveChangesAsync().ConfigureAwait(continueOnCapturedContext: true);
      this.Nav(to: new Main());
    }
  }
}

using System;
using System.Windows.Forms;

using UI.Models;

using static System.String;
using static System.Windows.Forms.DialogResult;

namespace Desktop.Views.User
{
  public partial class UserAddForm : Form
  {
    private readonly SoftwareFirmContext _context;

    public UserAddForm()
    {
      InitializeComponent();
      _context = new SoftwareFirmContext();
    }

    private async void SaveUserBtn_Click(object sender, EventArgs e)
    {
      string firstName = firstNameTextBox.Text;
      string middleName = middleNameTextBox.Text;
      string lastName = lastNameTextBox.Text;
      if(IsNullOrEmpty(value: firstName)) firstNameTextBox.Select();
      if(IsNullOrEmpty(value: middleName)) middleNameTextBox.Select();
      if(IsNullOrEmpty(value: lastName)) lastNameTextBox.Select();

      var user = new UI.Models.User
      {
        FirstName = firstName,
        MiddleName = middleName,
        LastName = lastName
      };

      await _context.Users.AddAsync(entity: user);
      await _context.SaveChangesAsync();
      DialogResult = Yes;
      Hide();
    }
  }
}

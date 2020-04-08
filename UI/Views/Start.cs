using System;
using System.Windows.Forms;

using static UI.Extentions.Navigator;

namespace UI.Views
{
  /// <summary>
  ///     Стартовое окно
  /// </summary>
  public partial class Start : Form
  {
    /// <summary>
    ///     Конструктор с инициализацией визуальных компонентов
    /// </summary>
    public Start() => InitializeComponent();

    /// <summary>
    ///     Переход к окну Main
    /// </summary>
    /// <param name="sender">Button</param>
    /// <param name="e">EventArgs</param>
    private void GetStartBtn_Click(object sender, EventArgs e) => this.Nav(to: new Main());
  }
}

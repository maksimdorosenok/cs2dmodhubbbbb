using System.Windows;
namespace CS2D_ModHub {
 public partial class MainWindow : Window {
  public MainWindow() { InitializeComponent(); Nav.MainFrame = MainFrame; Nav.Navigate(new Pages.HomePage()); }
 }
}

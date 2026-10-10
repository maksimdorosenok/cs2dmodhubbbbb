using System.Windows;
using System.Windows.Controls;
namespace CS2D_ModHub.Pages {
 public partial class HomePage : Page {
  public HomePage() { InitializeComponent(); }
  private void Mods_Click(object sender, RoutedEventArgs e) { Nav.Navigate(new ModPage()); }
  private void Options_Click(object sender, RoutedEventArgs e) { Nav.Navigate(new OpPage()); }
  private void Community_Click(object sender, RoutedEventArgs e) { Nav.Navigate(new ComPage()); }
  private void Exit_Click(object sender, RoutedEventArgs e) { Window.GetWindow(this).Close(); }
 }
}

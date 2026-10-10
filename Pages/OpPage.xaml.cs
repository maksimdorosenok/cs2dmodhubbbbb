using System.Windows;
using System.Windows.Controls;
using CS2D_ModHub.Models;
namespace CS2D_ModHub.Pages {
 public partial class OpPage : Page {
  public OpPage() { InitializeComponent(); AlphaCheck.IsChecked = DemoData.ShowAlpha; UnverifiedCheck.IsChecked = DemoData.ShowUnverified; }
  private void Settings_Changed(object sender, RoutedEventArgs e) { if (AlphaCheck == null || UnverifiedCheck == null) return; DemoData.ShowAlpha = AlphaCheck.IsChecked == true; DemoData.ShowUnverified = UnverifiedCheck.IsChecked == true; }
  private void Home_Click(object sender, RoutedEventArgs e) { Nav.Home(); }
 }
}

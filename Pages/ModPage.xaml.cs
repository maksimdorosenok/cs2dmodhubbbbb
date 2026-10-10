using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using CS2D_ModHub.Models;
namespace CS2D_ModHub.Pages {
 public partial class ModPage : Page {
  public ModPage() { InitializeComponent(); Refresh(); }
  private void Refresh() {
   if (ModsList == null || SearchBox == null || CategoryBox == null) return;
   var query = (SearchBox.Text ?? "").Trim();
   var selected = CategoryBox.SelectedItem as ComboBoxItem;
   string category = selected == null ? "Все категории" : selected.Content.ToString();
   var matches = DemoData.Mods.Where(m => (DemoData.ShowAlpha || !m.IsAlpha) && (DemoData.ShowUnverified || m.IsVerified) && (category == "Все категории" || m.Category == category) && (m.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 || m.Category.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
   ModsList.ItemsSource = matches;
   CountText.Text = "Показано модов: " + matches.Count + " / " + DemoData.Mods.Count;
  }
  private void Filters_Changed(object sender, EventArgs e) { Refresh(); }
  private void ModsList_SelectionChanged(object sender, SelectionChangedEventArgs e) { var mod = ModsList.SelectedItem as ModItem; if (mod != null) { ModsList.SelectedItem = null; Nav.Navigate(new ModManPage(mod)); } }
  private void Home_Click(object sender, RoutedEventArgs e) { Nav.Home(); }
 }
}

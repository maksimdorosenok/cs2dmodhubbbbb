using System.Windows;
using System.Windows.Controls;
using CS2D_ModHub.Models;
namespace CS2D_ModHub.Pages {
 public partial class ModManPage : Page {
  private readonly ModItem _mod;
  public ModManPage(ModItem mod) {
   InitializeComponent(); _mod = mod;
   TitleText.Text = mod.Name; CoverLetters.Text = mod.Icon; BadgeText.Text = mod.Badge;
   VersionText.Text = "Версия: " + mod.Version;
   AuthorText.Text = "Автор: " + mod.Author;
   CategoryText.Text = "Категория: " + mod.Category;
   DescriptionText.Text = mod.Description;
  }
  private void Back_Click(object sender, RoutedEventArgs e) { Nav.Back(); }
  private void Download_Click(object sender, RoutedEventArgs e) { MessageBox.Show("Это демонстрационный макет. Загрузка файлов не реализована.\n\nМод: " + _mod.Name, "CS2D ModHub", MessageBoxButton.OK, MessageBoxImage.Information); }
 }
}

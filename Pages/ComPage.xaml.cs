using System.Windows;
using System.Windows.Controls;
namespace CS2D_ModHub.Pages {
 public partial class ComPage : Page {
  public ComPage() { InitializeComponent(); }
  private void Send_Click(object sender, RoutedEventArgs e) {
   if (string.IsNullOrWhiteSpace(NameBox.Text) || string.IsNullOrWhiteSpace(EmailBox.Text) || string.IsNullOrWhiteSpace(MessageBoxInput.Text)) {
    MessageBox.Show("Заполни имя, email и текст обращения.", "Проверка формы", MessageBoxButton.OK, MessageBoxImage.Warning); return;
   }
   if (!EmailBox.Text.Contains("@") || !EmailBox.Text.Contains(".")) {
    MessageBox.Show("Проверь адрес email.", "Проверка формы", MessageBoxButton.OK, MessageBoxImage.Warning); return;
   }
   MessageBox.Show("Демонстрация отправки завершена.\nОбращение не отправлялось на сервер.", "CS2D ModHub", MessageBoxButton.OK, MessageBoxImage.Information);
   MessageBoxInput.Clear();
  }
  private void Home_Click(object sender, RoutedEventArgs e) { Nav.Home(); }
 }
}

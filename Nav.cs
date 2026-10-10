using System.Windows.Controls;
namespace CS2D_ModHub {
 public static class Nav {
  public static Frame MainFrame;
  public static void Navigate(Page page) { MainFrame.Navigate(page); }
  public static void Back() { if (MainFrame.CanGoBack) MainFrame.GoBack(); else Navigate(new Pages.HomePage()); }
  public static void Home() { Navigate(new Pages.HomePage()); }
 }
}

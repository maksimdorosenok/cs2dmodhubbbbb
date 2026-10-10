namespace CS2D_ModHub.Models {
 public class ModItem {
  public string Name { get; set; }
  public string Version { get; set; }
  public string Author { get; set; }
  public string Category { get; set; }
  public string Description { get; set; }
  public string Icon { get; set; }
  public bool IsAlpha { get; set; }
  public bool IsVerified { get; set; }
  public string Badge { get { return IsAlpha ? "ALPHA" : IsVerified ? "ПРОВЕРЕН" : "НЕ ПРОВЕРЕН"; } }
 }
}

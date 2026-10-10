using System.Collections.Generic;
namespace CS2D_ModHub.Models {
 public static class DemoData {
  public static bool ShowAlpha = false;
  public static bool ShowUnverified = false;
  // Вымышленные записи для демонстрации интерфейса, а не опубликованные моды.
  public static readonly List<ModItem> Mods = new List<ModItem> {
   new ModItem { Name="Tactical HUD", Version="1.2.0", Author="DemoCreator", Category="Интерфейс", Icon="HUD", Description="Альтернативное оформление игрового интерфейса: индикаторы здоровья, брони и патронов.", IsVerified=true },
   new ModItem { Name="Pixel Arsenal", Version="2.1.3", Author="ModStudio", Category="Оружие", Icon="GUN", Description="Набор пиксельных визуальных моделей оружия для CS2D.", IsVerified=true },
   new ModItem { Name="Dust Reborn", Version="1.4.0", Author="MapMaker", Category="Карты", Icon="MAP", Description="Учебный пример модифицированной карты в песочной палитре.", IsVerified=true },
   new ModItem { Name="Arcade Sound Pack", Version="1.0.2", Author="RetroWave", Category="Звуки", Icon="SFX", Description="Стилизованный комплект звуков интерфейса и игровых событий.", IsVerified=true },
   new ModItem { Name="Neon Crosshair", Version="1.6.0", Author="DemoCreator", Category="Интерфейс", Icon="HUD", Description="Пакет вариантов игрового прицела.", IsVerified=true },
   new ModItem { Name="Zombie Lab", Version="0.6.0-alpha", Author="ProtoDev", Category="Режимы", Icon="LAB", Description="Концепция пользовательского игрового режима с лабораторной тематикой.", IsVerified=true, IsAlpha=true },
   new ModItem { Name="Urban Tiles", Version="0.9.1", Author="UnknownMapper", Category="Карты", Icon="MAP", Description="Пример набора городских текстур.", IsVerified=false },
   new ModItem { Name="Experimental Weapons", Version="0.2.0-alpha", Author="TestUser", Category="Оружие", Icon="GUN", Description="Экспериментальная концепция набора оружия.", IsVerified=false, IsAlpha=true }
  };
 }
}

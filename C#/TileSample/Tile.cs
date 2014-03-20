using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;

namespace TileSample
{ 
    public class Tile : MetroSidebarTile.Tile
    {
        public UserControl MainControl()
        {
            return new MainControl();
        }
        public Window SettingsWindow()
        {
            return new SettingsWindow();
        }
        public int Height()
        {
            return 120;
        }
        public int LargeHeight()
        {
            return 240;
        }
        public bool Separator()
        {
            return true;
        }
        public string Background()
        {
            return @"#d34500";
        }
    }
}

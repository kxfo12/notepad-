using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace notepad___
{
    /// <summary>
    /// Logika interakcji dla klasy Font.xaml
    /// </summary>
    public partial class Font : Window
    {
        public string WhichStyle { get; set; } = "";
        public bool IsBold { get; set; } = false;
        public int Size { get; set; } = 12;
        public List<int> AvalibleFontSize { get; set; } = new List<int>();
        public Font()
        {
            InitializeComponent();
            DataContext = this;
            for(int i = 6; i < 50; i += 2)
            {
                AvalibleFontSize.Add(i);
            }
        }

        private void Do_Changes(object sender, RoutedEventArgs e)
        {
            switch (fontStyle.SelectedIndex)
            {
                case 0:
                    WhichStyle = "normalna";
                    IsBold = false;
                    break;
                case 1:
                    WhichStyle = "normalna";
                    IsBold = true;
                    break;
                case 2:
                    WhichStyle = "italic";
                    IsBold = false;
                    break;
                case 3:
                    WhichStyle = "italic";
                    IsBold = true;
                    break;
            }
        }
    }
}

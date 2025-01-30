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

        }
    }
}

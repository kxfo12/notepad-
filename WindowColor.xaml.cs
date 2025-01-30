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
    /// Logika interakcji dla klasy WindowColor.xaml
    /// </summary>
    public partial class WindowColor : Window
    {
        public Color newcolor { get; set; }
        public WindowColor()
        {
            InitializeComponent();
        }

        private void ChangeColor(object sender, RoutedEventArgs e)
        {
            if (byte.TryParse(rTextBox.Text, out byte value1) && byte.TryParse(gTextBox.Text, out byte value2) && byte.TryParse(bTextBox.Text, out byte value3)) 
            {
                Color newcolor = Color.FromRgb(value1, value2, value3);
                MessageBox.Show(newcolor.ToString());
            }
            Close();
        }
    }
}

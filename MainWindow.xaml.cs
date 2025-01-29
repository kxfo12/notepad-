using Microsoft.Win32;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace notepad___
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string FileName { get; set; } = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Save_Button(object sender, RoutedEventArgs e)
        {
            if (FileName == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "text file | *.txt";
                if (saveFileDialog.ShowDialog() == true)
                {
                    //zapis do pliku
                    FileName = saveFileDialog.FileName;
                    File.WriteAllText(saveFileDialog.FileName, TextBoxx.Text);
                }
            }
            else
            {
                File.WriteAllText(FileName, TextBoxx.Text);
                         }
            Title = FileName;
        }

        private void Open_Button(object sender, RoutedEventArgs e)
        {
            saveFileQuestion(sender, e);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text file | *.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                //zapis do pliku
                FileName = openFileDialog.FileName;
                TextBoxx.Text = File.ReadAllText(openFileDialog.FileName);
                Title = FileName;
            }
        }

        private void New_Button(object sender, RoutedEventArgs e)
        {
            saveFileQuestion(sender, e);
            FileName = "New_File";
            TextBoxx.Text = "";
            Title = FileName;
        }
        private void saveFileQuestion(object sender, RoutedEventArgs e)
        {
            if (Title.Contains("*") == true) { 
                MessageBoxResult result = MessageBox.Show("Czy chcesz wcześniej zapisać?", "Beka z cb",
                    MessageBoxButton.YesNoCancel, MessageBoxImage.Error);
                if (result == MessageBoxResult.Yes)
                {
                    Save_Button(sender, e);
                }
                else if (result == MessageBoxResult.Cancel)
                {
                    return;
                }
            }
        }

        private void TitleUpdate(object sender, TextChangedEventArgs e)
        {
            if(Title.Contains("*") == false) Title = "*" + Title;
        }

        private void Close_Button(object sender, RoutedEventArgs e)
        {
            saveFileQuestion(sender, e);
            Close();
        }

        private void RedText_Button(object sender, RoutedEventArgs e)
        {
            TextBoxx.Foreground = Brushes.Red;
        }
        private void AboutAplicaion_Button(object sender, RoutedEventArgs e)
        {
            Window2 windowAboutApplication = new Window2();
            windowAboutApplication.Show();//Można działać w tle
        }

        private void AboutAuthor_Button(object sender, RoutedEventArgs e)
        {
            Window3 windowAboutAuthor = new Window3();
            windowAboutAuthor.ShowDialog();//nie można działać w tle
        }
    }
}
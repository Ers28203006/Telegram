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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Telegram
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ModeButtonClick(object sender, RoutedEventArgs e)
        {
            if (modeButton.Content == FindResource("Day"))
            {
                modeButton.Content = FindResource("Night");
                window.Background = Brushes.White;

                var bc = new BrushConverter();
                menu.Background = (Brush)bc.ConvertFrom("#47779a");
                listBox.Background = Brushes.White;
            }
            else
            {
                modeButton.Content = FindResource("Day");
                window.Background = Brushes.LightGray;
                menu.Background = Brushes.Gray;
                listBox.Background = Brushes.LightGray;
            }
        }
    }
}

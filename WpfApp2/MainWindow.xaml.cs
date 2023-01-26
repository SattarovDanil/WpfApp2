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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                
                MessageBox.Show("Белоснежный цвет как символ мира, добрых намерений, чистых помыслов");
            }

            { 
                MessageBox.Show("Синий – цвет веры и верности, постоянства и честности");
            }

            {
                MessageBox.Show("Красный цвет символизирует энергию, силу, мужество, любовь и кровь, пролитую за Отечество");
            }

        }
    }
}

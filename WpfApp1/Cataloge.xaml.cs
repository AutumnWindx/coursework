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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Cataloge.xaml
    /// </summary>
    public partial class Cataloge : Window
    {
        public Cataloge()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void WaterTex_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Himiya_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Acumulator_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tires_Click(object sender, RoutedEventArgs e)
        {

        }

        private void accessories_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Consumable_Click(object sender, RoutedEventArgs e)
        {

        }

        private void winter_accessories_click(object sender, RoutedEventArgs e)
        {

        }
    }
}

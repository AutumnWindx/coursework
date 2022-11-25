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

namespace WpfApp1
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

        private void Catalog_Button_Click(object sender, RoutedEventArgs e)
        {
            new Cataloge().Show();
            this.Close();
        }

        private void Working_conditions_Click(object sender, RoutedEventArgs e)
        {
            new Working_conditions().Show();
            this.Close();
        }

        private void Suppliers_Clicker(object sender, RoutedEventArgs e)
        {
            new Suppliers().Show();
            this.Close();
        }

    }
}

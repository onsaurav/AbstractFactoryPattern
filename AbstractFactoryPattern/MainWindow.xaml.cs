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
using AbstractFactoryPattern.AbstractFactoryPatternItems;

namespace AbstractFactoryPattern
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SoftwareDevelopmentCompany _Microsoft = new Microsoft1();
            Products _ProductsM = new Products(_Microsoft);
            lstAll.Items.Add(_ProductsM.ShowStatus());

            SoftwareDevelopmentCompany _Google = new Google();
            Products _ProductsG = new Products(_Google);
            lstAll.Items.Add(_ProductsG.ShowStatus());
        }
    }
}

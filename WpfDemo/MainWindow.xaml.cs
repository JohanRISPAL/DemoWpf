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

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ListCraftUC ListCraftUC { get; set; } = new ListCraftUC();

        public SelectionUC SelectionUC { get; set; } = new SelectionUC();

        public MainWindow()
        {
            InitializeComponent();
            Control.Content = SelectionUC;
            
            //Subscribe UserControl's event on the method who change the UserControl of the main Window
            ListCraftUC.BackToMenu += BackToMenu;
            
            //Subscribe UserControl's event on the method who change the UserControl of the main Window
            SelectionUC.GoToCraftList += GoToCraftList;
        }

        private void BackToMenu(object sender, RoutedEventArgs e)
        {
            Control.Content = SelectionUC;
        }

        private void GoToCraftList(object sender, RoutedEventArgs e)
        {
            Control.Content = ListCraftUC;
        }

    }
}
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

namespace LW_
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person.InitPersons();
            PersonsV.DataContext = Person.AllPeople;
        }
        private void Persons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person pp = (Person)((sender as ListView).SelectedItem);
            DataContext = pp;
        }

        private void PersonsV_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Person pp = (Person)((sender as ListView).SelectedItem);
            Window1 nw = new Window1(pp);
            nw.ShowDialog();
        }

        private void NewU_Click(object sender, RoutedEventArgs e)
        {
            Window1 nw = new Window1();
            nw.ShowDialog();
        }
    }
}

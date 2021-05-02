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

namespace LW_
{
    /// <summary>
    /// Interakční logika pro Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        bool IsUpdating { get; set; }
        public Window1()
        {
            InitializeComponent();
            DataContext = new Person();
            IsUpdating = false;
        }
        public Window1(Person p)
        {
            InitializeComponent();
            DataContext = p;
            IsUpdating = true;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (IsUpdating == false)
            {
                Person.AllPeople.Add((Person)DataContext);
            }
            this.Close();
        }
    }
}

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

namespace Employee_Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            grid_workers.ItemsSource = Worker.workers_list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Add_Worker_Window addWindow = new Add_Worker_Window();
            addWindow.ShowDialog();
            grid_workers.Items.Refresh();
        }

        private void delete_button_Click(object sender, RoutedEventArgs e)
        {
            int index = grid_workers.SelectedIndex;
            grid_workers.Items.RemoveAt(index);
        }
    }
}

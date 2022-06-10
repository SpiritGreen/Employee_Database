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

namespace Employee_Database
{
    /// <summary>
    /// Логика взаимодействия для Add_Worker_Window.xaml
    /// </summary>
    public partial class Add_Worker_Window : Window
    {
        public Add_Worker_Window()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            int id = Worker.workers_list.Count;
            string name = name_box.Text;
            string surname = surname_box.Text;
            string last_name = last_name_box.Text;
            string birthday = birthday_picker.Text;
            char gender = '-';
            if (gender_box.Text == "Женщина")
            {
                gender = 'Ж';
            }
            else if (gender_box.Text == "Мужчина")
            {
                gender = 'М';
            }
            Worker.workers_list.Add(new Worker(id, name, surname, last_name, birthday, gender));
            this.DialogResult = true;
        }
    }
}

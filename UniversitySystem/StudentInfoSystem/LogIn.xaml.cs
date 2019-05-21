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
using UniversitySystem;
using StudentRepository;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            String data = "";
            data = IDText.Text;
            data += " ";
            data += PassText.Text;

            this.NavigationService.Navigate(main);


               
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}

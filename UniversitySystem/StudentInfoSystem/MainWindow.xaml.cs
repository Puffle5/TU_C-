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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        public MainWindow()
        {
            InitializeComponent();
            if (NavigationService == null)
            {
                NavigationService = new NavigationService();
            }
            else
            {
                
            }
            NavigationService.LoadCompleted += NavigationService_LoadCompleted;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (var currentChild in personalGrid.Children) 
            {
                if (currentChild is TextBox) 
                {
                    ((TextBox)currentChild).Text = Environment.NewLine;
                
                }
            }
            foreach (var currentChild in informationGrid.Children)
            {
                if (currentChild is TextBox)
                {
                    ((TextBox)currentChild).Text = Environment.NewLine;

                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Student student = StudentData.TestStudents[0];
            firstNameText.Text = student.FirstName;
            middleNameText.Text = student.MiddleName;
            lastNameText.Text = student.LastName;
            facultyText.Text = student.Faculty;
            specialtyText.Text = student.Specialty;
            degreeText.Text = student.Degree;
            statusText.Text = student.status.ToString();
            facultyNumberText.Text = student.FacultyNumber;
            courseText.Text = student.Course.ToString();
            flowText.Text = student.Flow.ToString();
            groupText.Text = student.Group.ToString();
            

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            foreach (var currentChild in personalGrid.Children)
            {
                if (currentChild is TextBox)
                {
                    ((TextBox)currentChild).IsEnabled = false;

                }
            }
            foreach (var currentChild in informationGrid.Children)
            {
                if (currentChild is TextBox)
                {
                    ((TextBox)currentChild).IsEnabled = false;

                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            foreach (var currentChild in personalGrid.Children)
            {
                if (currentChild is TextBox)
                {
                    ((TextBox)currentChild).IsEnabled = true;

                }
            }
            foreach (var currentChild in informationGrid.Children)
            {
                if (currentChild is TextBox)
                {
                    ((TextBox)currentChild).IsEnabled = true;

                }
            }
        }

        private void NavigationService_LoadCompleted(object sender, NavigationEventArgs e)
        {
            MessageBox.Show("Username must be at least 2 characters long!");
            string str = (string)e.ExtraData;

            string[] words = str.Split(' ');
            string id = words[0];
            string password = words[1];

            UniversitySystem.LoginValidation validation = new LoginValidation(id, password, null);

            User user = null;
            bool valid = validation.ValidateUserInput(user);
            if (valid)
            {
                Student student = StudentData.foundStudentByNumber(user.FakNum);
                firstNameText.Text = student.FirstName;
                middleNameText.Text = student.MiddleName;
                lastNameText.Text = student.LastName;
                facultyText.Text = student.Faculty;
                specialtyText.Text = student.Specialty;
                degreeText.Text = student.Degree;
                statusText.Text = student.status.ToString();
                facultyNumberText.Text = student.FacultyNumber;
                courseText.Text = student.Course.ToString();
                flowText.Text = student.Flow.ToString();
                groupText.Text = student.Group.ToString();
            }
        }

    }
}

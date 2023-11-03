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
using System.Collections.ObjectModel;
using _320PracApp.DataBase;
using _320PracApp.Functions;

namespace _320PracApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для TeachMainPage.xaml
    /// </summary>
    public partial class TeachMainPage : Page
    {
        public static ObservableCollection<Exam> examsList { get; set; }
        public TeachMainPage()
        {
            InitializeComponent();
            examsList = ExamFunction.GetExam();
            this.DataContext = this;
        }

        private void LvExams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var isSelected = LvExams.SelectedItem as Exam;
            if (isSelected != null)
            {
                NavigationService.Navigate(new StudentsPage(isSelected));
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorisPage());
        }
    }
}

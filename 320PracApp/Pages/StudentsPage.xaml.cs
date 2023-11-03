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
    /// Логика взаимодействия для StudentsPage.xaml
    /// </summary>
    public partial class StudentsPage : Page
    {
        public static ObservableCollection<Student> studentsList { get; set; }
        public static Exam ex { get; set; }
        public StudentsPage(Exam exam)
        {
            InitializeComponent();
            ex = exam;
            studentsList = StudentFunction.GetStudents(exam);
            DataContext = this;
        }

        private void LvStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

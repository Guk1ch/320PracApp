using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using _320PracApp.DataBase;

namespace _320PracApp.Functions
{
    public class ExamFunction
    {
        public static ObservableCollection<Exam> exams { get; set; }
        public static ObservableCollection<Exam> GetExam()
        {
            return new ObservableCollection<Exam>(BdConnection.connection.Exam.ToList());
        }
    }
}

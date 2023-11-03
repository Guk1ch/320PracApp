using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _320PracApp.DataBase;
using System.Collections.ObjectModel;

namespace _320PracApp.Functions
{
    public class StudentFunction
    {
        public static ObservableCollection<Student> students { get; set; }
        public static ObservableCollection<Student> GetStudents(Exam exam)
        {
            return new ObservableCollection<Student>(BdConnection.connection.Student.Where(a => a.RegNumber == exam.RegNumber ).ToList());

        }
        public static void AddStudent(int id, string spec, string surname)
        {
            Student student = new Student();

            student.RegNumber = id;
            student.SpecializationNumber = spec;
            student.Surname = surname;

            BdConnection.connection.Student.Add(student);
            BdConnection.connection.SaveChanges();
        }
    }
}

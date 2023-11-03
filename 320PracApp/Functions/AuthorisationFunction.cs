using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using _320PracApp.DataBase;

namespace _320PracApp.Functions
{
    public class AuthorisationFunction
    {
        public static ObservableCollection<Employee> employees { get; set; }
        public static Employee AuthorizationEmpl(string login, string password)
        {
            employees = new ObservableCollection<Employee>(BdConnection.connection.Employee.ToList());
            var userExists = employees.Where(user => user.Surname == login && Convert.ToString(user.TabNumber) == password).FirstOrDefault();
            if (userExists != null)
            {
                return userExists;
            }
            else
            {
                return userExists;
            }
        }
    }
   
}

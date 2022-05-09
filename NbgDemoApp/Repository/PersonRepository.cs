using NbgDemoApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbgDemoApp.Repository
{
    public class PersonRepository : IPersonRepository
    {

        private List<Person> _employees = new List<Person>();
        private int _employeesCount;

        public Person CreatePerson(Person employee)
        {
            employee.Id = ++ _employeesCount;
            _employees.Add(employee);
            return employee;
        }

        public bool DeletePerson(int employeeId)
        {
            Person employee = ReadPerson(employeeId);
            if (employee == null)
                return false;
            _employees.Remove(employee);
            return true;
        }

        public List<Person> ReadPerson()
        {
            return _employees;
        }

        public Person ReadPerson(int employeeId)
        {
            foreach(Person employee in _employees)
            {
                if (employee.Id == employeeId)
                    return employee;
            }
            return null;
        }

        public Person UpdatePerson(int employeeId, Person employee)
        {
            Person employeeInList = ReadPerson(employeeId);
            if (employeeInList == null)
                return null;
            employeeInList.Name = employee.Name;
            return employeeInList;
        }
    }
}

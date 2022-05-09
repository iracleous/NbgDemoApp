using NbgDemoApp.Model;
using NbgDemoApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbgDemoApp
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Nikos";
            var employee2 = new Employee();
            employee2.Name = "Panagiotis";
            var customer = new Customer();
            customer.Name = "Petros";
            customer.Credit = 30;
            customer.ContactTimes = 3;

            IPersonRepository personRepository = new PersonRepository();
            personRepository.CreatePerson(person);
            personRepository.CreatePerson(employee2);
            personRepository.CreatePerson(customer);

            personRepository.ReadPerson()
                .ForEach(item => item.ContactTimes++);



            personRepository.ReadPerson()
                 .ForEach(employeeItem => Console.WriteLine( employeeItem ));

            int maxContactTimes = personRepository.ReadPerson().Max(item => item.ContactTimes);
            Person maxContactPerson = personRepository.ReadPerson()
            .Where(person1 => person1.ContactTimes == maxContactTimes).First();


            Console.WriteLine($"maxContactTimes = {maxContactTimes}  person = {maxContactPerson}");

            Console.ReadLine();
        }



        static void MyTest()
        {
            var employee = new Person();
            var employee1 = employee;

            employee.Name = "Dimitris";
            Console.WriteLine(employee1.Name);


            int a = 5;
            int b = a;
            a = 6;
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 2147483647;
            a++;
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}

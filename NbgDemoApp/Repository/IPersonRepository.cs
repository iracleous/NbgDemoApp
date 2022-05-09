using NbgDemoApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbgDemoApp.Repository
{
   public interface IPersonRepository
    {
        Person CreatePerson(Person person);
        List<Person> ReadPerson();
        Person ReadPerson(int personId);
        Person UpdatePerson(int personId, Person person);
        bool DeletePerson(int personId);
    }
}

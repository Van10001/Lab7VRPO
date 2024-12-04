using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System;
using System.Threading.Tasks;
namespace Lab7VRPO
{
    public class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }
        public Person(string name, string surName, string lastName)
        {
            Name = name;
            SurName = surName;
            LastName = lastName;
        }
        ~Person()
        {
            throw new System.NotImplementedException();
        }

        public string GetFIO()
        {
            return LastName + " " + Name + " " + SurName;
        }
    }

}

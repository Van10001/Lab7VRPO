using Lab7VRPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7VRPO
{
    public class TravelAgent : Person
    {
        public string PhoneNumber { get; set; }
        public string Post { get; set; }
        public TravelAgent(string name = "", string surName = "", string lastName = "", string position = "", string phoneNumber = "")
            : base(lastName, name, surName)
        {
            PhoneNumber = phoneNumber;
            Post = position;


        }

        public string AboutHe()
        {
            return GetFIO() + "\nНомер телефона: " + PhoneNumber + "\nДолжность: " + Post;
        }




        ~TravelAgent()
        {
            throw new System.NotImplementedException();
        }


    }
}

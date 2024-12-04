using Lab7VRPO;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace Lab7VRPO
{
    public class Client : Person
    {
        public string PhoneNumber { get; set; }
        public int money { get; set; }
        public string PassportData { get; set; }

        public Client(string name = "", string surName = "", string lastName = "", string phoneNumber = "")
            : base(lastName, name, surName)
        {

            PhoneNumber = phoneNumber;

        }



        public int PayOrder()
        {

            return money;

        }
        public string Pasport()
        {
            return "Номер пасспорта: " + PassportData;
        }
        public string About()
        {
            return GetFIO() + "\nНомер телефона: " + PhoneNumber;
        }
        ~Client()
        {
            throw new System.NotImplementedException();
        }

    }
}

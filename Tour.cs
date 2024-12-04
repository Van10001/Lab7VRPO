using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using Lab7VRPO;
namespace Lab7VRPO
{
    public class Tour
    {
        protected Client client;
        protected TravelAgent TravelAgent;
        protected bool Availability;
        public int Cost;
        protected string TourStatus;
        public string title;
        List<string> TourList = new List<string>() { "1 - Шоппинг", "2 - Отдых", "3 - В туристических целях" };

        protected string Description;
        public Tour(Client client2 = null, TravelAgent travelAgent2 = null, bool availability = true, int cost = 0, string tourStatus = "", string title = "", string description = "")
        {
            client = client2;
            TravelAgent = travelAgent2;

            Availability = availability;
            Cost = cost;
            TourStatus = tourStatus;
            Description = description;
        }
        public string CancelTour()
        {

            return "Тур отменён";
        }
        public string CreateTour()
        {
            return "Тур" + " № " + title + " сформирован";
        }
        public string ChooseTour()
        {
            Console.WriteLine("Выберите 1 из 3 предложенных туров");
            foreach (var title in TourList) { Console.WriteLine(title); }
            return Console.ReadLine();

        }
        public void Print()
        {
            if (client.PayOrder() < Cost) { Console.WriteLine(CancelTour()); Console.WriteLine("\nДля продолжения нажмите Enter"); Console.ReadLine(); }
            else
            {

                Console.WriteLine("--------------------------------");
                Console.WriteLine(CreateTour());
                Console.WriteLine("Заказчик:\nФИО: " + client.About());
                Console.WriteLine(client.Pasport());
                Console.WriteLine("\nТурагент:\nФИО: " + TravelAgent.AboutHe());





            }
        }




        ~Tour()
        {
            throw new System.NotImplementedException();
        }

    }
}

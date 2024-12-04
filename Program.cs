using Lab7VRPO;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Authentication;

Tour tour = null;
Client client = new Client();
TravelAgent travelAgent = new TravelAgent();
byte select = 0;
string tempStr = "";
bool correctInput = false;

while (select != 4)
{
    Console.Clear();
    Console.WriteLine("Приложение для управления турагенством\n\n");
    switch (select)
    {
        case 0:
            Console.WriteLine("Выберите дейтсвие для продолжения:\n");
            if (tour == null)
            {
                Console.WriteLine("1-Добавить информацию о туре\n");
            }
            else
            {
                Console.WriteLine("2-Очистить информацию о туре\n");
                Console.WriteLine("3-Информация о туре\n");

            }
            Console.WriteLine("4-Выход\n");
            tempStr = Console.ReadLine();
            correctInput = byte.TryParse(tempStr, out select);

            if (select > 4 || !correctInput)
            {
                Console.WriteLine("Ошибка ввода данных\n\tНажмите Enter для продолжения");
                Console.ReadLine();
                select = 0;
            }
            break;

        case 1:
            client = new Client();
            travelAgent = new TravelAgent();
            if (tour == null)
            {

                tour = new Tour(client, travelAgent);
                tour.title = tour.ChooseTour();
                Console.Clear();
                Console.WriteLine("Введите Фамилию клиента");
                client.SurName = Console.ReadLine();
                Console.WriteLine("Введите Имя клиента");
                client.Name = Console.ReadLine();
                Console.WriteLine("Введите Отчество клиента");
                client.LastName = Console.ReadLine();
                Console.WriteLine("Введите номер телефона клиента");
                client.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Введите номер пасспорта клиента");
                client.PassportData = Console.ReadLine();
                //

                Console.WriteLine("Введите Фамилию турагента");
                travelAgent.SurName = Console.ReadLine();
                Console.WriteLine("Введите Имя турагента");
                travelAgent.Name = Console.ReadLine();
                Console.WriteLine("Введите Отчество турагента");
                travelAgent.LastName = Console.ReadLine();
                Console.WriteLine("Введите номер телефона турагента");
                travelAgent.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Введите должность турагента");
                travelAgent.Post = Console.ReadLine();
                Console.WriteLine("Введите сумму которую перевел клиент и стоимость тура");
                client.money = Convert.ToInt32(Console.ReadLine());
                tour.Cost = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Данные о туре сохранены\n Нажмитe Enter для продолжения");

            }
            else
            {
                tour = null;
                Console.WriteLine("Данные о туре очищены\n Нажмите Enter для продолжения");
            }

            Console.ReadLine();
            select = 0;
            break;
        ///
        case 2:

            tour = null;
            select = 0;
            Console.WriteLine("Данные о туре очищены\n Нажмите Enter для продолжения");
            Console.ReadLine();
            break;
        case 3:
            tour.Print();
            Console.WriteLine("Для продолжения нажмите Enter\n");
            Console.ReadLine();
            select = 0;
            break;



        default:
            select = 0;
            break;




    }
}


Console.Clear();

Console.WriteLine("Выход из приложения");


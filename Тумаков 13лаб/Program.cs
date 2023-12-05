using System;
using Тумаков_13лаб.Classes;

namespace Тумаков_13лаб
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 13.1,13.2 - Из кл.Банковский счет удалить методы,заменить на свойства.Добавить индексатор.\n");
            BankAccount account = new BankAccount(1,5432);
            Console.WriteLine($"Номер счета: {account.AccountNumber}\nБаланс: {account.Balance}\n");

            Console.WriteLine("\nДз 13.1 - Все методы заменить на свойства\n");
            Building building = new Building(100,20,100,20);

            Console.WriteLine($"Высота: {building.Height}");
            Console.WriteLine($"Этажей: {building.Floors}");
            Console.WriteLine($"Квартир: {building.Apartments}");
            Console.WriteLine($"Подъездов: {building.Entrances}");
            Console.WriteLine($"Высота этажа: {building.CalculateFloorHeight()}");
            Console.WriteLine($"Кол-во квартир в подъезде: {building.CalculateApartmentsEntrance()}");
            Console.WriteLine($"Кол-во квартир на этаж: {building.CalculateApartmentsFloor()}");

            Console.WriteLine("\nДз 13.2 - Массив на 10 зданий\n");
            Building myBuildings = new Building();

            myBuildings[0] = "Здание 1";
            myBuildings[1] = "Здание 2";
            myBuildings[2] = "Здание 3";
            myBuildings[3] = "Здание 4";
            myBuildings[4] = "Здание 5";
            myBuildings[5] = "Здание 6";
            myBuildings[6] = "Здание 7";
            myBuildings[7] = "Здание 8";
            myBuildings[8] = "Здание 9";
            myBuildings[9] = "Здание 10";


            Console.WriteLine(myBuildings[0]); 
            Console.WriteLine(myBuildings[1]); 
            Console.WriteLine(myBuildings[2]);
            Console.WriteLine(myBuildings[3]);
            Console.WriteLine(myBuildings[4]);
            Console.WriteLine(myBuildings[5]);
            Console.WriteLine(myBuildings[6]);
            Console.WriteLine(myBuildings[7]);
            Console.WriteLine(myBuildings[8]);
            Console.WriteLine(myBuildings[9]);
        }
    }
}

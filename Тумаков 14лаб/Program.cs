using System;
using System.Reflection;
using Тумаков_14лаб.Classes;

namespace Тумаков_14лаб
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 14.1 - Добавить метод DumpToScreen");
            BankAccount account = new BankAccount("1267838", 1000);
            account.DumpToScreen();

            Console.WriteLine("\nУпр14.2 - Создать пользовательский атрибут DeveloperInfoAttribute.\n");
            MemberInfo type = typeof(RationalNumber);
            object[] attributes = type.GetCustomAttributes(false);

            foreach (Attribute attribute in attributes)
            {
                if (attribute is DeveloperInfoAttribute)
                {
                    DeveloperInfoAttribute info = (DeveloperInfoAttribute)attribute;
                    Console.WriteLine($"Разработчик: {info.Name}\nДата создания: {info.Date}");
                }
            }
            Console.WriteLine("\nДз 14.1 - Атрибут для класса Building\n");
            MemberInfo type2 = typeof(Building);
            object[] attributes2 = type.GetCustomAttributes(false);

            foreach (Attribute attribute in attributes2)
            {
                if (attribute is BuildingDeveloperInfo)
                {
                    BuildingDeveloperInfo info = (BuildingDeveloperInfo)attribute;
                    Console.WriteLine($"Разработчик: {info.Name}\n Организация: {info.Organization}\n");
                }
            }
        }
    }
}

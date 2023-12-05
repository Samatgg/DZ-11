using System;

namespace Тумаков_14лаб.Classes
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class DeveloperInfoAttribute : Attribute
    {
        private string name;
        private string date;
        public string Name
        {
            get
            {
                return name;
            }
        }        
        public string Date
        {
            get
            {
                return date;
            }
        }

        public DeveloperInfoAttribute(string name, string date)
        {
            this.name = name;
            this.date = date;
        }


    }

}

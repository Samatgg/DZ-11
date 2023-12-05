using System;

namespace Тумаков_14лаб.Classes
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class BuildingDeveloperInfo : Attribute
    {
        private string name;
        private string organization;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Organization
        {
            get
            {
                return organization;
            }
        }
        public BuildingDeveloperInfo(string name, string organization)
        {
            this.name = name;
            this.organization = organization;
        }
    }
}

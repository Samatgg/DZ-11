using System;

namespace Тумаков_13лаб.Classes
{
    public class Building
    {
        private static int lastBuildingNumber = 0;
        private int numberOfBuilding;
        private double height;
        private int floors;
        private int apartments;
        private int entrances;
        private string[] buildings;

        public int NumberOfBuilding
        {
            get { return numberOfBuilding; }
        }
        public double Height
        {
            get { return height; }
        }
        public int Floors
        {
            get { return floors; }
        }
        public int Apartments
        {
            get { return apartments; }
        }
        public int Entrances
        {
            get { return entrances; }
        }
        public double CalculateFloorHeight()
        {
            return (double)height / floors;
        }

        public int CalculateApartmentsEntrance()
        {
            return (int)apartments / entrances;
        }

        public int CalculateApartmentsFloor()
        {
            return (int)apartments / floors;
        }
        public Building()
        {
            buildings = new string[10];
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < buildings.Length)
                {
                    return buildings[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Недопустимый индекс здания");
                }
            }
            set
            {
                if (index >= 0 && index < buildings.Length)
                {
                    buildings[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Недопустимый индекс здания");
                }
            }
        }
        public Building(int height, int floors, int apartments, int entrances)
        {
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrances = entrances;
        }

    }
}

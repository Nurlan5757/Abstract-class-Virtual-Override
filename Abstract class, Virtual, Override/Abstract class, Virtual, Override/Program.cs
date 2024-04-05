using Abstract_class__Virtual__Override.Models;

namespace Abstract_class__Virtual__Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Porche", "GTS", "Blue", 34, 43);
            Bicycle b = new Bicycle("ab", "db", "fg", 22, 22);
            Car c2 = new Car("RR", "RR", "blue", 22, 45);
            Bicycle b2 = new Bicycle("dx", "df", "ty", 56, 78);

            c.GetInfo();
            c.ToString();
            b.ToString();
            b.GetInfo();
            c2.GetInfo();
            c2.ToString();
            b2.ToString();
            b2.GetInfo();



           /* Vehicle[] vehicles = (c, c2, b, b2);


            foreach (var vehicle in vehicles)
            {
                c.GetInfo();
                c.ToString();
                b.ToString();
                b.GetInfo();
                Console.WriteLine(vehicle);
            }*/



        }
    }
}

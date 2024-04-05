using InterFace.Models;

namespace InterFace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<ISwim> swimers = new List<ISwim>();
            ISwim dog=new Dog("toplan");*/
            Calculate c = new Calculate();

            Console.WriteLine(c.Add(1, 3));

        }
    }
}

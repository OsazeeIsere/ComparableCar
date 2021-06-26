using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with object sorting");
            Car[] myCar = new Car[5];
            myCar[0] = new Car("Bitto", 50, 1);
            myCar[1] = new Car("Big for nothing", 80, 22);
            myCar[2] = new Car("Pencil light", 90, 3);
            myCar[3] = new Car("Crystal Light", 100, 6);
            myCar[4] = new Car("Audi", 70, 44);
            Console.WriteLine("Here is the unordered set of car");
            foreach (Car c in myCar)
            {
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);
                Console.WriteLine();
            }
                //now sort the car array
                Array.Sort(myCar);
                Console.WriteLine();

            //now print sorted cars
            foreach (Car c in myCar)
            {
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);
                Console.WriteLine();
            }

            //now sort the car array by petName
            //Array.Sort(myCar, new PetNameComparer());//made a bit cleaner below

            Array.Sort(myCar, Car.SortedByPetName);

            //now dump sorted cars
            Console.WriteLine("Ordering By Pet Name");
            foreach (Car c in myCar)
            {
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}

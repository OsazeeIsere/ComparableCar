using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ComparableCar
{
  public  class Car: IComparable
    {
        //field variable
        public const int MaxSpeed = 50;
        private bool CarIsDead;//is the car dead
        
        // properties
        public int CurrSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        public int CarID { get; set; }

        //we now support a custom property to return
        //the correct IComparer Interface
        public static IComparer SortedByPetName
        {
            get { return (IComparer)new PetNameComparer(); }
        }
        //constructors
        public Car()
        {

        }
        public Car(string name,int speed,int id)
        {
            PetName = name;
            CurrSpeed = speed;
            CarID = id;
        }

        // this Car has a Radio(containment/delegation-inheritance)
      //private  Radio carRadio = new Radio();

       //methods
       public void CrankTunes(bool state)
        {
            //delegate request to  inner object
            //carRadio.RadioOn(state);
        }

         int IComparable.CompareTo(object obj)
        {
            //Car temp = obj as Car;
            //if (temp != null)
            //{
                //if (this.CarID > temp.CarID)
                //{
                //    return 1;
                //}
                //if (this.CarID < temp.CarID)
                //{
                //    return -1;
                //}
                //since the c# int data type implement IComparable
                //interface the above block of code be streamline as such
                Car temp = obj as Car;
                if (temp != null)
            {
                return this.CarID.CompareTo(temp.CarID);
            }


                else
                {
                    throw new ArgumentException("Parameter is not a car");

                }
            
        }
        // throw the custom carIsdeadException
        //public void Accelerate(int delta)
        //{

        //            CarIsDeadException ex=
        //             new CarIsDeadException($"{PetName} has overheated","You have a lead foot",
        //             DateTime.Now);
        //            ex.HelpLink = "http://www.CarRUs.com";


        //            throw ex;


        //}
    }
}

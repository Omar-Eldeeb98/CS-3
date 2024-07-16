using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_3
{
    internal class Car
    {


        //private  int id;
        //private  string model;
        //private double speed;

        #region properties

        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"carId: {Id}\nmodel: {Model}\nspeed: {Speed}";
        }

        #endregion


        #region constructors

        // deafault constructor 
        public Car() { }

        // user defind constructor 
        public Car(int id, string model, double speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
            Console.WriteLine("constructor 1");
        }

        public Car(int id, string model):this(id , model , 190)  // constructor overloading , same name but diffrent parameters. 
        {
            //Id = id;
            //Model = model;
            //Speed = 190;
            Console.WriteLine("constructor 2");
        }

        public Car(int id):this(id, "audi" , 200)// constructor overloading
        {
            //Id = id;
            //Model = "Audi";
            //Speed = 220;
            Console.WriteLine("constructor 3");
        }







            #endregion


        

         
    }

}

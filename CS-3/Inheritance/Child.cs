using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_3.Inheritance
{
    internal class Child: Parent
    {
        
        public int z { get; set; }


        public Child(int x , int y , int z) : base(x,y)
        {
           
            this.z = z;
        }


        public override string ToString()
        {
            return $"{x} , {y} ,  {z}";
        }

        public new int Multiplication()  // new version of  Parent method
        {
            //return x * y * z;
            return base.Multiplication() * z;
        }


    }
}

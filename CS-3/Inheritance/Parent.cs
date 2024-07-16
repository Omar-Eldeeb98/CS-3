using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_3.Inheritance
{
    internal class Parent
    {
        #region properties
        // properties
        public int x { get; set; }
        public int y { get; set; }
        #endregion

        #region Construtor
        // constructor
        public Parent(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion

        #region methods

        // method
        public override string ToString()
        {
            return $"{x} , {y}";
        }


        public int Multiplication()
        {
            return x * y;
        }

        #endregion

    }
}

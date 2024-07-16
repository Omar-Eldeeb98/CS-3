using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_3.Encapsulation
{
    internal struct Employee
    {
        #region attribute

       private int id;
       private string? name;
       private decimal salary;
       //private int age;
       


        #endregion

        // [Encapsulation]  ==> separate data definition from it's use. 
        // achived by ==> [getter setter , property]
        // 1- all attribute must be private
        // 2- [getter setter] ,[property]

        #region applay encapsulation using getter and setter

        // getter function
        public string? getName()
        {
            return this.name;
        }

        // setter function
        public void setName(string? name)
        {
            this.name = name?.Length > 5 ? name.Substring(0 , 5) : name; // can control values 
            //this.name = name;
        }

        #endregion


        #region applay encapsulation using property

        // property -->  [full property , automatic property , Indexer]

        // 1 -  [full property]  ---> recommended when i need to add validation to attribute value.
        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                this.salary = value; // value keyword will carry assigned value.
            }
        }


        //  2 - [automatic property] ----> recomnded when no validation needed.
        // compiler will generate hidden private attribute called (Backing Field).
        public int Age { get; set; }  // automatic property syntax. ,مش بحتاج اني اعرف attribute كده .
      

        #endregion

        #region Constructors
        // user defined constructor 
        public Employee(int id, string? name, decimal salary , int age)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            Age = age;
        }

        #endregion


        #region methods

        // change the behaviour of the function
        public override string ToString()
        {
            return $"id = {this.id}\nname = {this.name}\nsalary = {this.salary:c}\nage = {Age}";
        }


        #endregion



    }
}

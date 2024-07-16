using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CS_3.Encapsulation
{
    internal struct Phonebook
    {


        #region attributes

        string[] names;
        int[] numbers;
        int size;

        #endregion

        #region properties

        // full property
        public int Size
        {
            get { return size; }
            //set { size = value; }   // no need for setter 
        }

        // Indexer :
        // - is a special property
        // -  can take prameters

        public int this[string name]
        {
            // note["omar"]  ------> get omar number
            get
            {
                if(names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                        {
                            return numbers[i];
                        }
                    }
                }

                return -1;
            }

            // note["omar"] = 444  ----> set new number 
            set
            {
                if(names is not null && numbers is not null)
               
                {
                    for (int i =0; i< names.Length; i++)
                    {
                        if (names[i] == name)
                        {
                            numbers[i] = value;
                            break;
                        }

                    }

                }

            }
        }



        #endregion

        #region getter , setter 
        // getter
        public int getPersonNumber(string name) { 
            if(this.names is not null && this.numbers is not null)
            {
                for (int i = 0; i<this.names.Length; i++)
                {
                    if (this.names[i] == name)
                    {
                        return this.numbers[i];
                    }
                }
            }
            return -1;
        }


        // setter 
        public void setPersonNumber(string name , int newNumber)
        {
            if(names is not null && numbers is not null)
            {
                for (int i = 0; i<names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        // set newNumber
                        numbers[i] = newNumber;
                        break;
                    }
                }
            }
        }

        #endregion


        #region  constructors

        public Phonebook(int size)
        {
            this.size = size;
            this.names = new string[size];
            this.numbers = new int[size];
        }

        #endregion



        #region methods
        // add new person to note
        public void AddPerson(int position, string name, int number)
        {
             if(numbers is not null && names is not null)
            {
                if(position < size)
                {
                    this.numbers[position] = number;
                    this.names[position] = name;
                }
            }
        }

        #endregion

    } 
}

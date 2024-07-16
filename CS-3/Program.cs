using CS_3.Encapsulation;
using CS_3.Inheritance;

namespace CS_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation

            //Employee employee = new Employee(10, "omar", 7000 , 30);
            //Console.WriteLine(employee);


            //employee.id = 777;  // set id directly through attribute.
            //Console.WriteLine(employee.id); // get id directly through attribute.



            //employee.getName();  // get Name using getter
            //Console.WriteLine(employee.getName());  

            //employee.setName("micheldevo"); // set name use setter
            //Console.WriteLine(employee.getName());


            //employee.salary = 1000;  // invalid
            //Console.WriteLine(employee.salary);  // invalid



            //employee.Salary = 9000; // set salary using [property] as a setter
            //Console.WriteLine(employee.Salary);  // get salary using [property] as a getter.


            //employee.Age = 33;
            //Console.WriteLine(employee.Age);

            #endregion


            #region Indexer 
            //Phonebook note = new Phonebook(5);

            //note.AddPerson(0, "omar", 13);
            //note.AddPerson(1, "ahmed", 15);
            //note.AddPerson(3, "mona", 17);



            //int monaNumber = note.getPersonNumber("mona");
            //Console.WriteLine(monaNumber == -1 ? "person not found" : monaNumber );


            //note.setPersonNumber("mona", 1000);
            //Console.WriteLine( "newNumber Of Mona =  " + note.getPersonNumber("mona"));



            /* Indexer Implementaion and using*/

            //int n =  note["omar"];
            // Console.WriteLine(n);  // output :  13


            //note["omar"] = 111;  // set new number to omar
            //Console.WriteLine(note["omar"]);  // output :  111



            #endregion



            #region Class

            //Car C1;

            //C1 = new Car(); // parameter less constructor , def constructor 
            //// - allocate required bytes at heap 
            //// - initialize allocated bytes with default value of data type
            //// - calling user defined constructor if exist
            //// - assign C1 to allocated object.


            //Car C1 = new Car(10 , "BMW" , 320);  // using first constructor
            //Console.WriteLine(C1);
            //Console.WriteLine("------------------------------");
            //Car C2 = new Car(10, "toyota"); // using second constructor
            //Console.WriteLine(C2);

            //Console.WriteLine("---------------------------------");
            //Car C3 = new Car(30); // using third constructor
            //Console.WriteLine(C3);


            #endregion



            #region Inheritance

            //Parent P = new Parent(2,3);
            //Console.WriteLine(P.Multiplication()); // 6 
            //Console.WriteLine(P);  // print object 2 , 3 


            //Child c = new Child(3,4,5);
            //Console.WriteLine(c.ToString()); // 3,4,5
            //Console.WriteLine(c.Multiplication()); // 60


            #endregion
        }
    }
}


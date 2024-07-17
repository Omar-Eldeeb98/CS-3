namespace OOP02
{
    #region Part 2 

    #region Q1
    //public struct Person
    //{
    //   // properties
    //    public string name { get; set; }
    //    public int age { get; set; }

    //    // constructor
    //    public Person(string name, int age)
    //    {
    //        this.name = name;
    //        this.age = age; 
    //    }



    //}
    #endregion


    #region Q2 
    //public struct Person
    //{
    //    // properties
    //    public string name { get; set; }
    //    public int age { get; set; }

    //    // constructor
    //    public Person(string name, int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }



    //}
    #endregion

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 2

            #region Q1
            //  Define a struct "Person" with properties "Name" and "Age".
            //  Create an array of three "Person" objects and populate it with data. Then,
            //  write a C# program to display the details of all the persons in the array.


            //Person[] persons = new Person[3];

            //persons[0] = new Person("omar", 20);
            //persons[1] = new Person("ahmed", 17);
            //persons[2] = new Person("mona", 30);


            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine($"[Name: {persons[i].name} , Age: {persons[i].age}]");
            //}


            #endregion


            #region Q2
            //reate a struct called "Person" with properties "Name" and "Age". Write a C# program
            //that takes details of 3 persons as input from the user
            //and displays the name and age of the oldest person.


            //Person[] persons = new Person[3];

            //Person oldestPerson = new Person();
            //oldestPerson.age = 0;

            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine($"enter the name of person number {i+1}");
            //    persons[i].name = Console.ReadLine();

            //    Console.WriteLine($"enter the age of person number {i + 1}");
            //    persons[i].age = Convert.ToInt32(Console.ReadLine());


            //    if (persons[i].age > oldestPerson.age )
            //    {
            //        oldestPerson = persons[i];
            //    }
            //}

            //// print the oldest person
            //Console.WriteLine($"the oldest person  name: {oldestPerson.name}  age: {oldestPerson.age}");



            #endregion

            #endregion


            #region Part 3

            Employee[] emps = new Employee[3];

            emps[0] = Employee.addEmployee(SecurityPrevilege.DBA);
            emps[1] = Employee.addEmployee(SecurityPrevilege.guest);
            emps[2] = Employee.addEmployee(SecurityPrevilege.DBA| SecurityPrevilege.guest | SecurityPrevilege.secretary| SecurityPrevilege.Developer );



            foreach (Employee e in emps)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("=======================================================================================");
            }



            Console.WriteLine("\n");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx Sorting By Hiring Date xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            emps = Employee.sortEmployess(emps);

            foreach (Employee emp   in emps)
            {
                Console.WriteLine(emp.ToString());
            }



            #endregion

        }
    }
}

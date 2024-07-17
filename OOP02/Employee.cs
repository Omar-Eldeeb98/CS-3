using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class Employee
    {
        //constructors

        public Employee(int id, string name, HiringDate hireDate, int salary, SecurityPrevilege securityLevel, Gender gender)
        {
            this.id = id;
            this.name = name;
            this.hireDate = hireDate;
            this.salary = salary;
            this.securityLevel = securityLevel;
            this.gender = gender;
        }

        public Employee()
        {
        }

        public Employee(Employee emp) 
        {
            this.id = emp.id;
            this.name = emp.name;
            this.salary = emp.salary;
            this.securityLevel = emp.securityLevel;
            this.gender = emp.gender;
            this.hireDate = new HiringDate(emp.hireDate);

        }

        // properties
        public int id { get; set; }
        public string name { get; set; }
        public HiringDate hireDate { get; set; }
        public int salary { get; set; }
        public SecurityPrevilege securityLevel { get; set; }
        public Gender gender { get; set; }


        //methods
        public override string ToString()
        {
            return $"id: {id}, name: {name}, hiring-date: {hireDate}, security-level: {securityLevel}, gender: {gender}, salary: {salary:c}";
        }


        public static Employee addEmployee(SecurityPrevilege sp)
        {
            Employee emp = new Employee();

            emp.securityLevel = sp;


            bool flag;
            int id;
            int salary;
            Gender gender;
           

            do
            {
                Console.WriteLine("enter employee id:");
                flag = int.TryParse(Console.ReadLine(), out id);


            } while (!flag);

            emp.id = id;

            Console.WriteLine("enter employee name : ");
            emp.name = Console.ReadLine();


            do
            {
                Console.WriteLine("enter employee salary:");
                flag = int.TryParse(Console.ReadLine(), out salary);


            } while (!flag);

            emp.salary = salary;

            emp.hireDate = HiringDate.createHiringdate();


            do
            {
                Console.WriteLine("enter employee gender: ");
                flag = Enum.TryParse<Gender>(Console.ReadLine(), true , out gender);

            } while (!flag);

            emp.gender = gender;

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("\n");
            return emp ;


        }



        public static Employee[] sortEmployess(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                int minIndex = i;
                for (int j = i+1; j<employees.Length; j++) 
                {
                    if (HiringDate.compareHiring(employees[j].hireDate, employees[minIndex].hireDate ))
                    {
                        minIndex = j;
                    }
                }
                if(minIndex != i)
                {
                    Employee tempEmp = new Employee( employees[minIndex]);
                    employees[minIndex] = new Employee(employees[i] );
                    employees[i] = tempEmp ;
                }
            }
            return employees;
        }


    }
}

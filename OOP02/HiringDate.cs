using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    public class HiringDate
    {
      

        // properties
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }


        // user defined constructor
        public HiringDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public HiringDate(HiringDate hd) { 
            this.day = hd.day;
            this.month = hd.month;
            this.year = hd.year;
        }

        // methods
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }


        public static HiringDate createHiringdate()
        {
            int day;
            int month;
            int year;
            bool flag;

            do
            {
                Console.WriteLine("enter Day of hiringDate: ");
                flag = int.TryParse(Console.ReadLine(), out day);

            } while (!flag);
            do
            {
                Console.WriteLine("enter month of hiringDate: ");
                flag = int.TryParse(Console.ReadLine(), out month);

            } while (!flag);

            do
            {
                Console.WriteLine("enter year hiringDate: ");
                flag = int.TryParse(Console.ReadLine(), out year);

            } while (!flag);


            return new HiringDate(day, month, year);

        }



        public static bool compareHiring(HiringDate l, HiringDate r)
        {
            if (l.year > r.year) { return true; }
            else if (l.year < r.year) { return false; }

            else if (l.month > r.month) { return true; }
            else if (l.month < r.month) { return false; }

            else if (l.day > r.day) { return true; }
            else if (l.day < r.day) { return false; }

            else { return false; }
        }

    }
}

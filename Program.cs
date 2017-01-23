using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = int.Parse(Console.ReadLine());

            var broiOtl = 0.0;
            var broiDob = 0.0;
            var broiSred = 0.0;
            var broiSlab = 0.0;

            var ocenka = 0.0;

            var otlichen = 0.0;
            var dobar = 0.0;
            var sreden = 0.0;
            var slab = 0.0;

            for (int i = 1; i <= students; i++)
            {
                ocenka = double.Parse(Console.ReadLine());
                if (ocenka<3)
                {
                    slab += ocenka;
                    broiSlab++;
                }
                if (ocenka>=3 && ocenka<= 3.99)
                {
                    sreden += ocenka;
                    broiSred++;
                }
                if (ocenka >= 4 && ocenka <= 4.99)
                {
                    dobar += ocenka;
                    broiDob++;

                }
                
                if (ocenka >= 5)
                {
                    otlichen += ocenka;
                    broiOtl++;
                }

            }
            var procentOtl = broiOtl / students*100;
            var procentDob = broiDob / students*100;
            var procentSred = broiSred / students*100;
            var procentSlab = broiSlab / students*100;
            var average = (otlichen + sreden + dobar + slab)/students;
            Console.WriteLine("Top students: {0:f2}%", procentOtl);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", procentDob);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", procentSred);
            Console.WriteLine("Fail: {0:f2}%", procentSlab);
            Console.WriteLine("Average: {0:f2}", average);
        }
    }
}

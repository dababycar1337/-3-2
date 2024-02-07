using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1337;
namespace App1337
{
    class Program
    {
        static void Main()
        {
            ForAll[] arrays = new ForAll();
            arrays[0] = new First(3);
            arrays[1] = new Second(3, 3);
            arrays[2] = new Third(3);

            Console.WriteLine("Всё про одномерные массивы:");
            arrays[0].Makearray();
            arrays[0].FindMiddle();
            arrays[0].WriteAll();
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Всё про двумерные массивы:");
            array[1].MakeArray();
            array[1].FindMiddle();
            array[1].WriteAll();
            Console.WriteLine("");
            Console.WriteLine("");

            
            Console.WriteLine("Всё про ступенчатые массивы:");
            array[2].MakeArray();
            array[2].FindMiddle();
            array[2].WriteAll();
        }
    }
}

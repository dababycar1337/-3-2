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
            Console.WriteLine("Всё про одномерные массивы:");
            First fr = new First(3);
            fr.MakeArray();
            fr.FindMiddle();
            fr.WriteAll();
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Всё про двумерные массивы:");
            Second sc = new Second(3, 3);
            sc.MakeArray();
            sc.FindMiddle();
            sc.WriteAll();
            Console.WriteLine("");
            Console.WriteLine("");

            
            Console.WriteLine("Всё про ступенчатые массивы:");
            Third th = new Third(3);
            th.MakeArray();
            th.FindMiddle();
            th.WriteAll();
        }
    }
}

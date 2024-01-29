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
            First fr = new First(3);
            Console.WriteLine("Всё про одномерные массивы:");
            fr.MakeArray();
            fr.FindMiddle();
            fr.WriteAll();
            Console.WriteLine("");


            Second sc = new Second(3, 3);
            Console.WriteLine("Всё про двумерные массивы:");
            sc.MakeArray();
            sc.FindMiddle();
            sc.WriteAll();
            Console.WriteLine("");

            Third th = new Third(3);
            Console.WriteLine("Создайте ступенчатый массив по своим критериям");
            th.MakeArray();
            Console.WriteLine("Всё про ступенчатые массивы:");
            th.FindMiddle();
            th.WriteAll();
        }
    }
}
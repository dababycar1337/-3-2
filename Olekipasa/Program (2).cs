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
            Console.WriteLine("Введите количество элементов массива");
            First fr = new First(int.Parse(Console.ReadLine()));
            fr.MakeArray();
            fr.FindMiddle();
            fr.WriteAll();
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Всё про двумерные массивы:");
            Console.WriteLine("Введите количество строк и стобцов двумерного массива");
            Second sc = new Second(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            sc.MakeArray();
            sc.FindMiddle();
            sc.WriteAll();
            Console.WriteLine("");
            Console.WriteLine("");

            
            Console.WriteLine("Всё про ступенчатые массивы:");
            Console.WriteLine("Введите количество строк ступенчатого массива");
            Third th = new Third(int.Parse(Console.ReadLine()));
            Console.WriteLine("Создайте ступенчатый массив по своим критериям");
            th.MakeArray();
            th.FindMiddle();
            th.WriteAll();
        }
    }
}

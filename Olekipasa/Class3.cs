using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1337;
namespace App1337
{
    sealed class Third : ForAll
    {
        private int[][] _array;
        private int _length;
        private float _middle;
        public Third(int n)
        {
            _length = n;
        }
        public override void MakeArray()
        {
            _array = new int[_length][];
            int dop = 0;
            int fop = 1;
            for (int i = 0; i < _length; i++)
            {
                Console.WriteLine("Какой длины будет " + (i + 1) + " строка");
                dop = int.Parse(Console.ReadLine());
                _array[i] = new int[dop];
                for (int j = 0; j < dop; j++)
                {
                    _array[i][j] = fop;
                    fop++;
                }
            }
        }

        public override void FindMiddle()
        {
            int dop = 0;
            for (int i = 0; i < _length; i++)
            {
                for (int j = 0; j < _array[i].Length; j++)
                {
                    _middle += _array[i][j];
                    dop++;
                }
            }
            _middle = _middle / dop;
        }

        public override void WriteAll()
        {
            Console.WriteLine("Ступенчатый массив:");
            for (int i = 0; i < _length; i++)
            {
                Console.Write((i + 1) + " строка: ");
                for (int j = 0; j < _array[i].Length; j++)
                {
                    Console.Write(_array[i][j] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Среднее арифметическое ступенчатого массива: " + _middle);
        }
    }
}

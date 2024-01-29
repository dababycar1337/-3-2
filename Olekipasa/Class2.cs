using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1337;
namespace App1337
{
    sealed class Second : ForAll
    {
        private int[,] _array;
        private int _length1;
        private int _length2;
        private float _middle;
        public Second(int n1, int n2)
        {
            _length1 = n1;
            _length2 = n2;
        }
        public override void MakeArray()
        {
            _array = new int[_length1, _length2];
            int dop = 1;
            for (int i = 0; i < _length1; i++)
            {
                for (int j = 0; j < _length2; j++)
                {
                    _array[i, j] = dop;
                    dop++;
                }
            }
        }

        public override void FindMiddle()
        {
            int dop = 0;
            for (int i = 0; i < _length1; i++)
            {
                for (int j = 0; j < _length2; j++)
                {
                    _middle += _array[i, j];
                    dop++;
                }
            }
            _middle = _middle / dop;
        }

        public override void WriteAll()
        {
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < _length1; i++)
            {
                for (int j = 0; j < _length2; j++)
                {
                    Console.Write(_array[i, j] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Среднее арифметическое всего двумерного массива - " + _middle);
        }
    }
}

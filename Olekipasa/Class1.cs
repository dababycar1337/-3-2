using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1337;
namespace App1337
{
    sealed class First : ForAll
    {
        private int[] _array;
        private float _middle;
        private int _length;
        public First(int n)
        {
            _length = n;
        }
        public override void MakeArray()
        {
            _array = new int[_length];
            for (int i = 0; i < _length; i++)
            {
                _array[i] = i + 1;
            }
        }
        public override void FindMiddle()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                _middle += _array[i];
            }
            _middle = _middle / _array.Length;
        }

        public override void WriteAll()
        {
            Console.WriteLine("Одномерный массив:");
            for (int i = 0; i < _array.Length; i++)
            {
                Console.Write(_array[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Среднее арифметическое массива - " + _middle);

        }
    }
}

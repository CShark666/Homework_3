using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_1
{
    internal class MyArray : IOutput, IMath, ISort
    {
        private int[] _myArray;

        public MyArray(int[] array)
        {
            this._myArray = array; 
        }
        public void Show()
        {
            Console.WriteLine("Array elements: ");
            foreach (var item in _myArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }

        public int Max()
        {
            return _myArray.Max();
        }
        public int Min()
        {
            return _myArray.Min();
        }

        public float Avg()
        {
            return (float)_myArray.Average();
        }

        public bool Search(int value)
        {
            foreach (var item in _myArray)
            {
                if (item == value)
                    return true;
            }
            return false;
        }

        public void SortAsc()
        {
            Array.Sort(_myArray);
        }
        public void SortDesc()
        {
            Array.Sort(_myArray);
            Array.Reverse(_myArray);
        }
        public void SortByParam(bool parameter)
        {
            if (parameter)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }

        }
    }
}

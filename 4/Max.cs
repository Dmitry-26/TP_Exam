using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Max
    {
        private double max;

        public string Searching(double[] array)
        {
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                }
            }
            return max.ToString();
        }
    }
}

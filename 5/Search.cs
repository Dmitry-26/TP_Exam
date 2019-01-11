using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Search
    { 
        public double newMax;

        public double oldMax;

        public string Searching(double[] array)
        {
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (newMax < array[i])
                { 
                    oldMax = newMax;
                    newMax = array[i];
                }
                else
                {
                    if (oldMax < array[i])
                    {
                        oldMax = array[i];
                    }
                }
            }
            return (oldMax * newMax).ToString();
        }
    }
}

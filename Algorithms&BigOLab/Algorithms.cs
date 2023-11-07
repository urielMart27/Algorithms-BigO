using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_BigOLab
{
    public static class Algorithms
    {
        //Task 1
        // O(1) Constant Time
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Task 2 
        // O(n) Linear Time 
        public static bool IsLessThan100(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number >= 100)
                {
                    return false;
                }
            }
            return true;
        }


        //Task 3 
        // 0(n) Linear Time
        public static bool IsNameRepeated(List<string> names)
        {
            HashSet<string> singleNames = new HashSet<string>();

            foreach (string name in names)
            {
                if (singleNames.Contains(name))
                {
                    return true;
                }
                else
                {
                    singleNames.Add(name);
                }
            }
            return false;

        }
        

    }
}
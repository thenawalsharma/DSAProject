using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAProject
{
    public class Utility
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}

/*
 * Why use Generics?
 * Reusability: Ek hi method har type ke data ke liye use hoti hai.
 * Type Safety: Compile time pe hi error pakad leti hai.
 * Performance: Boxing/unboxing avoid hota hai (value types ke liye).
 * 
 */

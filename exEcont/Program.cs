using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exEcont
{
    class Program
    {
        static int[,] myArray1 = new int[2, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
        static int[,] myArray2 = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
        static int[,] myArray3 = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

        static void Main(string[] args)
        {
            int[,] arr1 = getArray("Enter name of 1st array ('arr1' 'arr2' 'arr3'): ");
            int[,] arr2 = getArray("Enter name of 2nd array ('arr1' 'arr2' 'arr3'): ");
            bool valid = checkValid(arr1, arr2);
            if (valid)
            {
                int[,] arrResult = doMult(arr1, arr2);
                displayArray(arr1);
                Console.WriteLine("multiplied by: ");
                displayArray(arr2);
                Console.WriteLine("is: ");
                displayArray(arrResult);
            }
            else
            {
                Console.WriteLine("Sorry, these two arrays cannot be multiplied.");
            }
            Console.ReadLine();
        }

        static int[,] doMult(int[,] arr1, int[,] arr2)
        {
            int[,] result = new int [arr1.GetLength(0),arr2.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    for (int k = 0; k < arr2.GetLength(1); k++)
                    {
                        result[i, j] += (arr1[i, k] * arr2[k, j]);
                    }
                }
            }
            return result;
        }

        static int [,] getArray(string s)
        {
            Console.Write(s);
            string arg = Console.ReadLine();
            switch (arg)
            {
                case "arr1":
                    return myArray1;
                case "arr2":
                    return myArray2;
                case "arr3":
                    return myArray3;
                default:
                    return myArray1;
            }
        }

        static bool checkValid(int[,] arr1, int[,] arr2)
        {
            bool valid;
            if (arr1.GetLength(1) == arr2.GetLength(0))
            {
                valid = true;
            }
            else
            {
                valid = false;
            }
            return valid;
        }

        static void displayArray(int[,] arr)
        {
            Console.Write("\n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}

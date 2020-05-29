using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace _2D_Array___D
{
    class Program
    {



        static void Main(string[] args)
        {

            int[][] arr = new int[6][];
            arr[0] = new int[6] { 1, 1, 1, 0, 0, 0 };
            arr[1] = new int[6] { 0, 1, 0, 0, 0, 0 };
            arr[2] = new int[6] { 1, 1, 1, 0, 0, 0 };
            arr[3] = new int[6] { 0, 0, 2, 4, 4, 0 };
            arr[4] = new int[6] { 0, 0, 0, 2, 0, 0 };
            arr[5] = new int[6] { 0, 0, 1, 2, 4, 0 };
            int result = hourglassSum(arr);
            Console.Write(result);
            Console.Read();
        }


        static int hourglassSum(int[][] arr)
        {
            int[,] mascara = new int[3, 3] { { 1, 1, 1 },
                                             { 0, 1, 0 },
                                             { 1, 1, 1 }};
            List<int> list = new List<int>();
            int tem1, tem2;
            for (int i=1; i<5;i++)
            {
                for (int j = 1; j <5; j++)
                {
                    tem1 = i; tem2 = j; int sumatoria = 0;
                    for (int x = 0; x <= 2; x++)
                    {
                        for (int y = 0; y <= 2; y++)
                        {
                            if (mascara[x, y] == 1)
                            {
                                sumatoria = sumatoria + arr[tem1 - 1][tem2 - 1];
                            }
                            tem2++;
                        }
                        tem1++; tem2 = j;
                    }
                    list.Add(sumatoria);
                }
            }
            return list.Max();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/*
 * 题目描述

明明想在学校中请一些同学一起做一项问卷调查，为了实验的客观性，他先用计算机生成了N个1到1000之间的随机整数（N≤1000），对于其中重复的数字，只保留一个，把其余相同的数去掉，不同的数对应着不同的学生的学号。然后再把这些数从小到大排序，按照排好的顺序去找同学做调查。请你协助明明完成“去重”与“排序”的工作。
 
 
Input Param 
     n               输入随机数的个数     
 inputArray      n个随机整数组成的数组 
     
Return Value
     OutputArray    输出处理后的随机整数
 

注：测试用例保证输入参数的正确性，答题者无需验证。测试用例不止一组。

 
 

输入描述:
输入多行，先输入随机整数的个数，再输入相应个数的整数


输出描述:
返回多行，处理后的结果

输入例子:
11
10
20
40
32
67
40
20
89
300
400
15

输出例子:
10
15
20
32
40
67
89
300
400
 */
namespace _3_明明的随机数
{
    class Program
    {
        static void Main(string[] args)
        {

             int length= 0;
            while ((length = Convert.ToInt32(Console.ReadLine())) > 0)
            {
//                int length = int.Parse(Console.ReadLine());
                int[] ints = new int[length];
                for (int i = 0; i < length; i++)
                {
                    ints[i] = int.Parse(Console.ReadLine());
                }
                SelectSort(ints);
                //输出的时候做些小手脚
                int head = 0;
                int end = 0;
                while (end < length)
                {
                    if (ints[end] == ints[head])
                    {
                        end++;
                        continue;
                    }
                    Console.WriteLine(ints[head]);
                    head = end;
                }
                if (head != length)
                {
                    Console.WriteLine(ints[length - 1]);
                }
            }
//            QuickSort(ints);
           
           
        }

        private static void SelectSort(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                int min = i;
                for (int j = i+1; j < length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                Exch(array,i,min);
            }
        }

        private static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int lo, int hi)
        {
            if (hi <= lo)
                return;
            int j = Partitiion(array, lo, hi);
            QuickSort(array, 0, j - 1);
            QuickSort(array, j + 1, hi);
        }

        private static int Partitiion(int[] array, int lo, int hi)
        {
            int i = lo, j = hi + 1;
            int v = array[lo];

            while (true)
            {
                while (array[++i] < v)
                {
                    if (i == hi)
                    {
                        break;
                    }
                }
                while (v < array[--j])
                {
                    if (j == lo)
                    {
                        break;
                    }
                }
                if (i >= j)
                {
                    break;
                }
                Exch(array, i, j);
            }
            Exch(array, lo, j);
            return j;
        }

        private static void Exch(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 题目描述

计算字符串最后一个单词的长度，单词以空格隔开。

输入描述:
一行字符串，非空，长度小于5000。


输出描述:
整数N，最后一个单词的长度。

输入例子:
hello world

输出例子:
5
 */
namespace _1_计算字符串最后一个字符长度
{
    class Program
    {
        static void Main(string[] args)
        {
//            string line;
//            while ((line = System.Console.ReadLine()) != null)
//            {//注意while处理多个case
//                string[] tokens = line.Split();
//                Console.WriteLine(tokens[tokens.Length-1].Length);
//            }
            string line = Console.ReadLine();
            int j = 0;
            for (int i = line.Length-1; i >=0; i--)
            {
                if (line[i] !=' ')
                {
                    j++;
                }
                else
                {
                    Console.WriteLine(j);
                    return;
                }
            }
            Console.WriteLine(j);
        }
    }
}

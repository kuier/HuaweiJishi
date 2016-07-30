using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 题目描述

写出一个程序，接受一个有字母和数字以及空格组成的字符串，和一个字符，然后输出输入字符串中含有该字符的个数。不区分大小写。

输入描述:
输入一个有字母和数字以及空格组成的字符串，和一个字符。


输出描述:
输出输入字符串中含有该字符的个数。

输入例子:
ABCDEF
A

输出例子:
1
 */
namespace _2_计算字符个数
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string zifu = Console.ReadLine();
            char c ;
            try
            {
                c = char.Parse(zifu);
            }
            catch (Exception)
            {
                Console.WriteLine("第二个输入不正确");
                return;
            }
            if (line == "" || zifu == "" )
            {
                Console.WriteLine("请按规定输入字符");
                return;
            }
            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == c)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

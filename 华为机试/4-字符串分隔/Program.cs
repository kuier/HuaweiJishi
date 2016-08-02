using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * •连续输入字符串，请按长度为8拆分每个字符串后输出到新的字符串数组；
•长度不是8整数倍的字符串请在后面补数字0，空字符串不处理。

输入描述:
连续输入字符串(输入2次,每个字符串长度小于100)


输出描述:
输出到长度为8的新字符串数组

输入例子:
abc
123456789

输出例子:
abc00000
12345678
90000000
 */
namespace _4_字符串分隔
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine())!=null)
            {
                PrintString(line);
            }
        }

        private static void PrintString(string s)
        {
            int i = 0;
            char[] output = new char[8];
            while (i<s.Length)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i+j<s.Length)
                    {
                        output[j] = s[i + j];
                    }
                    else
                    {
                        output[j] = '0';
                    }
                }
                Console.WriteLine(new string(output));
                i += 8;
            }
        }
    }
}

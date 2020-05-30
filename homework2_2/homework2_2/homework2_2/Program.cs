using System;
using System.Collections.Generic;
namespace ArrayCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1; string s; double[] answer; bool endInput = false;
            
            
                List<int> num = new List<int>();
                Console.WriteLine("请输入一个整型数组");
                do
                {
                    Console.WriteLine("请输入第" + i + "个数,输入end以终止");
                    s = Console.ReadLine();
                    if (s != "end")
                    {
                        endInput = false;
                        try
                        {
                            num.Add(int.Parse(s));
                            i++;
                        }
                        catch
                        {
                            Console.WriteLine("输入非法!请重新输入第" + i + "个数!");
                        }
                    }
                    else
                    {
                        endInput = true;
                    }
                } while (!endInput);
                answer = arrayCalculation(num);
                Console.WriteLine("数组的大小为:" + num.Count);
                Console.WriteLine($"最大值:{answer[0]},最小值:{answer[1]},总和:{answer[2]},平均值:{answer[3]}");
                
            
        }
        static double[] arrayCalculation(List<int> num)
        {
            double[] result = new double[4];
            result[0] = num[0];
            result[1] = num[0];
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i] >= result[0]) result[0] = num[i];
                if (num[i] <= result[1]) result[1] = num[i];
                result[2] += num[i];
            }
            result[3] = result[2] / num.Count;
            return result;
        }
    }
}

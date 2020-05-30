using System;

namespace homework2_1
{
    class Program
    {
        
        

        static public Boolean Fun2(int y)
        {
            int t;
            for (t = 2; t < y; t++)
            {
                if (t % y == 0)
                {
                    return false;
                }
            }
            return true; 
        }

        static public void Fun1(int x) {
            int y;
            for (y=1;y<=x;y++)
            {
                if (x % y == 0)
                {
                    if (Fun2(y) == true)
                    {
                        Console.Write(y + " ");
                    }
                }
                
            }
        }

        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                int a = int.Parse(input);
                if (a <= 0)
                {
                    throw new Exception(message: "输入错误，请输入正整数");
                }

                Console.WriteLine("该数素数因子有：");
                Program.Fun1(a);

            }
            catch (Exception e) {
                Console.WriteLine("Error"+e);
            }


        }

    }
}

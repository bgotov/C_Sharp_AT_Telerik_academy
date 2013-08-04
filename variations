//20.Write a program that reads two numbers N and K
//and generates all the variations of K elements 
//from the set [1..N]. Example:
// N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1},
// {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}


using System;
class Program
    {
        static void Main(string[] args)
        {   
    
            Console.WriteLine("enter n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter k");
            int k = int.Parse(Console.ReadLine());

            int zero = '0';
            int one = '1';
            Console.WriteLine(zero);
            Console.WriteLine(one);

            int begin = 0;
            int end = 0;
            for (int i = 0; i < k; i++)
            {
                begin = begin + 1* (int)Math.Pow(10, i);
            }
            Console.WriteLine(begin);
            for (int i = 0 ; i < k; i++ )
            {
                end = end + k * (int)Math.Pow(10, i);
            }
            Console.WriteLine(end);
            string output = "";
            for (int i = begin; i <= end; i++)
            {   
                char[] string2CharArray = new char[(i+"").Length];
                string2CharArray = (i+"").ToCharArray(0, (i+"").Length);
                Array.Sort(string2CharArray);
                if( (string2CharArray[string2CharArray.Length-1] - 48) > n) continue; //-48 convert char to int 
                if( (string2CharArray[0] -48 ) <= 0) continue;
                output = output +i +", ";
            }
            Console.WriteLine(output);
        }
    }


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFpswCracker
{
    class pwdCracker
    {
        static char[] dic = {'a', 'b', 'c', 'd', 'e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                               'A', 'B', 'C', 'D', 'E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                             '0','1','2','3','4','5','6','7','8','9'};

        static void doCrack(string pwd, int pos, int size)
        {
            if(pos < size)
            {
                foreach(char c in dic)
                {
                    doCrack(pwd + c, pos + 1, size);
                }
            }
            else
            {
                Console.WriteLine(pwd);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Password Length? ");
            int pwdLength = Convert.ToInt32(Console.ReadLine());
            var watch = System.Diagnostics.Stopwatch.StartNew();
            doCrack("", 0, pwdLength);
            watch.Stop();
            Console.WriteLine("Time taken:{0}ms", watch.Elapsed.TotalMilliseconds);
            Console.ReadLine();
        }
    }
}
//Time complexity O(S^n)  S= number of characters in the dictionary, n = password length
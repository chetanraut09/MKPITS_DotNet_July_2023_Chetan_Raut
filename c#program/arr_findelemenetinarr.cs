using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arr_findelementinarr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, };
            int mila = 0;
            int username;
            Console.WriteLine("enter number to be searched");
            username = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<num.Length;i++)
            {
                if (num[i]==username)
                {
                    mila = 1;
                    break;

                }
            }
            if(mila==1)
            {
                Console.WriteLine("mum{0} is found in an array", username);

            }
            else
            {
                Console.WriteLine("number is not found in an array");

            }
            Console.ReadKey();

        }
    }
}

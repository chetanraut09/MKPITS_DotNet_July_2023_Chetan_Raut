using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi17_profit_loss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sell, cost, profit, loss;
            Console.WriteLine("enter cost prize");
            cost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter selling prize");
            sell = Convert.ToInt32(Console.ReadLine());
           if (cost < sell)
            {
                profit = sell - cost;
                Console.WriteLine("\nYou can book your profit amount: Rs. " + profit);
            }
            else if ( cost == sell)
            {
                 Console.WriteLine("\nNo Profit and Loss occures");
            }
            else
            {
                loss = cost - sell;
                Console.WriteLine("\nYou will loss amount: Rs. " + loss );
            }
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexoutofrangeexception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;

            try
            {
                for(int i=0;i<=3;i++)
                {
                    Console.WriteLine(i);
                }
            }
            catch(IndexOutOfRangeException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Finally found");
            }
            Console.WriteLine("bye");
            
        }
    }
}

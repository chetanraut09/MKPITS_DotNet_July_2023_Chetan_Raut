using System;
namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[3];
            int[] arr2 = new int[3];
            Console.WriteLine("input the no of elelement to store in the arr:3");
            Console.WriteLine("input no of elements in the array");
            for (int i = 0; i < 3; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("element-{0}={1}:", i, arr1[i]);
            }
            Console.Write("\n");
            Console.WriteLine("the values store into the array are:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}", arr1[i]);
            }
            Console.Write("\n");
            Console.Writw("element of array 1");
            for (int i = 0; i < 3; i++)
            {
                arr2[i] = arr1[i];
                Console.write(arr1[i]);
                {

                    Console.Write("\n");
                    Console.Write("Element copied in array 2");
                    for (i = 0; i < 3; i++)
                    {
                        Console.Write(arr2[i]);
                    }

                    Console.ReadKey();
                }
            }
        }
    
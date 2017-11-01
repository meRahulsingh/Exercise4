using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellProj_Datastructures_Memory
{
    public class Queue
    {
        public void TestQueue()
        {
            Console.Clear();
            Console.WriteLine("welcome to Examine Queue!...\n");
            Console.WriteLine("Enter the input..\n");

            Queue<string> queue = new Queue<string>();
            bool check = true;
            while (check)
            {


                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please give the proper string to enter in to the queue!...");
                }
                else
                {

                    char str = input[0];
                    string value = input.Substring(1);
                

                switch (str)
                {
                        case '+':
                            Console.Clear();
                            queue.Enqueue(value);
                            Console.WriteLine("\n Name added to the queue...");
                            Console.WriteLine("You have added"+value+"in the queue..\n");
                            Console.ReadLine();
                            Console.WriteLine("The number of elements in the Queue after adding:{0}",queue.Count);
                            break;

                        case '-':

                            Console.Clear();
                            while(queue.Count>0)
                                Console.WriteLine(queue.Dequeue());
                            Console.WriteLine("\n Name removed from the queue....");
                            Console.ReadLine();
                            Console.WriteLine("The number of elements in the Queue after adding:{0}", queue.Count);

                            break;

                        default:
                            Console.WriteLine("Invalid input,please enter a correct input..\n");
                            break;
                    }

                    foreach (var queues in queue)
                    {
                        Console.WriteLine("\n The queue contains:\n" + queues);
                    }

                    return;
                }

            }
        }

    }
    }


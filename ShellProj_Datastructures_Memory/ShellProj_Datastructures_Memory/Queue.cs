
using System;
using System.Collections;
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

            Queue<string> queue = new Queue<string>();
            do
            {


                Console.WriteLine("\n\n !!!!!!!welcome to Examine Queue!!!!!!...\n");

                Console.WriteLine("Enter '1' to add in the queue..\n");

                Console.WriteLine("Enter '2' to remove from the queue..\n");

                Console.WriteLine("Enter '3' to return to main menu..\n");
                char input = ' ';
                try
                {
                    input = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("\n Please enter some input!..");
                }

                string value;
                switch (input)
                {
                    case '1':


                        Console.WriteLine("\n Enter a name to enter into the queue..");
                        value = Console.ReadLine();
                        queue.Enqueue(value);
                        Console.WriteLine("\n ***Name Added to the Queue***...");
                        Console.WriteLine("\n You have added "  + value +  " in the queue..");
                        Console.WriteLine("\n You are the "  + queue.Count +  "person to enter in to the Queue");




                        break;
                    case '2':

                       if(queue.Count > 0)
                            Console.WriteLine(queue.Dequeue());
                        Console.WriteLine("\n *** Name removed from the Queue ***....");
                        Console.ReadLine();
                        Console.WriteLine("\n The number of names in the Queue after removing:{0}", queue.Count);

                        break;
                    case '3': return;

                    default:
                        Console.WriteLine("\n Invalid input,please enter a correct input..\n");
                        break;

                         }
                foreach (var queues in queue)
                {
                    Console.WriteLine("\n The members in the Queue are:\n" + queues);
                }

            } while (true);
                }
            }
        }
    



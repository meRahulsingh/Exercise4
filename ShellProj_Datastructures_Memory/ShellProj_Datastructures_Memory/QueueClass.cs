using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellProj_Datastructures_Memory
{
  public  class QueueClass
    {
        public void TestingQ()
        {
            Console.Clear();
            Queue newQ = new Queue();
            Console.WriteLine("1.Add or Remove to queue");
            Console.WriteLine("a. To add a name from the list use | + |");
            Console.WriteLine("b. To remove a name from the list use  | - |");
            Console.WriteLine("c. To exit from this program use | 0 |");
            

            bool AddedinQ = true;
            while (AddedinQ)
            {
                Console.WriteLine("\n*********************************\n*********************************\nADD or DELETE A VALUE\n*********************************\n*********************************\n");
                string NewAddition = Console.ReadLine();
                //string newaddition1 = NewAddition;
              
                if (!string.IsNullOrWhiteSpace(NewAddition))
                {
                    string value = NewAddition.Substring(1);
                    char nav = NewAddition[0];
                  switch (nav)
                    {
                        case '+':
                            newQ.Enqueue(value);
                            Console.WriteLine("The current queue capacity is :" + newQ.Count);
                            
                            foreach (var I in newQ)
                            {
                                Console.WriteLine("The current queue capacity is : "+ I);

                            }
                            
                            //Console.ReadLine();
                             break;
                        case '-':
                            if(newQ.Count <= 0)
                            {
                                Console.WriteLine("Nothing to delete");
                            }
                            else {
                                newQ.Dequeue();
                            Console.WriteLine("The current queue capacity is :" + newQ.Count);
                                foreach (var I in newQ)
                                {
                                    Console.WriteLine("The current queue capacity is : " + I);

                                }
                                
                            }
                            break;
                        case '0':
                            Console.Clear();
                            return;
                        default:
                            Console.WriteLine("Invalid input");
                            break; ;
                    }
                    //Console.ReadLine();
                }
                }
                }
        }
    }

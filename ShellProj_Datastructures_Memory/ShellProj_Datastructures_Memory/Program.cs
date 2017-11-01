using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellProj_Datastructures_Memory
{
    public class Program
    {
        ///Swapna
        /// The main method, will handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        public static void Main()
        {

           

            bool run = true;
            while (true)
            {
                
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        public static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
            Console.Clear();
            Console.WriteLine("welcome to Examine list!...");
            Console.WriteLine("\n Enter  the name starting with '+' or  '-' \n");

            List<string> theList = new List<string>();
            bool check = true;
            while (check)
            {


                string input =Console.ReadLine();
                          
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter  the correct input!...");
                }
                else
                {
                   
                    char nav = input[0];
                    string value = input.Substring(1);


                    switch (nav)
                    {



                        case '+':
                            Console.Clear();
                            
                            Console.WriteLine("\n Input added to the list...");
                            theList.Add(value);
                            Console.WriteLine("\n Capacity of the list after adding the input: {0}\n", theList.Capacity);
                            Console.WriteLine("\n Count of the list after adding the input: {0}\n", theList.Count);

                            break;

                        case '-':
                            
                            
                                theList.Remove(value);
                                Console.WriteLine("\n Input removed from the list....");
                                Console.WriteLine("\n Capacity of the list after removing the input: {0}", theList.Capacity);
                                Console.WriteLine("\n Count of the list after removing the input: {0}", theList.Count);
                                Console.ReadLine();
                           
                            break;

                        default:
                            Console.WriteLine("Invalid Input,Please enter the string starting with '+' or '-'`\n");
                            break;
                    }

                    foreach (var item in theList)
                    {
                        Console.WriteLine("\n The items in the list are:\n" + item);
                    }

                    return;
                }

            }
        }


        

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
       public  static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Queue q1 = new Queue();
            q1.TestQueue();













        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
      public   static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        public static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})]
             * Example of incorrect: (()]), [), {[()}]
             */
        }

    }
}

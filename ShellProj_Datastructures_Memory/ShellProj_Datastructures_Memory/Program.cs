using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellProj_Datastructures_Memory
{
    class Program
    {
        /// <summary>
        /// The main method, will handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            bool run = true;
            while (run == true)
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
        static void ExamineList()
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
            Console.WriteLine("1.Add or Remove");
            Console.WriteLine("a. To add a name from the list use | + |");
            Console.WriteLine("b. To remove a name from the list use  | - |");
            Console.WriteLine("c. To exit from this program use | e |");
            List<string> theList = new List<string>();




            bool strNameCheck = true;
            while (strNameCheck == true)
            {
               
                string strName = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(strName))
                {
                   Console.WriteLine("Blank spaces not allowed");
                }
                else
                {
                    string value = strName.Substring(1);
                    char nav = strName[0];

                    switch (nav)
                    {
                        case '+':

                            theList.Add(value);
                            Console.WriteLine("Name Added");
                            Console.WriteLine("You have added " + value + " to the list");
                            Console.WriteLine("The List Capacity is " + theList.Capacity);
                            Console.WriteLine("The List count is " + theList.Count);
                            foreach (var item in theList)
                            {
                                Console.WriteLine("The List currently consists of " + item);
                            }
                            //Console.ReadLine();
                            break;
                        case '-':
                            if (theList.Contains(value))
                            {
                                theList.Remove(value);
                                Console.WriteLine("Name Removed");
                                Console.WriteLine("You have removed " + value + " to the list");
                                Console.WriteLine("The List Capacity is " + theList.Capacity);
                                Console.WriteLine("The List count is " + theList.Count);
                                foreach (var item in theList)
                                {
                                    Console.WriteLine("The List currently consists of " + item);
                                }
                                //Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("List does not contain this value to remove");
                            }
                            break;
                        case 'e':
                            Console.Clear();
                            Main();
                            return;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
                //Console.ReadLine();

            }
        }

        //switch(nav){...}


        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            QueueClass qall = new QueueClass();
            qall.TestingQ();
            /*
  * Loop this method untill the user inputs something to exit to main menue.
  * Create a switch with cases to enqueue items or dequeue items
  * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
 */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})]
             * Example of incorrect: (()]), [), {[()}]
             */
        }


    }
}

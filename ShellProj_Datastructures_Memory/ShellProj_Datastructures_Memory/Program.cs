using System;
using System.Collections;
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


            Queue q1 = new Queue();
            bool run = true;
            while (run)
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
                        //q1.TestQueue();
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
            Console.WriteLine("\n Enter  the name starting with '+'  (To Add)");
            Console.WriteLine("\n Enter  the name starting with '-'  (To Remove)");
            Console.WriteLine("\n To return to main menu,enter  '?' ");

            List<string> theList = new List<string>();
            bool check = true;
            while (check==true)
            {

                foreach (var item in theList)
                {
                    Console.WriteLine("The items in the list are:\n" + item);
                }

                Console.WriteLine("Enter the input starting with '+' or '-'..\n");
                string input = Console.ReadLine();

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
                        case '?': return;

                        default:
                            Console.WriteLine("Invalid Input,Please enter the string starting with '+' or '-'`\n");
                            break;
                    }

                    

                   
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
            Stack<string> testStack = new Stack<string>();
            Console.WriteLine("\n !..Welcome to Examine Stack...");
            Console.WriteLine("\n To reverse a word press | + |");
            Console.WriteLine("\n To exit the program press | 0 |");

            do
                           {
                Console.WriteLine("\n Press 1 to Push," +
                "\n Press 2 to Pop,\n Press 3 to Reverse a String\n press 0 to quit ");
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
 Console.WriteLine("Please provide input:");
                    string name = Console.ReadLine();
                    testStack.Push(name);
                    foreach (var item in testStack)
                                               {
                    Console.WriteLine("Names in the stack are " + item);
                                            }
                    Console.WriteLine("Count in the stack: " + testStack.Count);
                                            break;
                                     case '2':
                         if (testStack.Count > 0)
                                                {
                        Console.WriteLine("Implementing Last In First Out");
                        Console.WriteLine("Name removed from the stack is " + testStack.Pop());
                                                    foreach (var item in testStack)
                                                        {
                            Console.WriteLine("Names in the stack are " + item);
                                                       }
                        Console.WriteLine("Count in the stack :" + testStack.Count);
                                               }
                                            else
                         {
                        Console.WriteLine("Stack is empty,name cannot be deleted");
                                                }
                                           break;
                                        case '3':
 Console.WriteLine("Enter some input value");
                    string inputString = Console.ReadLine();
                    Stack < string > inputStack = new Stack<string>();
                                            for (int i = 0; i < inputString.Length; i++)
                        inputStack.Push(inputString.Substring(i, 1));
                    string resultstring = string.Empty;
                                            for (int i = 0; i < inputString.Length; i++)
                    resultstring += inputStack.Pop();
                    Console.WriteLine("Reversed string is " + resultstring);
                                            break;
                    
                    
                                   }














            }

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

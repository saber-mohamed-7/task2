using System.ComponentModel.Design;
using System.Globalization;

namespace task2_menu_selection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List <int> nums = new List <int> {1,2,5,3,8,11,22};

            char x;
            int total =0;
            int smalis = nums[0];
            double avg =0;
            int largest = nums[0];
            int count = nums.Count;
            

            do
            {

                Console.WriteLine("*******************************************");

                Console.WriteLine(" P - Print numbers\r\n " +
                    "   A - Add a number\r\n " +
                    "   M - Display mean of the numbers\r\n " +
                    "   S - Display the smallest number\r\n  " +
                    "  L - Display the largest number\r\n  " +
                    "  F - Find a number\r\n    C - Clear list\r\n " +
                    "   Q - Quit\r\n");

                Console.Write("select choes to process ==>");

                x = char.ToUpper(Convert.ToChar(Console.ReadLine()));

                if (x == 'A')
                {
                    int num_add;

                    Console.WriteLine("enter the number you need add");
                    num_add = Convert.ToInt32(Console.ReadLine());

                    nums.Add(num_add);
                    Console.WriteLine(num_add + " is added");

                }



                else if (x == 'P')
                {
                    if (nums.Count() == 0)
                        Console.WriteLine(" [] - the list is empty");
                    else
                        Console.WriteLine("[" + String.Join(" ", nums) + "]");
                }



                else if (x == 'M')
                {
                    if (nums.Count > 0)
                    {
                   
                        for (int c = 0; c < nums.Count; c++)
                        {
                            total = total + nums.ElementAt(c);

                        }

                        avg = total / count;
                        Console.WriteLine("the mean is : "+avg);
                        
                    }
                    else
                        Console.WriteLine("the list is empty.......");

                }



                else if (x == 'S')
                {

                    if (nums.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number - list is empty");
                    }

                    else
                    {

                        for (int i = 1; i < nums.Count(); i++)
                        {
                            if (nums[i] < smalis)
                            {
                                smalis = nums[i];

                            }

                        }
                        Console.WriteLine("the smalist number is : " + smalis);
                    }

                }

                else if (x == 'L')
                {

                    if (nums.Count() == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number - list is empty");
                    }

                    else
                    {

                        for (int i = 1; i < nums.Count(); i++)
                        {
                            if (nums[i] > largest)
                            {
                                largest = nums[i];

                            }

                        }
                        Console.WriteLine("the largist number is : " + largest);
                    }

                }

                else if (x == 'F')
                {

                    Console.Write("enter the number you need found :");
                    int num_found = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] == num_found)
                        {
                            
                            Console.WriteLine("it found in index : " + i);
                        }
                       else
                            Console.WriteLine("the number not found (^_^)");

                       } 

                    
                    

                     }

                else if (x == 'Q')
                {
                    Console.WriteLine("*** Good Buy ***");

                    break;

                }

                else if (x == 'C')
                {
                    for (int i = nums.Count - 1; i >= 0; i--)
                    {
                        nums.RemoveAt(i);


                    }

                   // nums.Clear();  //انا عملت الجذء دة  removeat علشان فيها فكره الي هي  العد بالعكس   


                    Console.WriteLine("complit remove list");
                }

                else

                    Console.WriteLine("errrrrorrrrr");



            }
            while (x !='Q');
        }
    }
}

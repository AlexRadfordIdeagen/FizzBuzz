using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {

        static bool rule3;
        static bool rule5;
        static bool rule7;
        static bool rule11;
        static bool rule13;
        static bool rule17;

        static void Main(string[] args)
        {
            int count;

            Console.WriteLine("Please enter how many numbers to count");
            count = int.Parse(Console.ReadLine());


            rule3 = RuleCheck(3);
            rule5 = RuleCheck(5);
            rule7 = RuleCheck(7);
            rule11 = RuleCheck(11);
            rule13 = RuleCheck(13);
            rule17 = RuleCheck(17);

            for (int i = 1; i < count + 1; i++)
            {
                string result = "";
                if (i % 11 == 0 && rule11)
                {
                    
                        result = MultipleOf13(i) + "Bong";
                    

                }

                else
                {
                    if (i % 17 == 0)
                    {
                        if (rule17)
                        {
                            result += MultipleOf17(i);
                        }

                    }
                    else
                    {
                        if (rule3)
                        {

                            result += MultipleOf3(i);
                        }
                        if (rule5)
                        {
                            result += MultipleOf5(i);

                        }
                        if (rule7)
                        {
                            result += MultipleOf7(i);

                        }
                        if (rule13)
                        {
                            result += MultipleOf13(i);
                        }
                    }
                }

                if (result == "")
                {
                    Console.WriteLine(i);
                }

                else
                    Console.WriteLine(result);
            }
            Console.ReadLine();
        }

        private static bool RuleCheck(int v)
        {
            Console.WriteLine("Would you like to allow the " + v + " rule? Y/N");
            string ruleSystem = Console.ReadLine();
            if (ruleSystem == "y")
                return true;
            else
                return false;
        }

        private static string MultipleOf3(int i)
        {
            if (i % 3 == 0)
            {

                return "Fizz";
            }
            return "";
        }

        private static string MultipleOf5(int i)
        {
            if (i % 5 == 0)
            {

                return "Buzz";
            }
            return "";
        }

        static string MultipleOf7(int number)
        {
            if (number % 7 == 0)
            {

                return "Bang";
            }

            return "";
        }
        private static string MultipleOf13(int i)
        {
            if (i % 13 == 0)
            {

                return "Fezz";
            }

            return "";
        }
        private static string MultipleOf17(int i)
        {
            if (i % 17 == 0 && rule17)
            {
                


                    string backwardsResult = "";
                    if (rule13)
                    {
                        backwardsResult += MultipleOf13(i);

                    }
                if (rule7)
                {
                    backwardsResult += MultipleOf7(i);
                }
                if (rule5)
                {
                    backwardsResult += MultipleOf5(i);
                }
                if (rule3)
                {
                    backwardsResult += MultipleOf3(i);
                }
                    return backwardsResult;
                
            }
            return "";
        }




    }
}


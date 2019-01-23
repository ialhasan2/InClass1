using System;

namespace InClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            string tryAgain = "n";
            do
            {
                Console.WriteLine("What grade did you get in this class? Enter your score between 0 and 100");
                try
                {
                    string input = Console.ReadLine();
                    int score = int.Parse(input);
                    if ((score >= 0) && (score <= 100))
                    {
                        string letterGrade = CalculateGrade(score);
                        Console.WriteLine("Your letter grade is " + letterGrade);
                    }
                    else
                    {
                        Console.WriteLine("You entered {0} which is an invalid score!" +
                            "\nPlease try to run the program again with a value between 0 and 100", score);
                    }
                } // End of try
                catch
                {
                    Console.WriteLine("Please try to run the program again with an integer value!");
                } // End of catch
                Console.WriteLine("Do you want to check or try again? enter y");
                tryAgain = Console.ReadLine().ToLower();
            } while (tryAgain == "y");
        } // End of Main
        private static string CalculateGrade(int score)
        {
            string letterGrade = "";
            if (score >= 95)
            {
                letterGrade = "A+";
            }
            else if (score >= 90)
            {
                letterGrade = "A";
            }
            else if (score >= 87)
            {
                letterGrade = "A-";
            }
            else if (score >= 84)
            {
                letterGrade = "B+";
            }
            else if (score >= 80)
            {
                letterGrade = "B";
            }
            else if (score >= 77)
            {
                letterGrade = "B-";
            }
            else if (score >= 74)
            {
                letterGrade = "C+";
            }
            else if (score >= 70)
            {
                letterGrade = "C";
            }
            else if (score >= 67)
            {
                letterGrade = "C-";
            }
            else if (score >= 63)
            {
                letterGrade = "D+";
            }
            else if (score >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }
            return letterGrade;
        }
    }
}

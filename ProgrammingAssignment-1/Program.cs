// Name: Brian Gutt
// Date: February 10, 2026
// CPSC 23000 - Programming Assignment 1
// This is a credit card program where it takes 4 user inputs as age, address, income, and job and each value is calculated together to see if the user qualifies for a credit card as well as their total spending limit.



namespace ProgrammingAssignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // init point variable
            int points = 0;

            Console.Write("Enter Age".PadRight(31) + ": ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter years at current address".PadRight(31) + ": ");
            int addressYears = int.Parse(Console.ReadLine());

            Console.Write("Enter Annual Income".PadRight(31) + ": ");
            double income = double.Parse(Console.ReadLine());

            Console.Write("Enter years at current Job".PadRight(31) + ": ");
            int jobYears = int.Parse(Console.ReadLine());

            // age points
            if (age <= 20) points -= 10;
            else if (age <= 30) points += 0;
            else if (age <= 50) points += 20;
            else points += 25;

            // address points
            if (addressYears < 1) points -= 5;
            else if (addressYears <= 3) points += 5;
            else if (addressYears <= 8) points += 12;
            else points += 20;

            // income points
            if (income <= 15000) points += 0;
            else if (income <= 25000) points += 12;
            else if (income <= 40000) points += 24;
            else points += 30;

            // job points
            if (jobYears < 2) points -= 4;
            else if (jobYears <= 4) points += 8;
            else points += 15;

            // final decision calc
            if (points <= 20)
                Console.WriteLine("No Card issued");
            else if (points <= 35)
                Console.WriteLine("Card issued with $500 credit limit");
            else if (points <= 60)
                Console.WriteLine("Card issued with $2000 credit limit");
            else
                Console.WriteLine("Card issued with $5000 credit limit");
        }
    }
}

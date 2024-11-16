using System;

class KeyBoard
{
    static void Main()
    {
        Console.WriteLine("Select one of the programs below:");
        Console.WriteLine("1_ Prime number definer");
        Console.WriteLine("2_ Mirror number definer ");
        Console.WriteLine("3_ Decision Tree");

        string selection = Console.ReadLine();

        switch (selection)
        {
            case "1":
                PrimeNumberDefiner();
                break;

            case "2":
                MirrorNumberDefiner();
                break;

            case "3":
                DecisionTree();
                break;

            default:
                Console.WriteLine("Invalid input.");
                break;
        }
    }

    static void PrimeNumberDefiner()
    {
        Console.WriteLine("Enter a number to check if it's prime:");
        int num;
        if (int.TryParse(Console.ReadLine(), out num))
        {
            bool isPrime = true;

            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
                Console.WriteLine($"{num} is a prime number.");
            else
                Console.WriteLine($"{num} is not a prime number.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static void MirrorNumberDefiner()
    {
        Console.WriteLine("Enter a number to check if it's palindrome:");
        int num;
        if (int.TryParse(Console.ReadLine(), out num))
        {
            int originalNum = num;
            int reversedNum = 0;

            while (num > 0)
            {
                int remainder = num % 10;
                reversedNum = reversedNum * 10 + remainder;
                num /= 10;
            }

            if (originalNum == reversedNum)
                Console.WriteLine($"{originalNum} is a palindrome.");
            else
                Console.WriteLine($"{originalNum} is not a palindrome.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static void DecisionTree()
    {
        Console.WriteLine("Enter the exam score:");
        int score;
        if (int.TryParse(Console.ReadLine(), out score))
        {
            if (score < 10)
            {
                Console.WriteLine("You will fail. Study more, you lazy.");
            }
            else if (score >= 10 && score < 22)
            {
                Console.WriteLine("You are either Hosna, Setare, or some other smart student. Congrats!");
            }
            else
            {
                Console.WriteLine("Please stop wasting your time and study for your own sake.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}

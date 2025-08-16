namespace f;

public class History()
{

    static int answer1;
    static int answer2;
    static int answer3;
    static int answer4;
    static int points;








    public static void Q1()
    {
        Console.WriteLine("\n\n\nHISTORY QUESTION 1\n\n");
        Console.WriteLine("When did Constantinople fall? Type:\n");
        Console.WriteLine(" 1 for 1543\n 2 for 1354\n 3 for 1453\n 4 for 1253\n\n");


        while (!int.TryParse(Console.ReadLine(), out answer1))
        {
            Console.Clear();
            Console.Write("You entered an invalid number");
            Q1();
        }


        if (answer1 == 3)
        {
            points += 1;
            Console.Clear();
            Q2();
        }
        else if (answer1 == 1 || answer1 == 2 || answer1 == 4)
        {
            Console.Clear();
            Q2();
        }
        else
        {
            Console.Clear();
            Console.Write("Type only 1, 2, 3, or 4:");
            Q1();
        }

    }










    public static void Q2()
    {
        Console.WriteLine("\n\n\nHISTORY QUESTION 2\n\n");
        Console.WriteLine("When did the First World War begin? Type:\n");
        Console.WriteLine(" 1 for 1913\n 2 for 1914\n 3 for 1915\n 4 for 1912\n\n");


        while (!int.TryParse(Console.ReadLine(), out answer2))
        {
            Console.Clear();
            Console.Write("You entered an invalid number");
            Q2();
        }




        if (answer2 == 2)
        {
            points += 1;
            Console.Clear();
            Q3();
        }
        else if (answer2 == 1 || answer2 == 3 || answer2 == 4)
        {
            Console.Clear();
            Q3();
        }
        else
        {
            Console.Clear();
            Console.Write("Type only 1, 2, 3, or 4:");
            Q2();
        }


    }
    







    public static void Q3()
    {
        Console.WriteLine("\n\n\nHISTORY QUESTION 3\n\n");
        Console.WriteLine("When did the American Revolution begin? Type:\n");
        Console.WriteLine(" 1 for 1775\n 2 for 1789\n 3 for 1778\n 4 for 1774\n\n");


        while (!int.TryParse(Console.ReadLine(), out answer3))
        {
            Console.Clear();
            Console.Write("You entered an invalid number");
            Q3();
        }




        if (answer3 == 1)
        {
            points += 1;
            Console.Clear();
            Q4();
        }
        else if (answer3 == 2 || answer3 == 3 || answer3 == 4)
        {
            Console.Clear();
            Q4();
        }
        else
        {
            Console.Clear();
            Console.Write("Type only 1, 2, 3, or 4:");
            Q3();
        }


    }








    public static void Q4()
    {
        Console.WriteLine("\n\n\nHISTORY QUESTION 4\n\n");
        Console.WriteLine("How did Abraham Lincoln die? Type:\n");
        Console.WriteLine(" 1 for From an illness\n 2 for From a blade\n 3 for From self-killing \n 4 for From a gun\n\n");


        while (!int.TryParse(Console.ReadLine(), out answer4))
        {
            Console.Clear();
            Console.Write("You entered an invalid number");
            Q4();
        }




        if (answer4 == 4)
        {
            points += 1;
            Console.Clear();
            Completed();
        }
        else if (answer4 == 1 || answer4 == 2 || answer4 == 3)
        {
            Console.Clear();
            Completed();
        }
        else
        {
            Console.Clear();
            Console.Write("Type only 1, 2, 3, or 4:");
            Q4();
        }


    }
    




    public static void Completed()
    {
        Console.Clear();
        Console.WriteLine("You answered " + points + " out of 4 flashcards correctly!");
        Console.WriteLine("That is a "+points/4*100+"% of the questions answered correctly!\n\n");
        Console.WriteLine("That's the end of the demo. Bye!");
    }
}
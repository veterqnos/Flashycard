namespace f;

public class Math()
{

    static int answer1;
    static int answer2;
    static int answer3;
    static int answer4;
    static int points;



    public static void Q1()
    {
        Console.WriteLine("\n\n\nMATH QUESTION 1\n\n");
        Console.WriteLine("What is the square root of 625? Type:\n");
        Console.WriteLine(" 1 for 15\n 2 for 22.5\n 3 for 25\n 4 for 12.5\n\n");


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
        Console.WriteLine("\n\n\nMATH QUESTION 2\n\n");
        Console.WriteLine("What is x in this equation: 6x / 5 = 12 ? Type:\n");
        Console.WriteLine(" 1 for 11\n 2 for 10\n 3 for 12\n 4 for 13\n\n");


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
        Console.WriteLine("\n\n\nMATH QUESTION 3\n\n");
        Console.WriteLine("What is 30 * 23? Type:\n");
        Console.WriteLine(" 1 for 690\n 2 for 460\n 3 for 820\n 4 for 790\n\n");


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
        Console.WriteLine("\n\n\nMATH QUESTION 4\n\n");
        Console.WriteLine("What is 5 to the power of 3? Type:\n");
        Console.WriteLine(" 1 for 225\n 2 for 150\n 3 for 215\n 4 for 125\n\n");


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
    
    


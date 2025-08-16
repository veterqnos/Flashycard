namespace f;

public class MAIN
{

    public static int subject;


    public static void SubjectSelection()
    {
        Console.WriteLine("\n\n\nSelect subject by typing:\n 1 for Math\n 2 for History\n\n");

        try
        {
            subject = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
            SubjectSelection();
        }


        switch (subject)
        {
            case 1:
                Console.Clear();
                Math.Q1();
                break;
            case 2:
                Console.Clear();
                History.Q1();
                break;
            case 1225:
                Console.Clear();
                CF.CreateFlashcard();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Type only 1 or 2:");
                SubjectSelection();
                break;
        }
    }





    public static void Main()
    {

        Console.WriteLine("WELCOME TO TO THE PROTOTYPE!");

        SubjectSelection();

        Console.ReadKey();
    } 
}







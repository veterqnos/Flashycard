using System.Text.Json;

namespace f;

public class MAIN
{

    public static string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
    public static string slot1path = Path.Combine(appDataPath, "slot1.json");
    public static string slot2path = Path.Combine(appDataPath, "slot2.json");
    public static string slot3path = Path.Combine(appDataPath, "slot3.json");

    static int selectedSlot;




    public static void SubjectSelection()
    {

        if (!File.Exists(slot1path))
            File.WriteAllText(slot1path, "");
        if (!File.Exists(slot2path))
            File.WriteAllText(slot2path, "");
        if (!File.Exists(slot3path))
            File.WriteAllText(slot3path, "");

        string slot1content = File.ReadAllText(slot1path);
        string slot2content = File.ReadAllText(slot2path);
        string slot3content = File.ReadAllText(slot3path);

        if (slot1content == "" && slot2content == "" && slot3content == "")
        {
            Console.Write("All flashcards slots are either empty or couldn't be found. Press ENTER to access the flashcard creation page.\n>");
            Console.ReadKey();
            Console.Clear();
            Dev.CreateFlashcard();
            return;
        }






        Console.Write("\n\n\nSelect a flashcard by typing the corresponding number next to its name:\n 1\n 2\n 3\n\n>");
        while (!int.TryParse(Console.ReadLine(), out selectedSlot))
        {
            Console.Clear();
            SubjectSelection();
        }


        if (selectedSlot == 1 && slot1content == "")
        {
            while (selectedSlot == 1)
            {
                Console.Clear();
                Console.WriteLine("That slot is empty");

                Console.Write("\n\n\nSelect a flashcard by typing the corresponding number next to its name:\n 1\n 2\n 3\n\n>");
                while (!int.TryParse(Console.ReadLine(), out selectedSlot))
                {
                    Console.Clear();
                    SubjectSelection();
                }
            }
        }
        if (selectedSlot == 2 && slot2content == "")
        {
            while (selectedSlot == 2)
            {
                Console.Clear();
                Console.WriteLine("That slot is empty\n");

                Console.Write("\n\n\nSelect a flashcard by typing the corresponding number next to its name:\n 1\n 2\n 3\n\n>");
                while (!int.TryParse(Console.ReadLine(), out selectedSlot))
                {
                    Console.Clear();
                    SubjectSelection();
                }
            }
        }
        if (selectedSlot == 3 && slot3content == "")
        {
            while (selectedSlot == 3)
            {
                Console.Clear();
                Console.WriteLine("That slot is empty\n");

                Console.Write("\n\n\nSelect a flashcard by typing the corresponding number next to its name:\n 1\n 2\n 3\n\n>");
                while (!int.TryParse(Console.ReadLine(), out selectedSlot))
                {
                    Console.Clear();
                    SubjectSelection();
                }
            }
        }

        if (selectedSlot == 1 || selectedSlot == 2 || selectedSlot == 3)
        {
            Console.Clear();
            Dev.UseFlashcard(selectedSlot);
        }
        else if (selectedSlot == 1225)
        {
            Console.Clear();
            Dev.DevMode();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Type only 1, 2 or 3!");
            SubjectSelection();
        }


        /* switch (slot)
         {
             case 1:
                 if (existingJson1 == "")
                 {
                     Console.WriteLine();
                 }
                 break;
             case 2:
                 Console.Clear();
                 History.Q1();
                 break;
             case 3:
                 Console.Clear();
                 CF.CreateFlashcard();
                 break;
             default:
                 Console.Clear();
                 Console.WriteLine("Type only 1 or 2");
                 SubjectSelection();
                 break;
         }*/
    }





    public static void Main()
    {

        Console.WriteLine("WELCOME TO FLASHYCARD!");

        SubjectSelection();

        Console.ReadKey();
    }
}







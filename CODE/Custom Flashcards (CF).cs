using System.Text.Json;

namespace f;

public class Dev
{
    public string? Slot { get; set; }
    public string? Name { get; set; }
    public string? Question { get; set; }
    public string? Answer1 { get; set; }
    public string? Answer2 { get; set; }
    public string? Answer3 { get; set; }
    public string? Answer4 { get; set; }
    public string? correctAnswer { get; set; }

    static string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);




    public static void DevMode()
    {
        string selected;
        Console.Write("Welcome to Developer Mode! Choose an option\n 1. Create a flashcard\n 2. Delete a flashcard\n\n>");

        selected = Console.ReadLine();
        if (selected != "1" && selected != "2")
        {
            Console.Clear();
            Console.WriteLine("Type only 1 or 2!\n");
            DevMode();
        }

        if (selected == "1")
        {
            Console.Clear();
            CreateFlashcard();
        }
        if (selected == "2")
        {
            Console.Clear();
            DeleteFlashcard();
        }
    }






    public static void CreateFlashcard()
    {
        string? slot;
        string? name;
        string? question;
        string? answer1;
        string? answer2;
        string? answer3;
        string? answer4;
        string? correctanswer;


        void NextPage()
        {
            Console.Clear();
            Console.WriteLine("Flashcard Creation");
        }


        Console.WriteLine("Flashcard Creation");


        Console.Write("\nIn which slot would you want your flashcard to be saved?\n 1\n 2\n 3\n\n>");
        slot = Console.ReadLine();
        while (slot != "1" && slot != "2" && slot != "3")
        {
            Console.WriteLine("Only type 1, 2 or 3!\nIn which slot would you want your flashcard to be saved?\n 1\n 2\n 3\n\n>");
            slot = Console.ReadLine();
        }
        NextPage();


        Console.Write("\nHow do you want the flashcard to be named?\n>");
        name = Console.ReadLine();
        NextPage();

        Console.Write("\nWhat will be the question of the flashcard?\n>");
        question = Console.ReadLine();
        NextPage();

        Console.WriteLine("\nNow, what will be the 4 answers of the flashcard?");
        Console.Write("1: ");
        answer1 = Console.ReadLine();
        Console.Write("2: ");
        answer2 = Console.ReadLine();
        Console.Write("3: ");
        answer3 = Console.ReadLine();
        Console.Write("4: ");
        answer4 = Console.ReadLine();

        Console.Write("\nFinally, which answer of the flashcard is the correct one? (1,2,3,4)\n>");
        correctanswer = Console.ReadLine();
        while (correctanswer != "1" && correctanswer != "2" && correctanswer != "3" && correctanswer != "4")
        {
            Console.Write("Only type 1, 2, 3 or 4!\nWhich answer of the flashcard is the correct one?\n>");
            correctanswer = Console.ReadLine();
        }


        var cf = new Dev() //cf = custom flashcard
        {
            Slot = Path.Combine(appDataPath, "slot" + slot + ".json"),
            Name = name,
            Question = question,
            Answer1 = answer1,
            Answer2 = answer2,
            Answer3 = answer3,
            Answer4 = answer4,
            correctAnswer = correctanswer
        };


        string json = JsonSerializer.Serialize(cf, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(cf.Slot, json);
        Console.WriteLine("\n\n\nFlashcard saved to slot" + slot + ".json!\nFull path: " + cf.Slot);
    }








    public static void UseFlashcard(int selectedSlot)
    {

        var cf = new Dev(); //cf = custom flashcard
        string slotPath = Path.Combine(appDataPath, "slot" + selectedSlot + ".json");
        string slotContent = File.ReadAllText(slotPath);
        cf = JsonSerializer.Deserialize<Dev>(slotContent);

        Console.WriteLine(cf.Name.ToUpper());
        Console.WriteLine("\n" + cf.Question);
        Console.Write(" 1. " + cf.Answer1 + "\n 2. " + cf.Answer2 + "\n 3. " + cf.Answer3 + "\n 4. " + cf.Answer4 + "\n\n>");


        string answer = Console.ReadLine();

        if (answer == cf.correctAnswer)
        {
            Console.Clear();
            Console.WriteLine("Correct!\n\n\n");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Incorrect...\n\n\n");
        }
    }







    public static void DeleteFlashcard()
    {
        int selectedSlot;

        Console.Write("\n\n\nSelect a flashcard to deleted by typing the corresponding number next to its name:\n 1\n 2\n 3\n\n>");
        while (!int.TryParse(Console.ReadLine(), out selectedSlot))
        {
            Console.Clear();
            DeleteFlashcard();
        }

        string slotPath = Path.Combine(appDataPath, "slot" + selectedSlot + ".json");
        File.WriteAllText(slotPath, "");

        Console.Clear();
        Console.WriteLine("The flashcard in slot " + selectedSlot + "was removed! Press ENTER to re-access Developer Mode.");
        Console.ReadKey();
        Console.Clear();
        DevMode();
    }

} 

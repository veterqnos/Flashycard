using System.Text.Json;
using System.IO;

namespace f;

public class CF
{

    public string? Name { get; set; }
    public string? Question { get; set; }
    public string? Answer { get; set; }


    static string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
    static string filepath = Path.Combine(appDataPath, "flashcards.json");



    public static void CreateFlashcard()
    {
        string? name;
        string? question;
        string? answer;

        if (!File.Exists(filepath))
        {

            Console.WriteLine("Welcome to Developer Mode! Here you can create your own flashcard.\n");

            Console.WriteLine("How do you want the flashcard to be named?");
            name = Console.ReadLine();
            Console.WriteLine("What will be the question of the flashcard?");
            question = Console.ReadLine();
            Console.WriteLine("Finally, what will be the answer of the flashcard?");
            answer = Console.ReadLine();


            var flashcard = new CF()
            {
                Name = name,
                Question = question,
                Answer = answer
            };

            string json = JsonSerializer.Serialize(flashcard, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filepath, json);

            Console.WriteLine("\n\n\nFlashcard saved to flashcards.json!\nFull path: "+filepath+
                                "\n\nOh yeah, try running the program again and enter Developer Mode to see what's gonna happen =)");
        }

        else
        {
            var content = new CF();
            string existingJson = File.ReadAllText(filepath);
            content = JsonSerializer.Deserialize<CF>(existingJson);

            Console.WriteLine(content.Name.ToUpper());
            Console.WriteLine("\n" + content.Question);
            answer = Console.ReadLine();

            if (answer == content.Answer)
            {
                Console.Clear();
                Console.WriteLine("Correct!\n\n\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("How did you fail your own question?\n\n\n");
            }

            Console.WriteLine("Now your flashcard...\nwas deleted right now.\n\nYeah...\n\n");
            Console.WriteLine("That's because I haven't tried implementing\na store-multiple-questions-on-one-json-file thing yet.\n\n");
            Console.WriteLine("Sorry, you have to wait for that.\n\n\nSee you in the next patch!");

            File.Delete(filepath);
        }

    } 
}
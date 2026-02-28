using StringProcessingApp.Services;

namespace StringProcessingApp.Views
{
    public class StringView
    {
        private readonly StringService _service = new StringService();

        public void Run()
        {
            bool exit = false;
            while (!exit)
            {
                DisplayMenu();
                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1": 
                        Console.Write("Enter text: ");
                        _service.SetText(Console.ReadLine() ?? "");
                        break;
                    case "2": 
                        Console.WriteLine($"Current Text: [{_service.CurrentText}]");
                        break;
                    case "3": _service.ToUpper(); break;
                    case "4": _service.ToLower(); break;
                    case "5": 
                        Console.WriteLine($"Character Count: {_service.GetLength()}");
                        break;
                    case "6":
                        Console.Write("Enter word to find: ");
                        bool found = _service.ContainsWord(Console.ReadLine() ?? "");
                        Console.WriteLine(found ? "Word found!" : "Word not found.");
                        break;
                    case "7":
                        Console.Write("Word to replace: ");
                        string oldW = Console.ReadLine() ?? "";
                        Console.Write("Replace with: ");
                        string newW = Console.ReadLine() ?? "";
                        _service.ReplaceWord(oldW, newW);
                        break;
                    case "8":
                        Console.Write("Start index: ");
                        int start = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Length: ");
                        int len = int.Parse(Console.ReadLine() ?? "0");
                        _service.ExtractSubstring(start, len);
                        break;
                    case "9": _service.TrimSpaces(); break;
                    case "10": _service.Reset(); break;
                    case "11": exit = true; break;
                    default: Console.WriteLine("Invalid option."); break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        private void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("--- String Processing System ---");
            Console.WriteLine("1. Enter Text");
            Console.WriteLine("2. View Current Text");
            Console.WriteLine("3. Convert to UPPERCASE");
            Console.WriteLine("4. Convert to lowercase");
            Console.WriteLine("5. Count Characters");
            Console.WriteLine("6. Check if Contains Word");
            Console.WriteLine("7. Replace Word");
            Console.WriteLine("8. Extract Substring");
            Console.WriteLine("9. Trim Spaces");
            Console.WriteLine("10. Reset Text");
            Console.WriteLine("11. Exit");
            Console.Write("\nSelect an option: ");
        }
    }
}

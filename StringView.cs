using System;

namespace StringProcessingApp
{
    public class StringView
    {
        private StringService service = new StringService();

        public void Run()
        {
            bool running = true;

            while (running)
            {
                DisplayMenu();
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter your text: ");
                    string input = Console.ReadLine();
                    service.SetText(input);
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Current Text: " + service.CurrentText);
                }
                else if (choice == "3")
                {
                    service.ToUpper();
                    Console.WriteLine("Changed to UPPERCASE.");
                }
                else if (choice == "4")
                {
                    service.ToLower();
                    Console.WriteLine("Changed to lowercase.");
                }
                else if (choice == "5")
                {
                    int len = service.GetLength();
                    Console.WriteLine("Total characters: " + len);
                }
                else if (choice == "6")
                {
                    Console.Write("Enter word to search: ");
                    string find = Console.ReadLine();
                    if (service.ContainsWord(find)) {
                        Console.WriteLine("Found it!");
                    } else {
                        Console.WriteLine("Not found.");
                    }
                }
                else if (choice == "7")
                {
                    Console.Write("Old word: ");
                    string oldW = Console.ReadLine();
                    Console.Write("New word: ");
                    string newW = Console.ReadLine();
                    service.ReplaceWord(oldW, newW);
                }
                else if (choice == "8")
                {
                    Console.Write("Start index: ");
                    int start = int.Parse(Console.ReadLine());
                    Console.Write("Length: ");
                    int len = int.Parse(Console.ReadLine());
                    service.ExtractSubstring(start, len);
                }
                else if (choice == "9")
                {
                    service.TrimSpaces();
                    Console.WriteLine("Spaces removed.");
                }
                else if (choice == "10")
                {
                    service.Reset();
                    Console.WriteLine("Text reset to original.");
                }
                else if (choice == "11")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again.");
                }

                Console.WriteLine("\nPress enter to continue...");
                Console.ReadLine();
            }
        }

        private void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("--- STRING PROCESSOR ---");
            Console.WriteLine("1.Enter Text");
            Console.WriteLine("2. View Current text");
            Console.WriteLine("3. Convert to UPPERCASE");
            Console.WriteLine("4. Convert to lowercase");
            Console.WriteLine("5. Count Character");
            Console.WriteLine("6. Check if it Contain Word");
            Console.WriteLine("7. Replace Word");
            Console.WriteLine("8. Extract Substring");
            Console.WriteLine("9. Trim Spaces");
            Console.WriteLine("10. Reset Text");
            Console.WriteLine("11. Exit");
            Console.Write("Selection: ");
        }
    }
}

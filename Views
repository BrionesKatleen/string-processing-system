using System.Runtime.CompilerServices;
using StringSystem.Services;

namespace StringSystem.View
{
    public class StringView
    {
        private StringService stringService;
        public StringView()
        {
            stringService = new StringService();
        }

        // HELPER METHOD
        private string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine() ?? string.Empty;
        }

        public void Run()
        {
            bool running = true;
            while (running)
            {
                //Console.Clear();
                Console.WriteLine(@"
                === STRING PROCESSING SYSTEM ===
                1. Enter Text.
                2. View Current Text.
                3. Convert to UPPERCASE.
                4. Convert to lowercase.
                5. Count Characters.
                6. Check if Contains Word.
                7. Replace Word.
                8. Extract Substring.
                9. Trim Spaces.
                10. Reset Text.
                11. Exit.
                ===================================");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine() ?? string.Empty;

                switch (choice)
                {
                    case "1":
                        EnterText();
                        break;
                    case "2":
                        ViewCurrentText();
                        break;
                    case "3":
                        ConvertToUpper();
                        break;
                    case "4":
                        ConvertToLower();
                        break;
                    case "5":
                        CountCharacters();
                        break;
                    case "6":
                        CheckContainsWord();
                        break;
                    case "7":
                        ReplaceWord();
                        break;
                    case "8":
                        ExtractSubstring();
                        break;
                    case "9":
                        TrimSpaces();
                        break;
                    case "10":
                        ResetText();
                        break;
                    case "11":
                        Console.WriteLine("Thank you for using String Processing System!");
                        running = false;
                        continue;
                    default:
                        Console.WriteLine("Invalid choice! Please enter 1 - 10.");
                        break;
                }

                // if(running)
                // {
                //     Console.WriteLine("\nPress any key to continue...");
                //     Console.ReadKey();
                // }
            }
        }

        private void EnterText()
        {
            Console.WriteLine("\n--- Enter Text ---");
            string text = GetUserInput("Enter your text: ");
            stringService.SetText(text);
            Console.WriteLine("Text saved successfully!");
        }

        private void ViewCurrentText()
        {
            Console.WriteLine("\n--- Current Text ---");
            if (stringService.HasText())
            {
                Console.WriteLine($"Text: \"{stringService.GetCurrentText()}\"");
            }
            else
            {
                Console.WriteLine("No text entered yet!");
            }
        }

        private void ConvertToUpper()
        {
            Console.WriteLine("\n--- Convert to UPPERCASE ---");
            if (stringService.HasText())
            {
                string result = stringService.ConvrtToUp();
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Please enter text first!");
            }
        }

        private void ConvertToLower()
        {
            Console.WriteLine("\n--- Convert to lowercase ---");
            if (stringService.HasText())
            {
                string result = stringService.ConvrtToLow();
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Please enter text first!");
            }
        }

        private void CountCharacters()
        {
            Console.WriteLine("\n--- Count Characters ---");
            if (stringService.HasText())
            {
                int count = stringService.CountChar();
                Console.WriteLine($"Character count: {count}");
            }
            else
            {
                Console.WriteLine("Please enter text first!");
            }
        }

        private void CheckContainsWord()
        {
            Console.WriteLine("\n--- Check if Contains Word ---");
            if (!stringService.HasText())
            {
                Console.WriteLine("Please enter text first!");
                return;
            }

            string word = GetUserInput("Enter word to check: ");
            bool contains = stringService.ContainsWord(word);
            
            if (contains)
            {
                Console.WriteLine($"Text contains the word: \"{word}\"");
            }
            else
            {
                Console.WriteLine($"Text does NOT contain the word: \"{word}\"");
            }
        }

        private void ReplaceWord()
        {
            Console.WriteLine("\n--- Replace Word ---");
            if (!stringService.HasText())
            {
                Console.WriteLine("Please enter text first!");
                return;
            }

            string oldWord = GetUserInput("Enter word to replace: ");
            string newWord = GetUserInput("Enter new word: ");
            
            string result = stringService.ReplaceWord(oldWord, newWord);
            
            if (result != stringService.GetCurrentText())
            {
                Console.WriteLine($"Original: {stringService.GetCurrentText()}");
                Console.WriteLine($"Result: {result}");
                
                string saveChoice = GetUserInput("Save this change? (y/n): ");
                if (saveChoice.ToLower() == "y")
                {
                    stringService.SetText(result);
                    Console.WriteLine("Text updated successfully!");
                }
            }
            else
            {
                Console.WriteLine($"Word \"{oldWord}\" not found in text!");
            }
        }

        private void ExtractSubstring()
        {
            Console.WriteLine("\n--- Extract Substring ---");
            if (!stringService.HasText())
            {
                Console.WriteLine("Please enter text first!");
                return;
            }

            Console.WriteLine($"Current text: \"{stringService.GetCurrentText()}\"");
            Console.WriteLine($"Length: {stringService.CountChar()}");
            
            if (int.TryParse(GetUserInput("Enter start index (0-based): "), out int startIndex) &&
                int.TryParse(GetUserInput("Enter length: "), out int length))
            {
                string result = stringService.GetSubstring(startIndex, length);
                Console.WriteLine($"Extracted substring: \"{result}\"");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter valid numbers.");
            }
        }

        private void TrimSpaces()
        {
            Console.WriteLine("\n--- Trim Spaces ---");
            if (!stringService.HasText())
            {
                Console.WriteLine("Please enter text first!");
                return;
            }

            string original = stringService.GetCurrentText();
            string trimmed = stringService.TrimSpaces();
            
            Console.WriteLine($"Original: \"{original}\"");
            Console.WriteLine($"Trimmed: \"{trimmed}\"");
            
            string saveChoice = GetUserInput("Save trimmed version? (y/n): ");
            if (saveChoice.ToLower() == "y")
            {
                stringService.SetText(trimmed);
                Console.WriteLine("Text updated successfully!");
            }
        }

        private void ResetText()
        {
            Console.WriteLine("\n--- Reset Text ---");
            if (stringService.HasText())
            {
                Console.WriteLine($"Original text: \"{stringService.GetCurrentText()}\"");
                string confirm = GetUserInput("Are you sure you want to reset? (y/n): ");
                
                if (confirm.ToLower() == "y")
                {
                    stringService.ResetToOrig();
                    Console.WriteLine("Text reset to original!");
                }
                else
                {
                    Console.WriteLine("Reset cancelled.");
                }
            }
            else
            {
                Console.WriteLine("No text to reset!");
            }
        }
    }
}

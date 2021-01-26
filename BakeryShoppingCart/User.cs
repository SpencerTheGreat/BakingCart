using System;
namespace BakeryShoppingCart
{
    public class User
    {
        public User()
        {
            {
                bool showMenu = true;
                while (showMenu)
                {
                    showMenu = MainMenu();
                }
            }
            static bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Choose an op:");
                Console.WriteLine("1) Reverse String");
                Console.WriteLine("2) Remove Whitespace");
                Console.WriteLine("3) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        ReverseString();
                        return true;
                    case "2":
                        RemoveWhitespace();
                        return true;
                    case "3":
                        return false;
                    default:
                        return true;
                }
            }

            static string CaptureInput()
            {
                Console.Write("Enter the string you want to modify: ");
                return Console.ReadLine();
            }

            static void ReverseString()
            {
                Console.Clear();
                Console.WriteLine("Reverse String");

                char[] charArray = CaptureInput().ToCharArray();
                Array.Reverse(charArray);
                DisplayResult(String.Concat(charArray));
            }

            static void RemoveWhitespace()
            {
                Console.Clear();
                Console.WriteLine("Remove Whitespace");

                DisplayResult(CaptureInput().Replace(" ", ""));
            }

            static void DisplayResult(string message)
            {
                Console.WriteLine($"\r\nYour modified string is: {message}");
                Console.Write("\r\nPress Enter to return to Main Menu");
                Console.ReadLine();
            }
            public class User
        }
    
    
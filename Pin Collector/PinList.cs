using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Pin_Collector
{
    public class PinList
    {
        static public List<Pin> OwnedPins = new List<Pin>();

        public void ListAllPins(string type)
        {
            Clear();
            ForegroundColor = ConsoleColor.Cyan;
            string allPinsTitle = @"
 

 __     __                 ____                          _   _____ _           
 \ \   / /                / __ \                        | | |  __ (_)          
  \ \_/ /__  _   _ _ __  | |  | |_      ___ __   ___  __| | | |__) | _ __  ___ 
   \   / _ \| | | | '__| | |  | \ \ /\ / / '_ \ / _ \/ _` | |  ___/ | '_ \/ __|
    | | (_) | |_| | |    | |__| |\ V  V /| | | |  __/ (_| | | |   | | | | \__ \
    |_|\___/ \__,_|_|     \____/  \_/\_/ |_| |_|\___|\__,_| |_|   |_|_| |_|___/
                                                                               
                                                                               

            
                                                                 ";

            Console.WriteLine(allPinsTitle);
            ResetColor();
            
            foreach (var ownedPin in PinList.OwnedPins)
                WriteLine(ownedPin.GetPinForDisplay("default color"));

            if (type == "view")
            {
                WriteLine("\n Press the F1 key to return to the main screen..");
            }

            
        }


        public void EditPin()
        {
            WriteLine("\n\nPlease enter the name of the Pin you would like to edit.");
            string input = ReadLine();
            string metadata;

            foreach (Pin Pin in PinList.OwnedPins)
            {
                if (Pin.Name == input)
                {
                    WriteLine("Which part would you like to edit?");
                    metadata = ReadLine();

                    switch (metadata)
                    {
                        case "Name":
                            WriteLine("Enter the new name: ");
                            Pin.Name = ReadLine();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            WriteLine("\n The name of your pin has been updated!");
                            Console.ForegroundColor = ConsoleColor.White;
                            WriteLine("\n Press Enter to return to the Main Menu or Space to edit another Pin.");

                            break;
                        case "Collection":
                            string prompt = "\nWhat collection is your pin from?";
                            string[] menuOptions = { "Disney", "Pokemon", "Pixar", "Animals", "Movie", "TV Show", "Other" };
                            Menu collectionMenu = new Menu(prompt, menuOptions);
                            int selectedIndex = collectionMenu.Run();

                            Pin.Collection = menuOptions[selectedIndex];

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            WriteLine("\n Your pin's collection has been updated!");

                            Console.ForegroundColor = ConsoleColor.White;
                            WriteLine("\n Press Enter to return to the Main Menu or Space to edit another Pin.");

                            break;
                        case "Character":
                            WriteLine("Enter the new character: ");
                            Pin.Character = ReadLine();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            WriteLine("\n Your pin's character has been updated!");

                            Console.ForegroundColor = ConsoleColor.White;
                            WriteLine("\n Press Enter to return to the Main Menu or Space to edit another Pin.");

                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            WriteLine("That category does not exist please try again.");

                            Console.ForegroundColor = ConsoleColor.White;
                            WriteLine("\n Press Enter to return to the Main Menu or Space to edit another Pin.");
                            break;
                    }

                }
            }

        }
        public void DeletePin()
        {
            WriteLine("Please enter the name of the Pin you would like to delete.");
            string input = ReadLine();
            int pinLocation = PinList.OwnedPins.FindIndex(a => a.Name == input);
            PinList.OwnedPins.RemoveAt(pinLocation);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("\nYour Pin has been deleted!");

            Console.ForegroundColor = ConsoleColor.White;
            WriteLine("\nPress any key to return to the manin menu.");
            ReadKey();
        }

    }


    
}

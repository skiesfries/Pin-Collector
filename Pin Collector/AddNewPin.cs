using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Pin_Collector
{
    public class AddNewPin
    {
        string newPinName;
        string newPinCollection;
        string newPinCharacter;

        public void GetName()
        {
            WriteLine("\n\nWhat is the name of your pin?");
            newPinName = ReadLine();

        }

        public void GetCollection()
        {

            string prompt = "\nWhat collection is your pin from?";
            string[] menuOptions = { "Disney", "Pokemon", "Pixar", "Animals", "Movie", "TV Show", "Other" };
            Menu collectionMenu = new Menu(prompt, menuOptions);
            int selectedIndex = collectionMenu.Run();

            
            newPinCollection = menuOptions[selectedIndex];

            if (newPinCollection == menuOptions[6])
            {
                WriteLine("\nWhat is the name of the collection your pin is in?");
                newPinCollection = ReadLine();
            }

        }

        public void GetCharacter()
        {
            WriteLine("\nWhat is the name of the character portrayed on your pin? (If it is not a character, please enter \"Other\").");
            newPinCharacter = ReadLine();

            if (newPinCharacter == "Other")
            {
                WriteLine("\nWhat is portrayed in your pin?");
                newPinCharacter = ReadLine();
            }

        }
        
        
        public void SavePin()
        {
            var Pin = new Pin() { Name = newPinName, Collection = newPinCollection, Character = newPinCharacter};
            PinList.OwnedPins.Add(Pin);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("\nYour Pin as been saved!");

            Console.ForegroundColor = ConsoleColor.White;
            WriteLine("\nPress any key to return to the main menu.");
            ReadKey();
          
        }
       

        public void isInformationCorrect()
        {
            var Pin = new Pin() { Name = newPinName, Collection = newPinCollection, Character = newPinCharacter };
            
            
            string prompt = $"\n{Pin.GetPinForDisplay("cyan")}\n\n{Pin.IsInfoCorrectResetColor()}";
            string[] menuOptions = {"SAVE", "Modify Name", "Modify Collection","Modify Character"};
            Menu iscorrect = new Menu(prompt, menuOptions);
            int selectedIndex = iscorrect.Run();


            switch (selectedIndex)
            {
                case 0:
                    SavePin();
                    break;
                case 1:
                    GetName();
                    isInformationCorrect();
                    break;
                case 2:
                    GetCollection();
                    isInformationCorrect();
                    break;
                case 3:
                    GetCharacter();
                    isInformationCorrect();
                    break;
            }
        }

    }
}

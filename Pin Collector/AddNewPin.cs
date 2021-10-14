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
            WriteLine("\n\nWhat is the name of your new pin?");
            newPinName = ReadLine();

        }

        public void GetCollection()
        {
            string prompt = "\nWhat collection is your pin from?";
            string[] menuOptions = { "Disney", "Pokemon", "Pixar", "Animals", "Movie", "TV Show", "Other" };
            Menu collectionMenu = new Menu(prompt, menuOptions);
            int selectedIndex = collectionMenu.Run();

            
            newPinCollection = menuOptions[selectedIndex];

        }

        public void GetCharacter()
        {
            WriteLine("\nWhat is the name of the character portrayed on your pin? (If it is not a character, please enter \"Other\").");
            newPinCharacter = ReadLine();
            
        }
        
        
        public void SavePin()
        {
            var Pin = new Pin() { Name = newPinName, Collection = newPinCollection, Character = newPinCharacter};
            PinList.OwnedPins.Add(Pin);

            WriteLine("\nYour Pin as been saved!");
            ReadKey();
          
        }

        public void isInformationCorrect()
        {
            var Pin = new Pin() { Name = newPinName, Collection = newPinCollection, Character = newPinCharacter };


            string prompt = $"\n{Pin.GetPinForDisplay()}\n\nIf this information is correct, select \"SAVE\" to add this pin to your collection. Otherwise, select the information that is incorrect to modify it.";
            string[] menuOptions = {"SAVE", "Modify Name", "Modify Collection","Modify Character"};
            Menu iscorrect = new Menu(prompt, menuOptions);
            int selectedIndex = iscorrect.Run();


            switch (selectedIndex)
            {
                case 0:
                    SavePin();
                    break;
                case 1:
                  
                    break;
                case 2:
                  
                    break;
                case 3:
               
                    break;
            }
        }

    }
}

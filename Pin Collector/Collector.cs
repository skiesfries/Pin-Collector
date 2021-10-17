using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;

namespace Pin_Collector
{
    public class Collector
    {
        public void Start()
        {
            Console.Title = "Pin Collector 1.0";
            Clear();
            ForegroundColor = ConsoleColor.Cyan;
            string title = @"
 
  _____ _          _____      _ _           _               __   ___  
 |  __ (_)        / ____|    | | |         | |             /_ | / _ \ 
 | |__) | _ __   | |     ___ | | | ___  ___| |_ ___  _ __   | || | | |
 |  ___/ | '_ \  | |    / _ \| | |/ _ \/ __| __/ _ \| '__|  | || | | |
 | |   | | | | | | |___| (_) | | |  __/ (__| || (_) | |     | || |_| |
 |_|   |_|_| |_|  \_____\___/|_|_|\___|\___|\__\___/|_|     |_(_)___/ 
                                                                      
                                                                      
            
                                                                 ";

            Console.WriteLine(title);

            ResetColor();
            WriteLine("Press Enter to begin managing your collection!");
          
                ReadKey(true);
            while(true)
                RunMainMenu();


        }   

        private void RunMainMenu()
        {

            string prompt = "Hello! What would you like to do today?\n";
            string[] menuOptions = { "Add New Pin to Collection", "View All Pins in Collection", "Edit Owned Pins", "Delete a Pin", "Exit the Pin Collector" };
            Menu mainMenu = new Menu(prompt, menuOptions);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex) 
            {
                case 0:
                    AddNewPin();
                    break;
                case 1:
                    ViewAllPins();
                    break;
                case 2:
                    EditPins();
                    break;
                case 3:
                    DeletePins();
                    break;
                case 4:
                    Exit();
                    break;
                
            }

        }

        public void Exit()
        {

            if (new YesNoMenu("Are you sure you would like to exit?").isYes())
            {
                Environment.Exit(0);
            } else
            {
                Start();
            }
         
        }

        public void AddNewPin()
        {
            Clear();
            ForegroundColor = ConsoleColor.Cyan;
            string newPinTitle = @"
 .-----------------. .----------------.  .----------------.   .----------------.  .----------------.  .-----------------.
| .--------------. || .--------------. || .--------------. | | .--------------. || .--------------. || .--------------. |
| | ____  _____  | || |  _________   | || | _____  _____ | | | |   ______     | || |     _____    | || | ____  _____  | |
| ||_   \|_   _| | || | |_   ___  |  | || ||_   _||_   _|| | | |  |_   __ \   | || |    |_   _|   | || ||_   \|_   _| | |
| |  |   \ | |   | || |   | |_  \_|  | || |  | | /\ | |  | | | |    | |__) |  | || |      | |     | || |  |   \ | |   | |
| |  | |\ \| |   | || |   |  _|  _   | || |  | |/  \| |  | | | |    |  ___/   | || |      | |     | || |  | |\ \| |   | |
| | _| |_\   |_  | || |  _| |___/ |  | || |  |   /\   |  | | | |   _| |_      | || |     _| |_    | || | _| |_\   |_  | |
| ||_____|\____| | || | |_________|  | || |  |__/  \__|  | | | |  |_____|     | || |    |_____|   | || ||_____|\____| | |
| |              | || |              | || |              | | | |              | || |              | || |              | |
| '--------------' || '--------------' || '--------------' | | '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------'   '----------------'  '----------------'  '----------------' ";

            Write(newPinTitle);
            ResetColor();

            AddNewPin addNewPin = new AddNewPin();
            addNewPin.GetName();
            addNewPin.GetCollection();
            addNewPin.GetCharacter();
            addNewPin.isInformationCorrect();
            
        }

        private void ViewAllPins()
        {
            PinList viewPins = new PinList();
            viewPins.ListAllPins("view");

            ConsoleKeyInfo keyPressed;
            while (true)
            {
                keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.F1)
                {
                    Start();
                }
            }
        }

        private void EditPins()
        {
            PinList editPins = new PinList();
            editPins.ListAllPins("edit");
            editPins.EditPin();
            ConsoleKeyInfo keyPressed;
            while (true)
            {
                keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.Enter)
                {
                    RunMainMenu();
                }
                else if (keyPressed.Key == ConsoleKey.Spacebar)
                {
                    EditPins();
                }
            }
        }

        private void DeletePins()
        {
            PinList deletePins = new PinList();
            deletePins.ListAllPins("delete");
            deletePins.DeletePin();
        }
    }
}

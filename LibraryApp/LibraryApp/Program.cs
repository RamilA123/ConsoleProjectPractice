


using LibraryApp.Controllers;
using ServiceLayer.Helpers;
using System.Runtime.CompilerServices;

LibraryController librarycontroller = new LibraryController();

while (true)
{
  
    ConsoleColor.Blue.WriteConsole("Select one options:");
    ConsoleColor.Blue.WriteConsole("Library optins: 1.Create, 2.Get by id, 3.Delete");
   
    SelectOption: string option = Console.ReadLine();
    int selectedOption;
    bool isParsed = int.TryParse(option, out selectedOption);

    if (isParsed)
    {
        switch (selectedOption)
        {
            case 1:
                librarycontroller.Create();
                break;
            case 2:
                librarycontroller.GetById();
                break;
            case 3:
                Console.WriteLine("Delete");
                break;
            default:
                Console.WriteLine("Select again true option:");
                break;
        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Select again true option:");
        goto SelectOption;
    }
}

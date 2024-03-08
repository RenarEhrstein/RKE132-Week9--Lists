using System.Collections.Generic;

string folderPath = @"C:\data";
string fileName = "shoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List <string> myShoppingList = new List <string>();

if (File.Exists(filePath))
{
    myShoppingList = GetItemsFromuser();
    File.WriteAllLines(filePath, myShoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} has been created.");
    myShoppingList = GetItemsFromuser();
    File.WriteAllLines(filePath, myShoppingList);
}





static List<string> GetItemsFromuser()
{
    List<string> userlist = new List<string>();
    while (true)
    {
        Console.WriteLine("Add an item (add)/ Exit (exit):");
        string userChoice = Console.ReadLine();

        if (userChoice == "add")
        {
            Console.WriteLine("Ener an item:");
            string userItem = Console.ReadLine();
            userlist.Add(userItem);

        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }

    }
    return userlist;
}



static void ShowItemsFromList(List<string> someList)
{
    Console.Clear();

    int listLength = someList.Count;
    Console.WriteLine($"You have added {listLength} items to your shopping list.");

    int i = 1;
    foreach (string item in someList)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}



Console.WriteLine("Are you coming with us? (yes/no):");

string userChoice = Console.ReadLine();

if (userChoice == "yes" )
{
    PrintHello();
}
else
{
    PrintGoodBye(); 
}


static void PrintHello() //function / method
{
    Console.WriteLine("Lets go!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, Alligator!");
}
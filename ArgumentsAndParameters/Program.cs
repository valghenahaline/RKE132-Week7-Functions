
Console.WriteLine("Enter a funny word:");
string userInput = Console.ReadLine();  

PrintAnyWord(userInput);   //userInput - argument

static void PrintAnyWord(string anyString) //anyString - parameter
{
    anyString = anyString.ToUpper();
    Console.WriteLine("Here is your funny word:");
    for(int i = 0; i < 4; i++)
    {
        Console.WriteLine(anyString);
    }
}
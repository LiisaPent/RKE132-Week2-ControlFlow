// See https://aka.ms/new-console-template for more information

// rakendus küsib kasutaja vanust
// kui kasutaja vanus on <13, kuvatakse konsoolis:
// "You are too young to use Instagram"
// muul juhul kuvatakse konsoolis: 
// "Welcome to Instagram"

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else // if (userAge < 13)
{
    Console.WriteLine("You are too young to use Instagram.");
}
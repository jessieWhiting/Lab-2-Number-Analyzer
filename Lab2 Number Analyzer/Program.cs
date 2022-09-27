// See https://aka.ms/new-console-template for more information



   

Console.WriteLine("Hey, I'm learning my numbers and I have a question for you. \n What's your name? ");
bool goAgain = true;
string name = Console.ReadLine();
while (goAgain)
{


    Console.WriteLine(" Alright, " + name + ", \n Pick a number between 1 and 100. ");

    int num = Int32.Parse(Console.ReadLine());




    Console.WriteLine(num + "? What an interesting number... \n You must have put a lot of thought in to that one " + name + ",...");

    if (num < 60 && num > 25 && num % 2 != 0 || num ==1 || num ==2)
    {
        Console.WriteLine(name + " This is an odd number that is less than 60. ");
    }


    else if (num >= 2 && num <= 24 && num % 2 != 0)
    {
        Console.WriteLine(" This is an odd number that is less than 25, " + name +". ");
    }

    else if (num >= 26 && num <= 60 && num % 2 == 0)
    {
        Console.WriteLine(name + ", This is an even number that is between 26 and 60. ");
    }

    else if (num > 60 && num < 100 && num % 2 == 0)
    {
        Console.WriteLine(", This is an even number that is greater than 60, " +name +". ");
    }
    else if (num > 60 && num < 100 && num % 2 != 0)
    {
        Console.WriteLine(name + ", This is an odd number that is greater than 60. ");
    }
    else
    {
        Console.WriteLine("That wasn't what I asked " + name + ".. try listening a little better and pick a number between 1 and 100. ");
    }

    Console.WriteLine(" Would you like to test a different number? Y/N? ");

    string answer = Console.ReadLine().ToUpper();

    if (answer == "Y")
    {
        Console.WriteLine(" okay, we will play again!");
    }
    else
    {
        Console.WriteLine(" Thanks for playing, see you around!");
        goAgain = false;
    }
}
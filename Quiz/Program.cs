using System.Collections.Concurrent;
using Microsoft.VisualBasic;

int score = 0;
string answer1 = "";
string answer2 = "";
string answer3 = "";
Console.WriteLine("Welcome to my quiz regarding Christianity!");



Console.WriteLine("Who was the first human that God created?");
Console.WriteLine("a) Adam  b) Steve  c) Barney");
answer1 = Console.ReadLine();
answer1 = answer1.ToLower();
if (answer1 == "a")
{
    score++;
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Incorrect!");
}



Console.WriteLine("What happened during the Great Schism in 1054?");
Console.WriteLine("a) Martin Luther started reforming");
Console.WriteLine("b) Christianity split into Roman Catholicism and Eastern Orthodoxy");
Console.WriteLine("c) John Calvin the Great got excommunicated by the Pope");
answer2 = Console.ReadLine();
answer2 = answer2.ToLower();
if (answer2 == "b")
{
    score++;
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Incorrect!");
}



Console.WriteLine("Who wrote the book of Revelation?");
Console.WriteLine("a) Jesus Christ  b) St. Paul  c) St. John");
answer3 = Console.ReadLine();
answer3 = answer3.ToLower();
if (answer3 == "c")
{
    score++;
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Incorrect!");
}

Console.WriteLine("You got {score} points.");
if (score == 0)
{
    Console.WriteLine("My brother in Christ, you really do need a deeper depth in history!");
}
else if (score < 3)
{
    Console.WriteLine("Alright friend, I see that you have some knowledge.");
}
else
{
    Console.WriteLine("Great job! You answered everything correctly!");
}

Console.WriteLine("Press ENTER to end this quiz.");
Console.ReadLine();
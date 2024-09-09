string name = "Micke";
bool isAlive = name == "Micke";

int hp = 100;

hp = hp - 10;

hp -= 10;

hp = hp - 1;
hp -= 1;

hp--;

hp = hp - +4;

Console.WriteLine(hp);


if (hp >= 0)
{
    Console.WriteLine("Still alive!");
}

Console.ReadLine();
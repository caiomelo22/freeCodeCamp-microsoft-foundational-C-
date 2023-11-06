using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

string[,] group;

RandomizeAnimals();
group = AssignGroup();
Console.WriteLine("School A");
PrintGroup(group);

RandomizeAnimals();
group = AssignGroup(3);
Console.WriteLine("School B");
PrintGroup(group);

RandomizeAnimals();
group = AssignGroup(2);
Console.WriteLine("School C");
PrintGroup(group);

void RandomizeAnimals()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++) 
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }
}

void PrintGroup(string[,] groups)
{
    int numGroups = groups.GetLength(0);
    int animalsPerGroup = groups.GetLength(1);

    for (int i = 0; i < numGroups; i++)
    {
        Console.Write($"Group {i+1}: ");
        for (int j = 0; j < animalsPerGroup; j++)
        {
            Console.Write($"{groups[i, j]}  ");
        }
        Console.WriteLine();
    }
    
    Console.WriteLine();
}

string[,] AssignGroup(int numGroups = 6)
{
    int animalsCount = 0;
    int animalsPerGroup = pettingZoo.Length/numGroups;

    string[,] groups = new string[numGroups,animalsPerGroup];

    for (int i = 0; i < numGroups; i++)
    {
        for (int j = 0; j < animalsPerGroup; j++)
        {
            groups[i, j] = pettingZoo[animalsCount];
            animalsCount++;
        }
    }

    return groups;
}
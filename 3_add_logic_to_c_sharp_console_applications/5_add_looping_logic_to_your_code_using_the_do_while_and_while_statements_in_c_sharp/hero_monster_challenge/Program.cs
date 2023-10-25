int heroIntegrity = 10;
int monsterIntegrity = 10;

do
{
    Random attacks = new Random();

    int heroAttack = attacks.Next(11);
    monsterIntegrity -= heroAttack;

    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterIntegrity} health.");
    
    if (monsterIntegrity <= 0)
        continue;

    int monsterAttack = attacks.Next(11);
    heroIntegrity -= monsterAttack;

    Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroIntegrity} health.");
} while (heroIntegrity > 0 && monsterIntegrity > 0);

Console.WriteLine(heroIntegrity > monsterIntegrity? "Hero wins!" : "Monster wins!");
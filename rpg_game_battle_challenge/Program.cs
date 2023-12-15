//hero hp 10pts
//monster hp 10pts
//attacks valued 1-10
//hero attacks first
//monster attacks if health > 0
//print amount of health lost and remaining
//either to 0 or less print winner

int heroHP = 10;
int monsterHP = 10;
Random random = new Random();

do {
    int swing = random.Next(1,10);
    monsterHP -= swing;
    Console.WriteLine($"Monster takes {swing} damage. Monster HP is {monsterHP}");
    if(monsterHP <= 0) continue;
    swing = random.Next(1,10);
    heroHP -= swing;
    Console.WriteLine($"Hero takes {swing} damage. Hero HP is {heroHP}");
}while (monsterHP > 0  && heroHP > 0);

Console.WriteLine(heroHP > monsterHP ? "Hero wins!" : "Monster wins!");
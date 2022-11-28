// See https://aka.ms/new-console-template for more information
using ThorHulkFight;

/*
Thor Attacks Hulk and Deals 74 Damage
Maximus Has 69 Health

Hulk Attacks Thor and Deals 6 Damage
Bob Has 6 Health

Thor Attacks Hulk and Deals 48 Damage
Maximus Has 21 Health

Hulk Attacks Thor and Deals 48 Damage
Bob Has -42 Health

Thor has Died and Hulk is Victorious

Game Over
*/

Warrior thor = new Warrior("Thor",100,30,10);
//Warrior hulk = new Warrior("Hulk", 200, 26, 10);
Warrior loki = new MagicWarrior("Loki", 80, 26, 10, 50);

//Battle.StartFight(thor, hulk);
Battle.StartFight(thor, loki);

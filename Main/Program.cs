﻿using Main;
Console.CursorVisible = false;



var e1 = new Enemy(ConsoleColor.Green, 11, 5);
var e2 = new Enemy(ConsoleColor.Red, 10, 6);
var e3= new Enemy(ConsoleColor.Magenta, 11, 6);
var e4 = new Enemy(ConsoleColor.DarkBlue, 12, 6);

Palya.palya[Player.p1.y, Player.p1.x] = Player.p1.kinezet;
Palya.palya[e1.y, e1.x] = e1.kinezet;
Palya.palya[e2.y, e2.x] = e2.kinezet;
Palya.palya[e3.y, e3.x] = e3.kinezet;
Palya.palya[e4.y, e4.x] = e4.kinezet;
Palya.Kiir(Palya.palya);
Palya.palya[Player.p1.y, Player.p1.x] = ' ';

Mozgas.enemyStart(e1, e2, e3, e4);

while (Player.p1.pontok < 121 || Player.p1.isAlive == false)
{
    Player.p1.Menj(Palya.palya);
}
Console.Clear();
if (Player.p1.isAlive)
{
    Console.WriteLine("YOU WIN!!");
} else {
    Console.WriteLine("GAME OVER");
}
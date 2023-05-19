using oop_homework;

Referee r1 = new Referee("r01", 35);
Referee r2 = new Referee("r02", 36);
Referee r3 = new Referee("r03", 37);

Coach c1 = new Coach("Coach1", 50);
Player p01 = new Player("p01", 18, 01, 180);
Player p02 = new Player("p02", 19, 02, 181);
Player p03 = new Player("p03", 20, 03, 182);
Player p04 = new Player("p04", 21, 04, 183);
Player p05 = new Player("p05", 22, 05, 184);
Player p06 = new Player("p06", 23, 06, 185);
Player p07 = new Player("p07", 24, 07, 186);
Player p08 = new Player("p08", 25, 08, 187);
Player p09 = new Player("p09", 26, 09, 188);
Player p10 = new Player("p10", 27, 10, 189);
Player p11 = new Player("p11", 28, 11, 190);
Player[] players1 = new Player[] { p01, p02, p03, p04, p05, p06, p07, p08, p09, p10, p11 };
Team t1 = new Team(c1, players1);

Coach c2 = new Coach("Coach1", 51);
Player p12 = new Player("p12", 29, 12, 191);
Player p13 = new Player("p13", 30, 13, 192);
Player p14 = new Player("p14", 31, 14, 193);
Player p15 = new Player("p15", 32, 15, 194);
Player p16 = new Player("p16", 33, 16, 195);
Player p17 = new Player("p17", 34, 17, 196);
Player p18 = new Player("p18", 35, 18, 197);
Player p19 = new Player("p19", 36, 19, 198);
Player p20 = new Player("p20", 37, 20, 199);
Player p21 = new Player("p22", 38, 21, 200);
Player p22 = new Player("p23", 39, 22, 201);
Player[] players2 = new Player[] { p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22 };
Team t2 = new Team(c1, players2);

for (int i = 0; i < 10; i++)
{
    Game g1 = new Game(t1, t2, r1, r2, r3);
    Console.WriteLine();
}
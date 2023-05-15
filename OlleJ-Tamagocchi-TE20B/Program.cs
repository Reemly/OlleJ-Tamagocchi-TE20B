using System;



Tamagotchi tama = new Tamagotchi();


while (tama.GetAlive() == true ) {
tama.printstats();
Console.WriteLine("what u wanna do with ur little guy");
Console.WriteLine($"1. learn {tama.name} new word");
Console.WriteLine($"2. converse with the {tama.name}");
Console.WriteLine($"3. feed some noms {tama.name}");
Console.WriteLine($"4. do nothin'");

string doAction = Console.ReadLine();

if (doAction == "1") {
    Console.WriteLine("teac hwhat ward");
    string word = Console.ReadLine();
    tama.Teach(word);
    
}

if (doAction == "2") {
    tama.heyo();
}

if (doAction == "3") {
    tama.Feed();
}

else 
{
    Console.WriteLine($"ur doing NOTHING with {tama.name} life");
}

tama.Tick();








}

Console.WriteLine("o no u killed it u monster");
Console.ReadLine();
Console.WriteLine("press enter to leave");


// Olle reminder 3080
//fokusera på program.cs, tror allt e klart i tamagotchi.cs
using System;
using System.Collections.Generic;
public class Tamagotchi
{
    private bool isALive;
    private int boredom;
    private int hunger;
    private Random generator;
    private List<string> words = new List<string>() { "no" };
    public string name;


    public Tamagotchi()
    {
        generator = new Random();
        isALive = true;

    }


    public void Tick()
    {
        hunger++;
        boredom++;

        if (hunger > 10 || boredom > 10)
        {
            isALive = false;
        }

    }



    public void Feed()
    {
        Console.WriteLine("m");
        hunger -= 2;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }


    public void heyo()
    {
    int numoword = generator.Next(words.Count);
    Console.WriteLine($"[{name}] says: {words[numoword]}");

    }

    public void ReduceBoredompls() 
    {
        Console.WriteLine($" [{name}] is less borred ヾ(＠^∇^＠)ノ");
        boredom -= 2;
        if (boredom < 0) {
            boredom = 0;
        }
    }

    public bool GetAlive() {
        return isALive = true;
    }





    public void printstats() {
        Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {boredom} || Dictionary: {words.Count} words");
    }

}
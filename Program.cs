using System;
public class Program{
    public static int round = 1;
    public static int rival = 0;
    public static int player = 0;
    public static void Main(string[] args){
        Console.Clear();
        Console.WriteLine("Dice\n\nIn this game you and a computer Rival will play 10 rounds\nwhere you will each roll a 6-sided dice, and the player\nwith the highest dice value will win the round. The player\nwho wins the most rounds wins the game. Good luck!\n\nPress any key to start...");
        while(round < 10){
        Console.ReadLine();
        switch(GameLoop()){
        case 1:
        rival++;
        break;
        case 2:
        player++;
        break;
        default:
        break;
        }
        Console.WriteLine("The score is now - You : " + player + ". Rival : " + rival + ".");
        round ++;
        }
        Console.ReadLine();
        Console.WriteLine("\nGame over.\nThe score is now - You : " + player + ". Rival : " + rival + ".");
        if(rival == player)
        Console.WriteLine("This game is a draw.");
        else if(rival > player)
        Console.WriteLine("You lost!");
        else
        Console.WriteLine("You won!");
        Console.WriteLine("Press any key to exit...");
        Thread.Sleep(34);
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Dice Game was closed.");
    }
    public static int GameLoop(){
        int w;
        int r = DiceRole();
        Console.Write("Round " + round + "\nRival rolled a " + r + "\nPress any key to continue...");
        Console.ReadLine();
        int p = DiceRole();
        Console.WriteLine("You rolled a " + p);
        if(r == p){
        Console.WriteLine("This round is a draw!");
        w = 9483271;
        }
        else if(r > p){
        Console.WriteLine("You won this round.");
        w = 1;
        }
        else{
        Console.WriteLine("The Rival won this round.");
        w = 2;
        }
        return w;
    }
    public static int DiceRole(){
        Random randy = new Random();
        int a;
        a = randy.Next(1,7);
        return a;
    }
}
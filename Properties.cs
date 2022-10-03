using System;

namespace Task;

class Game
{
    private int chances;
    private int scores;


    public int Chance
    {
        get { return chances; }
        set
        {
            if (value <= 0)
            {
                this.chances = 0;
            }
            else if (value > 3)
            {
                this.chances = 3;
            }
            else
            {
                this.chances = value;
            }
        }
    }
    public int score
    {
        get { return scores; }
        set
        {
            if (value <= 0)
            {
                this.scores = 0;
            }
            else if (value > 100)
            {
                this.scores = 100;
            }
            else
            {
                this.scores = value;
            }
        }

    }

    static void Main(string[] args)
    {
        Console.WriteLine("Chance Example\n\n");
        Game game = new Game();
        game.Chance = -1;
        Console.WriteLine(game.Chance);
        game.Chance = 300;
        Console.WriteLine(game.Chance);
        game.Chance = 2;
        Console.WriteLine(game.Chance);
        Console.WriteLine("Scores Example\n\n");
        Game obj = new Game();
        obj.score = -100;
        Console.WriteLine(obj.score);
        obj.score = 500;
        Console.WriteLine(obj.score);
        obj.score = 88;
        Console.WriteLine(obj.score);





    }


}

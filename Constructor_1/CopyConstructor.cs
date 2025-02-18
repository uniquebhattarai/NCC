using System;
namespace Constructor_1;

class Football
{
    string League;
    string Club;
    int LeaguePosition;

    public Football(string league, string club,int leaguePosition)
    {
        this.League = league;
        this.Club = club;
        this.LeaguePosition = leaguePosition;
    }

    public Football(Football f){
        this.Club=f.Club;
        this.League = f.League;
        this.LeaguePosition = f.LeaguePosition;
    }

    public void Display(){
        System.Console.WriteLine("Club:{0}",Club);
        System.Console.WriteLine("League:{0}",League);
        System.Console.WriteLine("LeaguePosition:{0}",LeaguePosition);
    }
}
class CopyConstructor
{
     static void Main(string[] args){
        Football ball = new Football("Premier League","Liverpool",1);
        Football ball1 = new Football(ball);

        System.Console.WriteLine("Original Object:");
        ball.Display();
        System.Console.WriteLine("\nCopied Object:");
        ball1.Display();

    }
}
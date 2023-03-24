
class Board
{
    public void Print()
    {
        
    }
}

class Player
{}

enum State {Preparation, Move_p1, Move_p2, Result};

class Application
{
    private Board board;
    private Player player1;
    private Player player2;
    private State state; 
    private string winner;
    
    public Application()
    {
        board = new Board();
        player1 = new Player();
        player2 = new Player();
        state = State.Preparation;

    }
    public void Start()
    {
        while (true)
        {
            switch (state)
            {
                case State.Preparation:
                    Console.WriteLine("Case preparation");
                    board.Print();
                    state = State.Move_p1;
                    break;
                case State.Move_p1:
                    Console.WriteLine("Case Move_pl1");
                    // player1 turn
                    // return board
                    // analize winner
                    // change state
                    return;
                case State.Move_p2:
                    Console.WriteLine("Case Move_pl2");
                    // player1 turn
                    // return board
                    // analize winner
                    // change state
                    break;
                case State.Result:
                    board.Print();
                    Console.WriteLine("The winner is " + winner);
                    Console.WriteLine("Want to continue playing?");
                    string answer = Console.ReadLine();
                    if (answer == "YES")
                    {
                        state = State.Preparation;
                        continue;
                    }

                    return;
            }
        }
    }

}

class Program
{
   private static void Main(string[] args)
    {
        Application tiktaktoe = new Application();
        tiktaktoe.Start();
        

        Console.WriteLine("Application is closed");
    }
}
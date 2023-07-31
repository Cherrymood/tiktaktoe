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
        player1 = new Player('X');
        player2 = new Player('O');
        state = State.Preparation;
        winner = " ";

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
                    player1.MakesMove(ref board);
                    board.Print();
                    if (BoardAnalyzer.CheckWinner(ref board))
                    {
                        winner = "Player1";
                        state = State.Result;
                    }
                    else
                    {
                        state = State.Move_p2;
                    }
                    break;
                case State.Move_p2:
                    Console.WriteLine("Case Move_pl2");
                    player2.MakesMove(ref board);
                    board.Print();
                    if (BoardAnalyzer.CheckWinner(ref board))
                    {
                        winner = "Player2";
                        state = State.Result;
                    }
                    else
                    {
                        state = State.Move_p1;
                    }
                    break;
                case State.Result:
                    Console.WriteLine("The winner is " + winner);
                    board.Print();
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
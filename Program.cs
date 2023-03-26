
class Board
{
    private char[] net = {'_', '_', '_', '_', '_', '_', '_', '_', '_'};

    public char this[int index]
    {
        get => net[index];
        set => net[index] = value;
    } 
    public void Print()
    {
    
        string boardnet = "";
        boardnet += net[0];
        boardnet += net[1];
        boardnet += net[2];
        boardnet += '\n';
        boardnet += net[3];
        boardnet += net[4];
        boardnet += net[5];
        boardnet += '\n';
        boardnet += net[6];
        boardnet += net[7];
        boardnet += net[8];

        Console.WriteLine(boardnet);
    }
}

class Player
{
    private char symbol_;

    public Player(char symbol)
    {
        symbol_ = symbol;
    }

    public void MakesMove(ref Board board) 
    {
        for (int i= 0; i < 9; i++)
        {
            if (board[i] != 'X' && board[i] != 'O')
            {
                board[i] = symbol_;
                break;
            }
            else
            {
                continue;
            }
        }
    }
}

class BoardAnalyzer
{
    public static bool CheckWinner(ref Board board)
    {
        if (board[0] == 'X' && board[1] == 'X' && board[2] == 'X')
        {
            return true;
        }
        else if (board[3] == 'X' && board[4] == 'X' && board[5] == 'X')
        {
            return true;
        }
        else if (board[6] == 'X' && board[7] == 'X' && board[8] == 'X')
        {
            return true;
        }
        else if (board[0] == 'X' && board[3] == 'X' && board[6] == 'X')
        {
            return true;
        }
        else if (board[1] == 'X' && board[4] == 'X' && board[7] == 'X')
        {
            return true;
        }
        else if (board[2] == 'X' && board[5] == 'X' && board[8] == 'X')
        {
            return true;
        }
        else if (board[0] == 'X' && board[4] == 'X' && board[8] == 'X')
        {
            return true;
        }
        else if (board[2] == 'X' && board[4] == 'X' && board[6] == 'X')
        {
            return true;
        }
        else if (board[0] == 'O' && board[1] == 'O' && board[2] == 'O')
        {
            return true;
        }
        else if (board[3] == 'O' && board[4] == 'O' && board[5] == 'O')
        {
            return true;
        }
        else if (board[6] == 'O' && board[7] == 'O' && board[8] == 'O')
        {
            return true;
        }
        else if (board[0] == 'O' && board[3] == 'O' && board[6] == 'O')
        {
            return true;
        }
        else if (board[1] == 'O' && board[4] == 'O' && board[7] == 'O')
        {
            return true;
        }
        else if (board[2] == 'O' && board[5] == 'O' && board[8] == 'O')
        {
            return true;
        }
        else if (board[0] == 'O' && board[4] == 'O' && board[8] == 'O')
        {
            return true;
        }
        else if (board[2] == 'O' && board[4] == 'O' && board[6] == 'O')
        {
            return true;
        }
        
        return false;

    }
}

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

class Program
{
   private static void Main(string[] args)
    {
        Application tiktaktoe = new Application();
        tiktaktoe.Start();
        

        Console.WriteLine("Application is closed");
    }
}
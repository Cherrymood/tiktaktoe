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
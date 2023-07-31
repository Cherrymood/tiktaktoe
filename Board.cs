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
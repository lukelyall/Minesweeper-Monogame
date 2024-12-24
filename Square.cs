namespace Minesweeper;

public class Square
{
    public bool mine { get; set; }
    public bool flagged { get; set; }
    public bool revealed { get; set; }
    public int adjacentMines { get; set; }

    public Square()
    {
        mine = false;
        flagged = false;
        revealed = false;
        adjacentMines = 0;
    }
}
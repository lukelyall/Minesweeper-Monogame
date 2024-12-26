using System;

namespace Minesweeper;

public class Board
{
    public int height { get; set; }
    public int width { get; set; }
    public Square[,] board;
    private int totalMines;

    private Random _random = new Random();

    public Board(int height, int width, int totalMines)
    {
        this.height = height;
        this.width = width;
        this.totalMines = totalMines;
        board = new Square[height, width];
        InitializeBoard();
    }

    private void InitializeBoard()
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                board[i, j] = new Square();
            }
        }
        SetMines();
        SetNumbers();
    }

    private void SetMines()
    {
        int setMines = 0;
        while (setMines < totalMines)
        {
            int row = _random.Next(0, width - 1);
            int col = _random.Next(0, height - 1);

            if (!board[row, col].mine)
            {
                board[row, col].mine = true;
                setMines++;
            }
        }
    }

    private void SetNumbers()
    {
        for (int row = 0; row < width; row++)
        {
            for (int col = 0; col < height; col++)
            {
                if (board[row, col].mine)
                {
                    continue;
                }
                int adjacentCount = 0;
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        int adjacentRow = row + i;
                        int adjacentCol = col + j;

                        if (adjacentRow >= 0 && adjacentRow < height && adjacentCol >= 0 && adjacentCol < width)
                        {
                            if (board[adjacentRow, adjacentCol].mine)
                            {
                                adjacentCount++;
                            }
                        }
                    }
                }
                board[row, col].adjacentMines = adjacentCount;
            }
        }
    }
}
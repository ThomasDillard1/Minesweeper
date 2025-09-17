public class Board
{
    public int Height { get; set; }
    public int Width { get; set; }
    public Cell[,] Cells { get; set; }

    private int mineCountLimit;
    private Random random = new Random();

    public Board(int height = 10, int width = 10, int mineCountLimit = 15)
    {
        Height = height;
        Width = width;
        this.mineCountLimit = mineCountLimit;
        Cells = new Cell[height, width];

        InitializeBoard();
    }

    private void InitializeBoard()
    {
        InitializeCells();
        PlaceMines();
        CalculateNumbers();
    }

    private void InitializeCells()
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                Cells[i, j] = new Cell();
            }
        }
    }

    private void PlaceMines()
    {
        int placedMines = 0;
        while (placedMines < mineCountLimit)
        {
            int i = random.Next(Height);
            int j = random.Next(Width);

            if (!Cells[i, j].IsMine)
            {
                Cells[i, j].IsMine = true;
                placedMines++;
            }
        }
    }

    private void CalculateNumbers()
    {
        
    }
}
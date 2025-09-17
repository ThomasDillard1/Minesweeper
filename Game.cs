using System.Reflection.Metadata;

public class Game
{
    private Board board;
    public void Start()
    {
        Renderer.ShowStartScreen();
        Board board = new Board();
    }
}

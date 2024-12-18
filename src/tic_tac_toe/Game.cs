using System;

public class GameTic
{
    char[,] board;
    public GameTic()
    {
        board = new char[,] {
        {' ', ' ', ' ',},
        {' ', ' ', ' ',},
        {' ', ' ', ' ',}
        };
    }
    public static void startGame()
    {
        GameTic game = new GameTic();
        game.drawSampleBoard();
        int player = 0;
        while (player < 9)
        {
            game.makeMove(player);
            player++;
            Console.WriteLine("\n Current Game Board : ");
            game.drawBoard();
        }

    }
    public void drawBoard()
    {
        Console.WriteLine("\t\t-------");
        Console.WriteLine($"\t\t|{board[0, 0]}|{board[0, 1]}|{board[0, 2]}|");
        Console.WriteLine("\t\t|-----|");
        Console.WriteLine($"\t\t|{board[1, 0]}|{board[1, 1]}|{board[1, 2]}|");
        Console.WriteLine("\t\t|-----|");
        Console.WriteLine($"\t\t|{board[2, 0]}|{board[2, 1]}|{board[2, 2]}|");
        Console.WriteLine("\t\t-------");
    }
    public void drawSampleBoard()
    {
        Console.WriteLine("\t\t-------");
        Console.WriteLine($"\t\t|0|1|2|");
        Console.WriteLine("\t\t|-----|");
        Console.WriteLine($"\t\t|3|4|5|");
        Console.WriteLine("\t\t|-----|");
        Console.WriteLine($"\t\t|6|7|8|");
        Console.WriteLine("\t\t-------");
    }
    private void makeMove(int player)
    {
        int move;
        char[] ox = new [] { 'O', 'X' };
        Console.WriteLine($"\n Player {player % 2 + 1} : Enter your Move :");
        move = Convert.ToInt32(Console.ReadLine());
        while (isnotValidMove(move) )
        {
            Console.WriteLine($"\n Player {player % 2 + 1} : Please Enter Valid Move :");
            move = Convert.ToInt32(Console.ReadLine());
        }
        board[ move / 3, move % 3] = ox[player % 2];
    }

    private bool isnotValidMove(int move)
    {
        if (move >= 0 && move < 9)
            if (board[move / 3, move % 3] == ' ')
                return false; 
        return true;
    }
}
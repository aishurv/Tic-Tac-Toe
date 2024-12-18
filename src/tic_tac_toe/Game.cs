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
            Console.WriteLine("\n Current Game Board : ");
            game.drawBoard();
            if (player > 3 && game.isWin())
            {
                Console.WriteLine("Congratulations :) :) :)");
                Console.WriteLine($"Player {player % 2 + 1} Win the Game !");
                break;
            }
            player++;
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
        /*
        int[,] moves = new int [,] {
        {1,2,3,4,8},
        {5,6,7,0,9}
        };
            */
        char[] ox = new [] { 'O', 'X' };

        Console.WriteLine($"\n Player {player % 2 + 1} : Enter your Move :");
        move = Convert.ToInt32(Console.ReadLine());

        //move = moves[player % 2, player / 2];

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
    private bool isWin()
    {
        if (board[0, 0] !=' ' && board[0, 1] == board[0, 0] && board[0, 1] == board[0, 2])
            return true;
        if (board[1, 0] != ' ' && board[1, 1] == board[1, 0] && board[1, 1] == board[1, 2])
            return true;
        if (board[2, 0] != ' ' && board[2, 1] == board[2, 0] && board[2, 1] == board[2, 2])
            return true;

        if (board[0, 0] != ' ' && board[1, 1] == board[0, 0] && board[0, 0] == board[2, 2])
            return true;
        if (board[0, 2] != ' ' && board[1, 1] == board[0, 2] && board[2, 0] == board[0, 2])
            return true;

        if (board[0, 0] != ' ' && board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
            return true;
        if (board[0, 1] != ' ' && board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1])
            return true;
        if (board[0, 2] != ' ' && board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
            return true;

        return false;
    }

}
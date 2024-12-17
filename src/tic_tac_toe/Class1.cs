using System;
namespace tic_tac_toe
{
	public class game
    {
		char[,] board;
		public game()
		{
			board = new char[,] {
			{' ', ' ', ' ',},
			{' ', ' ', ' ',},
			{' ', ' ', ' ',}
			};
			//int player = 0;
		}
		public void drawboard()
		{
			Console.WriteLine("\t\t-------");
			Console.WriteLine($"\t\t|{board[0, 0]}|{board[0, 1]}|{board[0, 2]}|");
			Console.WriteLine("\t\t|-----|");
			Console.WriteLine($"\t\t|{board[1, 0]}|{board[1, 1]}|{board[1, 2]}|");
			Console.WriteLine("\t\t|-----|");
			Console.WriteLine($"\t\t|{board[2, 0]}|{board[2, 1]}|{board[2, 2]}|");
			Console.WriteLine("\t\t-------");
		}

	}
};

using System;

namespace ThurdExam
{
	class Program
	{

		private int row;
		private int col;


		public Position(int size, int row, int col)
		{
			this.Size = size;
			this.Row = row;
			this.Col = col;
		}


		public int Size { get; set; }
		public int Row
		{
			get
			{
				return this.row;
			}
			set
			{
				if (value < 0 || value >= this.Size)
				{
					throw new Exception();
				}


				this.row = value;
			}
		}
		public int Col
		{
			get
			{
				return this.col;
			}
			set
			{
				if (value < 0 || value >= this.Size)
				{
					throw new Exception();
				}


				this.col = value;
			}
		}
	}
	public class Program
	{
		static void Main(string[] args)
		{
			int dimension = int.Parse(Console.ReadLine());


			char[,] matrix = new char[dimension, dimension];


			List<string> commands = Console.ReadLine().Split(",").ToList();


			FillUp(matrix);


			List<int> x = new List<int>();
			List<int> y = new List<int>();


			for (int i = 0; i < commands.Count; i++)
			{
				string[] test = commands[i].Split(" ");
				x.Add(int.Parse(test[0]));
				y.Add(int.Parse(test[1]));
			}
			bool win = false;


			int Player1Count = 0;
			int Player2Count = 0;

			for (int i = 0; i < commands.Count; i++)
			{
				if (x[i] < 0 || y[i] < 0 || x[i] > dimension || y[i] > dimension)
				{

				}
				else if (matrix[x[i], y[i]] == '<')//Ship of player
				{
					Player2Count++;
					matrix[x[i], y[i]] = 'X'; //hit player


					if (CheckforPlayer1(matrix) == 0)
					{
						Console.WriteLine($"Player One has won the game! {Player2Count} ships have been sunk in the battle.");
						win = true;
					}
				}
				else if (matrix[x[i], y[i]] == '>')//Ship of player2
				{
					Player1Count++;
					matrix[x[i], y[i]] = 'X';//hit player2

					if (CheckforPlayer2(matrix) == 0)
					{
						Console.WriteLine($"Player Two has won the game! {Player1Count} ships have been sunk in the battle.");
						win = true;
					}
				}
				else if (matrix[x[i], y[i]] == '#') //sea mine
				{
				}
				else
				{
					//matrix[x[i], y[i]] = '*';//nothing happens
				}
			}
			if (!win)
			{
				Console.WriteLine($"It's a draw! Player One has {CheckforPlayer1(matrix)} ships left. Player Two has {CheckforPlayer2(matrix)} ships left.");
			}


		}


		public static int CheckforPlayer1(char[,] matrix)
		{
			int checkCount = 0;

			foreach (var item in matrix)
			{
				if (item == '<')
				{
					checkCount++;
				}
			}


			return checkCount;
		}
		public static int CheckforPlayer2(char[,] matrix)
		{
			int checkCount = 0;

			foreach (var item in matrix)
			{
				if (item == '>')
				{
					checkCount++;
				}
			}


			return checkCount;
		}
		public static void FillUp(char[,] matrix)
		{
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				char[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();


				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					matrix[row, col] = input[col];
				}
			}
		}

	}
}
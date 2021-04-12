using System;

namespace SpaceStationEstablishment
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int stephenRow = 0;
            int stephenCol = 0;
            char[][] field = new char[size][];
            for (int r = 0; r < size; r++)

            {
                field[r] = new char[size];
                string col = Console.ReadLine();
                for (int c = 0; c < size; c++)
                {
                    char ch = col[c];
                    if (ch == 'S')
                    {
                        stephenRow = r;
                        stephenCol = c;
                    }
                    field[r][c] = ch;
                }
            }
            int star = 0;
            while (true)

            {
                field[stephenRow][stephenCol] = '-';
                // right -> row stays the same, col + 1
                //left row stays the same, col - 1
                // up -> row-1, col->same
                //down->row+1, col->same
                string command = Console.ReadLine();
                bool isOutOfField = false;
                switch (command)
                {
                    case "right":
                        stephenCol += 1;
                        break;
                    case "left":
                        stephenCol -= 1;
                        break;
                    case "up":
                        stephenRow -= 1;
                        break;
                    case "down":
                        stephenRow += 1;
                        break;
                    default:
                        break;
                }
             
                if (IsOutside(size, stephenRow, stephenCol))
                {
                    Console.WriteLine("Bad news, the spaceship went to the void.");
                    break;
                }
                char element = field[stephenRow][stephenCol];
                if (element =='O')
                {
                    field[stephenRow][stephenCol] = '-';
                    for (int r = 0; r < size; r++)
                        
                    {
                        bool found = false;
                        for (int c = 0; c < size; c++)
                        {
                            char currMatrixElement = field[r][c];
                            if (currMatrixElement == '0')
                            {
                                stephenRow = r;
                                stephenCol = c;
                                
                                found = true;
                                break;
                            }

                        }
                        if (found)
                        {
                            break;
                        }
                    }
                }
                else if(char.IsDigit(element))
                {
                    star += element - '0';
                   
                }
                field[stephenRow][stephenCol] = 'S';
                if (star >= 50)
                {
                    Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                    break;
                }
            }
            Console.WriteLine($"Star power collected: {star}");
            foreach (char[] col in field)
            {
                Console.WriteLine(string.Join(" ", col));
            }
        }
        private static bool IsOutside(int size, int stephenRow, int stephenCol)
        {
            return stephenRow >= size || stephenRow < 0 || stephenCol >= size || stephenCol < 0;
        }
    }
}

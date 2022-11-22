using System.Text;

namespace ConnectFour.Models
{
    public class Board
    {
        public char[,] EmptyCharBoard = new char[6, 7]
        {
            { ' ', ' ',  ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ',  ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ',  ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ',  ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ',  ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ',  ' ', ' ', ' ', ' ', ' ' },
        };
        public void SelectColumn(int colNumber, char playerSymbol)
        {
            int num = 0;
            int colNr = colNumber - 1;            

            for (int i = 0; i < EmptyCharBoard.GetUpperBound(1); i++)
            {
                var test = EmptyCharBoard[i, colNr];
                if (test != ' ' && !(i == 0 && test != ' '))
                {
                    num = i - 1;
                    EmptyCharBoard[num, colNr] = playerSymbol;
                    break;
                }
                if (i == EmptyCharBoard.GetUpperBound(0))
                {
                    num = i;
                }
            }
            EmptyCharBoard[num, colNr] = playerSymbol;
        }

        // prints board
        public override string ToString()
        {

            StringBuilder stringb = new StringBuilder();

            for (int i = 0; i < EmptyCharBoard.GetLength(0); i++)
            {
                for (int j = 0; j < EmptyCharBoard.GetLength(1); j++)
                {
                    stringb.Append("|" + EmptyCharBoard[i, j] + "|");
                }
                stringb.AppendLine();
            }
            return stringb.ToString();
        }

        public bool CheckGame(string symbol)
        {

            var result = CheckHorizontalWin(symbol) || CheckVerticalWin(symbol) || CheckDiagonalLeftTopToRightBottom(symbol) || CheckDiagonalLeftBottomTorightUp(symbol);
            return result;
        }
        private bool CheckHorizontalWin(string symbol)
        {
            string row = string.Empty;

            for (int i = 0; i <= EmptyCharBoard.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= EmptyCharBoard.GetUpperBound(1) && j >= 0 && j <= 7; j++)
                {
                    row += EmptyCharBoard[i, j];
                }
                // check string

                if (row.Contains(symbol))
                {
                    if (symbol == "XXXX")
                    {
                        Console.WriteLine("Player is the winner, horizontal 4 in a row");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Computer is the winner, horizontal 4 in a row");
                        return true;
                    }
                }
                row = string.Empty;
            }
            return false;

        }

        private bool CheckVerticalWin(string symbol)
        {
            string col = string.Empty;

            for (int i = 0; i <= EmptyCharBoard.GetUpperBound(1); i++)
            {
                for (int j = 0; j <= EmptyCharBoard.GetUpperBound(0) && j >= 0 && j <= 7; j++)
                {
                    col += EmptyCharBoard[j, i];
                }

                if (col.Contains(symbol))
                {
                    if (symbol == "XXXX")
                    {
                        Console.WriteLine("Player is the winner, vertical 4 in a row");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Computer is the winner, vertical 4 in a row");
                        return true;
                    }
                }
                col = string.Empty;
            }
            return false;
        }

        private bool CheckDiagonalLeftBottomTorightUp(string symbol)
        {
            string col = string.Empty;
            for (int i = 0; i <= EmptyCharBoard.GetUpperBound(0) + EmptyCharBoard.GetUpperBound(1); i++)
            {
                for (int j = 0; j <= EmptyCharBoard.GetUpperBound(0); j++)
                {
                    for (int h = 0; h <= EmptyCharBoard.GetUpperBound(1); h++)
                    {
                        if (i == j + h)
                        {
                            col += EmptyCharBoard[j, h];
                        }

                        if (col.Contains(symbol))
                        {
                            if (symbol == "XXXX")
                            {
                                Console.WriteLine("Player is the winner, diagonal left bottom to right top 4 in a row");
                                return true;
                            }
                            else
                            {
                                Console.WriteLine("Computer is the winner, diagonal left bottom to right top 4 in a row");
                                return true;
                            }
                        }
                    }
                }
                col = string.Empty;
            }
            return false;
        }

        private bool CheckDiagonalLeftTopToRightBottom(string symbol)
        {
            string col = string.Empty;
            for (int i = -EmptyCharBoard.GetUpperBound(0); i <= EmptyCharBoard.GetUpperBound(0); i++)
            {
                for (int j = EmptyCharBoard.GetUpperBound(0); j >= 0; j--)
                {
                    for (int h = EmptyCharBoard.GetUpperBound(1); h >= 0; h--)
                    {
                        if (i == j - h)
                        {
                            col += EmptyCharBoard[j, h];
                        }
                        if (col.Contains(symbol))
                        {
                            if (symbol == "XXXX")
                            {
                                Console.WriteLine("Player is the winner, diagonal left top to right bottom 4 in a row\"");
                                return true;
                            }
                            else
                            {
                                Console.WriteLine("Computer is the winner, diagonal left top to right bottom 4 in a row\"");
                                return true;
                            }
                        }
                    }
                }
                col = string.Empty;
            }
            return false;            
        }
    }
}

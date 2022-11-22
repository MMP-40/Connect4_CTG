// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using ConnectFour.Models;

// Determine turn
Random rnd = new Random();
TurnBased trn = new TurnBased();
trn.turn = rnd.Next(0,7);

// Ask Player 
Computer comPlayer = new Computer();
comPlayer.Sign = 'O';
HumanPlayer playerOne = new HumanPlayer("", 'X');
Console.WriteLine("what is your name player?");
playerOne.Name = Convert.ToString(Console.ReadLine());

// Define board
Board Board = new Board(); // default value is (6,7) 
if (trn.turn % 2 == 0) 
{
    do
    {
        Console.WriteLine("|1||2||3||4||5||6||7|");
        Console.WriteLine(Board.ToString());

        int selectedCol = playerOne.ExecuteTurn();
        Board.SelectColumn(selectedCol, playerOne.Sign);
        int inputCom = comPlayer.ExecuteTurn(selectedCol);
        Board.SelectColumn(inputCom, comPlayer.Sign);
      
    }
    while (!Board.CheckGame(playerOne.Symbool()) && !Board.CheckGame(comPlayer.Symbool()));
}
else
{
    int inputCom = comPlayer.ExecuteTurn(trn.turn);
    Board.SelectColumn(inputCom, comPlayer.Sign);
    do
    {
        Console.WriteLine("|1||2||3||4||5||6||7|");
        Console.WriteLine(Board.ToString());

        int selectedCol = playerOne.ExecuteTurn();
        Board.SelectColumn(selectedCol, playerOne.Sign);
        inputCom = comPlayer.ExecuteTurn(selectedCol);
        Board.SelectColumn(inputCom, comPlayer.Sign);     
    }
    while (!Board.CheckGame(playerOne.Symbool()) && !Board.CheckGame(comPlayer.Symbool()));
}


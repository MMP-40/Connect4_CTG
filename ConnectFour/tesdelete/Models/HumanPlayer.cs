namespace ConnectFour.Models
{

    public class HumanPlayer : Player
    {
        public HumanPlayer()
        {

        }

        public HumanPlayer(string name, char sign)
        {
            Name = name;
            Sign = sign;
        }

        public override int ExecuteTurn(int turn = 0)
        {
            Console.WriteLine(Name + " its your turn");
            Console.WriteLine("Choose your column");
            return Convert.ToInt32(Console.ReadLine());
        }

        public override string Symbool()
        {
            string symbol = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                symbol += Sign;
            }
            return symbol;
        }
    }
}

namespace ConnectFour.Models
{
    public class Computer : Player
    {
        public char Sign { get; set; }



        public Computer()
        {

        }

        public Computer (char sign)
        {
            Sign = sign;
        }
        public override int ExecuteTurn(int humanPlayerInput)
        {
            Sign = 'O';
            if (humanPlayerInput != 7)
            {
                humanPlayerInput += 1;
            }
            else
            {
                humanPlayerInput -= 1;
            }
            return humanPlayerInput;
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

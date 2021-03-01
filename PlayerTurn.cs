using System;

namespace tictactoeNy
{
    public class PlayerTurn : ShowBoard
    {
        public static int player = 1;

        private int y = 0;

        public void WhicePlayerToPlay()
        {
            do
            {
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 chance");
                    player++;
                }
                else
                {
                    Console.WriteLine("Player 1 chance");
                    player++;
                }

                y++;
                Console.WriteLine("\n");
            }

            while (y <= 0);
        }
    }
}
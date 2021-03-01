using System;

namespace tictactoeNy
{
    public class GameOutcome : ShowBoard
    {
        // winner
        public static int player = 1;

        public int Player1 = 0;
        public int player2 = 0;

        public static int winner = 0; //

        public int IsItWin()
        {
            if (arr[0] == arr[1] && arr[1] == arr[2]) // arr[0] är värde 1 på planen
            {
                return 1;
            }
            else if (arr[3] == arr[4] && arr[4] == arr[5])
            {
                return 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            else if (arr[0] == arr[3] && arr[3] == arr[6])
            {
                return 1;
            }
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[0] == arr[4] && arr[4] == arr[8])
            {
                return 1;
            }
            else if (arr[6] == arr[4] && arr[4] == arr[2])
            {
                return 1;
            }
            return 0;
        }

        public void Draw()
        {
            Console.WriteLine("It is a draw");
        }

        public void WhicePlayerWon()
        {
            if (player % 2 == 0)
            {
                Console.WriteLine("Congrats player 2 won");
            }
            else
            {
                Console.WriteLine("Congrats player 1 won");
            }
        }
    }
}
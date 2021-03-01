using System;

namespace tictactoeNy
{
    public class Markspot : ShowBoard
    {
        public static int player = 0;
        public static int winner = 0;

        private int choice = 0;

        public void PlaceMark()
        {
            GameOutcome gameOutcome = new GameOutcome();
            winner = gameOutcome.IsItWin();
            if (winner != 1)
            {
                choice = int.Parse(Console.ReadLine());
                if (arr[choice - 1] != 'X' && arr[choice - 1] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice - 1] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice - 1] = 'X';
                        player++;
                    }
                }
            }
            else
            {
                gameOutcome.WhicePlayerWon();
                arr = defaultArr;
            }
        }
    }
}
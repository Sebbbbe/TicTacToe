using System;

namespace tictactoeNy
{
    public class UpdateBoard
    {
        private readonly ShowBoard showBoard = new ShowBoard();
        private readonly PlayerTurn playerTurn = new PlayerTurn();

        private readonly GameOutcome gameOutcome = new GameOutcome();

        public void UpdatingBoard()
        {
            Console.Clear();

            WhicePlayerIsXAndO();

            showBoard.Board(); // show boards

            playerTurn.WhicePlayerToPlay(); // What player turn is it

            gameOutcome.IsItWin();
        }

        public static void WhicePlayerIsXAndO()
        {
            Console.WriteLine("Player 1: O and player 2: X \n ");
        }
    }
}
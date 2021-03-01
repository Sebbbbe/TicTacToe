namespace tictactoeNy
{
    public static class Program
    {
        private static int howManyTurnsPlayed;

        private static int winner = 0;

        // vart vill spelare lägga sin  mark

        public static void Main()
        {
            var markSpot = new Markspot();
            var updateBoard = new UpdateBoard();
            var gameOutcome = new GameOutcome();

            while (winner != 1)
            {
                winner = gameOutcome.IsItWin();

                updateBoard.UpdatingBoard();

                markSpot.PlaceMark(); // Places the player mark (X or O) on the spot they choose

                gameOutcome.IsItWin();

                howManyTurnsPlayed++;

                if (howManyTurnsPlayed == 9 && winner != 1)
                {
                    gameOutcome.Draw();
                    winner = 0;
                }
            }

            //  showBoard.Board(); // show boards

            //  playing.whicePlayerToPlay(); // What player turn is it

            // markSpot.placeMark(); // Places the player mark (X or O) on the spot they choose

            //choice
        }
    }
}
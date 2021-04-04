using System;

namespace Bejeweled.Assets.Scripts.Board.Business
{
    public class BoardCreator
    {
        public void Create(int boardWidth, int boardHeigth, int numberOfPieces){
            var board = new int[boardWidth,boardHeigth];

            var rnd = new Random();

            for (var col = 0; col < boardWidth; col++)
            {
                for (var lin = 0; lin < boardHeigth; lin++)
                {
                    board[col, lin] = rnd.Next(0, numberOfPieces);
                }
            }

            BoardStorage.SetBoard(board);
        }


    }
}

using System;

namespace Bejeweled.Assets.Scripts.Board
{
    public static class BoardStorage
    {
        private static int[,] _matrixBoard;

        // public BoardStorage(int width, int height)
        // {
        //     _matrixBoard = new int[width,height];
        // }

        public static void SetBoard(int[,] board){
            _matrixBoard = board;
        }

        public static int[,] GetBoard(){
            return _matrixBoard;
        }
    }
}

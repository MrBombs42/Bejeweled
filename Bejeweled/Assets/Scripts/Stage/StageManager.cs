using System;
using System.Text;
using Bejeweled.Assets.Scripts.Board;
using Bejeweled.Assets.Scripts.Board.Business;
using UnityEngine;

namespace Bejeweled.Assets.Scripts.Stage
{   
   public class StageManager : MonoBehaviour {
      
      [SerializeField] private int _piecesNumber;
      [SerializeField] private int _boardWidth;
      [SerializeField] private int _boardHeigth;



      void Start()
      {
        var boardCreator = new BoardCreator();
        boardCreator.Create(_boardWidth, _boardHeigth, _piecesNumber);

        PrintBoard();       
        
      }

      private void PrintBoard(){

         var output = new StringBuilder();
         var board = BoardStorage.GetBoard();
         for (var col = 0; col < _boardWidth; col++)
         {           
            for (var lin = 0; lin < _boardHeigth; lin++)
            {
               output.Append(board[col,lin]);  
               output.Append("|");             
            }
             output.AppendLine(" ");
           // output.AppendLine("____________");
         }

         Debug.Log(output);
      }
   }
}

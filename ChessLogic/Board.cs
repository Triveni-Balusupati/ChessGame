using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Board
    {
        // the board class will store all the active pieces of the game and provide various helper methods 
        //first add a rectanglar array for  storing the pieces
        private readonly Piece[,] pieces = new Piece[8, 8];// it must have 8 rows and 8 columns that because chess board have 8 by 8
        // Note: the array is private so outside code cannot access it directly instead we'll provide access through  an index which takes a row and column 
       
        public Piece this[int row, int col]
        {
            //we simply return the piece at the given position 
            get { return pieces[row, col]; } //it
            set { pieces[row, col] = value;}
        }
    }
}

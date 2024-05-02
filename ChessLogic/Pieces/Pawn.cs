using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Pawn :Piece
    {
        //now we must overwrite the type property
        public override PieceType Type => PieceType.Pawn; // it should be return PieceType.Pawn
        public override Player Color { get; }
       
        

        // to set this property we will add a constructor
        public Pawn(Player color)
        {
            // it's takes the color of the pawn either white or black and set the color property   
            Color = color;
        }

        //we implement the copy method
        public override Piece Copy()
        {
            // here we create  a new pawn instance with the same color as this pawn
            Pawn copy = new Pawn(Color);
            //and make sure it has the same has moved as well 
            copy.HasMoved = HasMoved; 

            // now we can return copy
            return copy;
        }
       
    }
}

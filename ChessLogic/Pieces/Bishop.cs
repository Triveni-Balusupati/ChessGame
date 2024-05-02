using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Bishop : Piece
    {
        // it must also overwrite the type and call our property 
        public override PieceType Type => PieceType.Bishop;
        public override Player Color { get; }

        // the constructor is exactly the same as pawn except for the name
        public Bishop(Player color)
        {
            Color = color;
        }

        public override Piece Copy()
        {
            Bishop copy = new Bishop(Color);
            copy.HasMoved = HasMoved; 
            return copy;
        }
    }
}

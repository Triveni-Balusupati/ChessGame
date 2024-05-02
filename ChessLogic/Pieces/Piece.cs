using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    // the piece class should be abstract because it dooen't represent a specific piece 

    public abstract class Piece
    {
        // it's just a base class that  all concrete pieces will inherit from here we will add two abstract properties which all pieces will be overide a type 
        public abstract PieceType Type { get; }

        //and a color either black or white represented using our player
        public abstract Player Color { get; }

        //we will add a regular boolen property called has moved which we set to false initially 
        public bool HasMoved { get; set; } = false;

        //we need has moved because some moves are only legal if a piece has not moved yet each piece must also implement a copy method
        public abstract Piece Copy();

    }
}

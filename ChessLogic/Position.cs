using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    // This class represents a position or square on bord
    //it  needs two properties one for row and another for column
    public class Position
    {
        // This class represents a position or square on bord
       //it  needs two properties one for row and another for column
        public int Row { get;}    
        public int Column { get;}    

        // I WILL use the convention that the square at row0, colmn 0 is the uper left corner
        //this implies that row increase from top to bottom and columns increase from left to right 
        //add a constuctor whicth takes a row and a column
        public Position(int row, int column)
        {
            //stores the properties
            Row = row;
            Column = column;
        }

        //IT will be convienent to know the color of the square at a given position
        //the position 0 0 for example is a white or light square
        //whereas the position 2,1 is a black or darksquare to support this check we add a square color method
        public Player Squarecolor()
        {
            //it returns player Value because we also use player to represent coloras if the sum of the row and column is evevn 
            if ((Row + Column) % 2 == 0)
            {
                //then the square is white
                return Player.White;
            }
            //other wise if the sum id odd then the square is black
            return Player.Blcak;
        }

        // we also need to overwrite equals and get harsh code so the position class can be used as the key in the dicstonary instead of doing so manually we can just get visual studio is do it for us
        // //just create an empty line 
        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Column == position.Column;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column);
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }

        //here we will overload the plus operator 
        public static Position operator +(Position pos, Direction dir)
        {
            //it takes a position and direcion as parameters and returns the position you can get by taking one step in the given direction
            //so  we written new position with row set and column set
            return new Position(pos.Row + dir.RowDelta, pos.Column + dir.ColumnDelta);
        }
    }
}

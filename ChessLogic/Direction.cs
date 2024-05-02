namespace ChessLogic
{
    
    public class Direction
    {
        // we start with the up or north direction to move up from a given position we subtract one row and leave the column unchanged so the row delta should be -1 and the column delta should be 0
        public readonly static Direction North = new Direction(-1, 0);

        //similarlly south direction row delta should be 1 and the column delta should be 0
        public readonly static Direction South = new Direction(1, 0);

        //similarlly south direction row delta should be 0 and the column delta should be 1
        public readonly static Direction East = new Direction(0, 1);

        //similarlly south direction row delta should be 0 and the column delta should be 1
        public readonly static Direction West = new Direction(0, -1);

        //we can also create directions for diagonal move from the northeast, we can use our overloaded plus operator to add north and east
        public readonly static Direction Northeast = North + East ;  

        // similarlly add for north west and south east and south west
        public readonly static  Direction NorthWest = North + West ;
        public readonly static  Direction SouthEast = South + East ;
        public readonly static  Direction SouthWest = South + West ;
      


        // this class will be generate moves because all pieces moves incertain directions 
        //we represent a direction as a row delta and column delta
        public int RowDelta { get; }
        public int ColumnDelta { get; }

        // that is the change in row and column from a given position
        //the constructor for this class just initialize these values
        public Direction (int rowDelta, int columnDelta)
        {
            RowDelta = rowDelta;
            ColumnDelta = columnDelta;
        }

        // it will also be convenient to have the ability to add two directions together
        // we will over write the plus operator 
        public static Direction operator +(Direction dir1, Direction dir2)
        {
            //so in the body we return a new Direction and set its row delta equal to the sum of the row deltas for direction1 and direction2 and similerlly for column
            return new Direction(dir1.RowDelta + dir2.RowDelta, dir1.ColumnDelta + dir2.ColumnDelta);
        }

        //let,s overwrite the multiplication operator as well so we can scale  a direction
        public static Direction operator * (int scalar, Direction dir) 
        {
            //again we written a new directoin 
            // this time with the scalar time the argument's the row and column delta 
            return new Direction(scalar * dir.RowDelta, scalar * dir.ColumnDelta);
        }
        //finally we can create all the basic directions we need  
    }
}

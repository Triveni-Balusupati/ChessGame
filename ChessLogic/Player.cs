using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public enum Player
    {
        //NONE value is use full because we can set the winning player to none in case of Draw
        none,
        White,
        Blcak
    }

    // color operation we need is to find the opponent of a given player so convinience
    // add an extension method to player
    public static class PlayerExtension
    {
        // give it a method called opponent
        public static Player Opponent(this Player player)
        {
            //it takes a player as parameter and returns that player's opponent inside the method we switch on the player parameter
            return player switch
            {
                // if it's player white 
                // case Player.White:
                //   return Player.Blcak; // we return player black
                // case Player.Blcak:
                //    return Player.White;//WE return player white
                //will always pass player black or player white to this method but to make the code compile
                ////add default case wich returns player none
                // case Player.none:
                //    return Player.none;
                // default:
                //  break;

                Player.White => Player.Blcak,
                Player.Blcak => Player.White,
                _ => Player.none,
            };
        }
    }
}

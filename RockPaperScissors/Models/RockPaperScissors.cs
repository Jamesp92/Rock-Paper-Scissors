using System.Collections.Generic;


namespace RockPaperScissors.Models
{
  public class PlayerMove
  {
  public string Move { get; set;}
  private static List<PlayerMove> _instances = new List<PlayerMove> {}; 
  public Item(string move)
  {
    Move = move;
    _instances.Add(this);
  }
  }
}


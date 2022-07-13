using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RockPaperScissors.Models;
using System;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RpsTest
  {

    // public void Dispose()
    // {
    //   PlayerMove.ClearAll();
    // }

      [TestMethod]
    public void GetInput_GetInputType_true()
    {
      PlayerMove player1move = new PlayerMove("test");
      PlayerMove player2move = new PlayerMove("test");
      string result1 = new PlayerMove(player1move);
      string result2 = new PlayerMove(player2move);

      Assert.AreEqual(player1move, result1);
      Assert.AreEqual(player2move, result2);
    }
  }
}
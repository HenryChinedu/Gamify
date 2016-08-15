using Gamify.Model.Concrete;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamify.UnitTests
{
    [TestFixture]
    public class BoardGameTests
    {
        [Test]
        public void CreateBoard_CheckMatrixLenght_ReturnsTrue()
        {
            int[,] result = BoardGame.CreateBoard();
            int index = result.Length;
            Assert.AreEqual(64, index);
        }
    }
}

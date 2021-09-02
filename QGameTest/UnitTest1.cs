using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace QGameTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void GetReturnsAList()
        {
            var sut = QGameData.QDataLink.GetQCards(10);
            Assert.AreEqual(sut.GetType(), new List<QGameData.QCard>().GetType());
        }

        [TestMethod]
        public void IfAmountIsHigherThen50ThrowsArgumentException()
        {
            void sut()
            {
                QGameData.QDataLink.GetQCards(60);
            }
            Assert.ThrowsException<ArgumentException>(sut);
        }
    }
}

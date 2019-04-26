using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter;

namespace WordCounterTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void SentenceContains_InputNonMatch_ScoreZero()
    {
      Counter newCounter = new Counter();
      Assert.AreEqual(0, newCounter.RepeatCounter("hello", "goodbye"));
    }
  }
}

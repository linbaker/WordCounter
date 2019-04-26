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
    [TestMethod]
    public void SentenceContains_InputMatch_ScoreOne()
    {
      Counter newCounter = new Counter();
      Assert.AreEqual(1, newCounter.RepeatCounter("hello", "hello"));
    }
    [TestMethod]
    public void SentenceContains_InputMatchCase_ScoreOne()
    {
      Counter newCounter = new Counter();
      Assert.AreEqual(1, newCounter.RepeatCounter("hello", "HeLlO"));
    }
    [TestMethod]
    public void SentenceContains_InputWordSentence_ScoreTwo()
    {
      Counter newCounter = new Counter();
      Assert.AreEqual(2, newCounter.RepeatCounter("hello", "HeLlO world I said hello"));
    }
    [TestMethod]
    public void SentenceContains_InputWordSentenceWithPerion_ScoreTwo()
    {
      Counter newCounter = new Counter();
      Assert.AreEqual(2, newCounter.RepeatCounter("hello", "HeLlO world I said hello."));
    }
    [TestMethod]
    public void SentenceContains_InputWordWithPunctuation_ScoreThree()
    {
      Counter newCounter = new Counter();
      Assert.AreEqual("cat", newCounter.PunctuationRemover("#cat!"));
    }
    [TestMethod]
    public void SentenceContains_InputWordSentenceWithPunctuation_ScoreThree()
    {
      Counter newCounter = new Counter();
      Assert.AreEqual(3, newCounter.RepeatCounter("cat", "Cat, the cat, thought 'I am the best cat!'"));
    }
    [TestMethod]
    public void SentenceContains_AccountForHyphen_ScoreTwo()
    {
      Counter newCounter = new Counter();
      Assert.AreEqual(2, newCounter.RepeatCounter("good-bye", "I said 'Good-bye' waving good-bye"));
    }
  }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounterTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void SentenceContains_InputNonMatch_ScoreZero()
    {
      Counter newCounter = new Counter("hello", "goodbye");
      Assert.AreEqual(0, newCounter.RepeatCounter());
    }
    [TestMethod]
    public void SentenceContains_InputMatch_ScoreOne()
    {
      Counter newCounter = new Counter("hello", "hello");
      Assert.AreEqual(1, newCounter.RepeatCounter());
    }
    [TestMethod]
    public void SentenceContains_InputMatchCase_ScoreOne()
    {
      Counter newCounter = new Counter("hello", "HeLlO");
      Assert.AreEqual(1, newCounter.RepeatCounter());
    }
    [TestMethod]
    public void SentenceContains_InputWordSentence_ScoreTwo()
    {
      Counter newCounter = new Counter("hello", "HeLlO world I said hello");
      Assert.AreEqual(2, newCounter.RepeatCounter());
    }
    [TestMethod]
    public void SentenceContains_InputWordSentenceWithPerion_ScoreTwo()
    {
      Counter newCounter = new Counter("hello", "HeLlO world I said hello.");
      Assert.AreEqual(2, newCounter.RepeatCounter());
    }
    [TestMethod]
    public void SentenceContains_InputWordWithPunctuation_ScoreThree()
    {
      Counter newCounter = new Counter("cat", "#cat");
      Assert.AreEqual("cat", newCounter.PunctuationRemover("#cat!"));
    }
    [TestMethod]
    public void SentenceContains_InputWordSentenceWithPunctuation_ScoreThree()
    {
      Counter newCounter = new Counter("cat", "Cat, the cat, thought 'I am the best cat!'");
      Assert.AreEqual(3, newCounter.RepeatCounter());
    }
    [TestMethod]
    public void SentenceContains_AccountForHyphen_ScoreTwo()
    {
      Counter newCounter = new Counter("good-bye", "I said 'Good-bye' waving good-bye");
      Assert.AreEqual(2, newCounter.RepeatCounter());
    }
  }
}

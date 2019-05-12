using System;
using System.Text;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter
  {
    public string WordToCount {get; set;}
    public string SentenceToCheck {get; set;}
    public static List<Counter> UserInput {get; set;} = new List<Counter> {};
    public int Id {get; set;}

    public Counter (string wordToCount, string sentenceToCheck)
    {
      WordToCount = wordToCount.ToLower();
      SentenceToCheck = sentenceToCheck.ToLower();
      UserInput.Add(this);
      Id = UserInput.Count;
    }

    public static void RemoveCounter(int id)
    {
      UserInput.Remove(UserInput[id - 1]);
    }

    public static void ClearAll()
    {
      UserInput.Clear();
    }

    public string PunctuationRemover(string compareWord)
    {
      char[] wordCharArray =compareWord.ToCharArray();
      StringBuilder builder = new StringBuilder();
      foreach(char letter in wordCharArray)
      {
        if(Char.IsLetter(letter))
        {
          builder.Append(letter);
        }
      }
      string puncRemoved = builder.ToString();
      return puncRemoved;
    }

    public int RepeatCounter()
    {
      int score = 0;
      string[] SentenceArray = SentenceToCheck.Split(' ');
      foreach(string compareWord in SentenceArray)
      {
        if(PunctuationRemover(compareWord) == PunctuationRemover(WordToCount))
        {
          score ++;
        }

      }
      return score;
    }
  }
}

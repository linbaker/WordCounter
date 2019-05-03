using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter
  {
    public string WordToCount {get; set;}
    public string SentenceToCheck {get; set;}
    public static List<Counter> UserInput {get; set;} = new List<Counter> {};
    public int Id {get; set;}
    private int _score = 0;
    private string _alphabet = "abcdefghijklmnopqrstuvwxyz-";

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
      string puncRemoved = "";
      for( int i = 0; i < wordCharArray.Length; i++)
      {
        bool alphabetical = _alphabet.Contains(Char.ToString(wordCharArray[i]));
        if(_alphabet.Contains(Char.ToString(wordCharArray[i])))
        {
          puncRemoved += wordCharArray[i];
        }
      }
      return puncRemoved;
    }

    public int RepeatCounter()
    {
      string[] SentenceArray = SentenceToCheck.Split(' ');
      foreach(string compareWord in SentenceArray)
      {
        if(PunctuationRemover(compareWord) == WordToCount)
        {
          _score ++;
        }

      }
      return _score;
    }
  }
}

using System;
namespace WordCounter
{
  public class Counter
  {

    int score = 0;
    public int RepeatCounter(string word, string sentence)
    {
      string lowerWord = word.ToLower();
      string lowerSentence = sentence.ToLower();
      string[] lowerSentenceArray = lowerSentence.Split(' ');
      foreach(string compareWord in lowerSentenceArray)
      {
        if(compareWord == lowerWord)
        {
          score ++;
        }

      }
      return score;
    }
  }
}

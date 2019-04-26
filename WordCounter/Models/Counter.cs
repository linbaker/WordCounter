using System;
namespace WordCounter
{
  public class Counter
  {

    public int RepeatCounter(string word, string sentence)
    {
      int score = 0;
      string lowerWord = word.ToLower();
      string lowerSentence = sentence.ToLower();
      if(lowerWord == lowerSentence)
      {
        score += 1;
      }
      return score;
    }
  }
}

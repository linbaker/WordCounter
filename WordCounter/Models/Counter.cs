using System;
namespace WordCounter
{
  public class Counter
  {
    private int _score = 0;
    private string _alphabet = "abcdefghijklmnopqrstuvwxyz";

    public string PunctuationRemover(string punctuatonWord)
    {
      char[] wordCharArray =punctuatonWord.ToCharArray();
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

    public int RepeatCounter(string word, string sentence)
    {
      string lowerWord = word.ToLower();
      string lowerSentence = sentence.ToLower();
      string[] lowerSentenceArray = lowerSentence.Split(' ');
      foreach(string compareWord in lowerSentenceArray)
      {
        if(PunctuationRemover(compareWord) == lowerWord || compareWord == String.Concat(lowerWord + "."))
        {
          _score ++;
        }

      }
      return _score;
    }
  }
}

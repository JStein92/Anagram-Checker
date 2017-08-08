using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class AnagramDetector
  {
    private string _currentWord;
    private string _currentAnagram;
    private List<string> _userAnagrams = new List<string>{};
    private List<string> _matchingAnagrams = new List <string>{};

    public AnagramDetector(string userWord, List<string> userWordList)
    {
      _currentWord = userWord;
      _userAnagrams = userWordList;
    }

    public string GetWord()
    {
      return _currentWord;
    }

    public List<string> GetMatchingAnagrams()
    {
        CheckAnagramList();
      return _matchingAnagrams;
    }

    public List<string> GetAnagrams()
    {

      return _userAnagrams;
    }

    public bool CheckAnagramList()
    {
      int amountMatching = 0;
      foreach(string s in _userAnagrams)
      {
        if (CheckAnagram(s) == true)
        {
          amountMatching ++;
          _matchingAnagrams.Add(s);
        }
      }
      if (amountMatching == _userAnagrams.Count)
      {
        return true;
      }
      else
      {
        return false;
      }

    }

    public bool CheckAnagram(string anagramToCheck)
    {

      char[] tempWordArray = _currentWord.ToCharArray();
      char[] tempAnagramArray = anagramToCheck.ToCharArray();
      bool lettersMatch = false;
      Array.Sort<char>(tempWordArray);
      Array.Sort<char>(tempAnagramArray);

      if (tempWordArray.Length == tempAnagramArray.Length)
      {
        for (int i = 0; i<tempWordArray.Length; i++)
        {
          if (tempWordArray[i] == tempAnagramArray[i])
          {
              lettersMatch = true;
          }
          else
          {
              lettersMatch = false;
              return lettersMatch;
          }
        }
      }

      return lettersMatch;

    }


  }
}

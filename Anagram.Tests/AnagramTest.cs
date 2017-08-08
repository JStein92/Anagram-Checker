using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;
using System;


namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void CheckAnagram_ReturnTrueIfAnagrams_Bool()
    {
      //Arrange
      List<string> testList= new List<string>{"beard"};
      AnagramDetector testDetector = new AnagramDetector("bread", testList);
      bool expected = true;
      //Act
      bool actual = testDetector.CheckAnagramList();
      //Assert
      Assert.AreEqual(expected,actual);
    }

    [TestMethod]
    public void CheckAnagram_ReturnTrueIfAllAreAnagrams_Bool()
    {
      //Arrange
      List<string> testList= new List<string>{"beard", "barde", "rabde", "ebdar"};
      AnagramDetector testDetector = new AnagramDetector("bread", testList);
      bool expected = true;
      //Act
      bool actual = testDetector.CheckAnagramList();
      //Assert
      Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void CheckAnagram_ReturnAllAnagramsThatMatch_List()
    {
      //Arrange
      List<string> testList= new List<string>{"beard", "barde", "rabde", "ebdaf"};
      AnagramDetector testDetector = new AnagramDetector("bread", testList);
      List<string> expected= new List<string>{"beard", "barde", "rabde"};
      //Act
      List<string> actual = testDetector.GetMatchingAnagrams();

      foreach(string s in actual)
      {
          Console.WriteLine("Matching word: " + s);
      }

      //Assert
      CollectionAssert.AreEqual(expected,actual);
    }
  }
}

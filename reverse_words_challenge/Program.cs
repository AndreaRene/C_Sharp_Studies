
using System.Xml.XPath;

string pangram = "The quick brown fox jumps over the lazy dog";

string[] wordsArray = pangram.Split(' ');

List<string> reversedWords = new List<string>();

foreach (string word in wordsArray){

    char[] letterArray = word.ToCharArray();
    Array.Reverse(letterArray);
    reversedWords.Add(new string(letterArray));

}

string result = string.Join(" ", reversedWords);

Console.WriteLine(result);
//Sort (array ascending), Reverse (array decending), Clear(elements in array), Resize(elements in array(bigger or smaller)), ToCharArray(string to new array of indiv chars) Split (array to indiv arrays), and Join (array elements into string)
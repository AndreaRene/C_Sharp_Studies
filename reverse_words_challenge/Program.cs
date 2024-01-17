
string pangram = "The quick brown fox jumps over the lazy dog";

//printed result: ehT kciuq nworb xof spmuj revo eht yzal god

//split to wordArray
//["The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog"]
string[] wordsArray = pangram.Split(' ');

List<string> reversedWords = new List<string>();
Console.WriteLine( wordsArray);
//loop through wordArray
foreach (string word in wordsArray){
    char[] letterArray = word.ToCharArray();
    // Console.WriteLine();

    //ToCharArray to letterArray
        //["T", "h", "e"]
    //reverse letterArray
        //["e", "h", "T"]
    //join to reverseWordString
        // "ehT"
    //append to new array?
            //["ehT", "kciuq", "nworb", "xof", "spmuj", "revo", "eht", "yzal", "god"]
    //join to new string?
        //"ehT kciuq nworb xof spmuj revo eht yzal god"
}


//Sort (array ascending), Reverse (array decending), Clear(elements in array), Resize(elements in array(bigger or smaller)), ToCharArray(string to new array of indiv chars) Split (array to indiv arrays), and Join (array elements into string)
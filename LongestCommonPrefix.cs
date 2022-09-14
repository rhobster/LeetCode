
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string longestPrefix = "";
        //Can't be longer than the shorest word
        List<string> wordsList = strs.ToList().OrderBy(x => x.Length).ToList();
        int? shortestWordLength  = wordsList.FirstOrDefault()?.Length;
        int charMatchCount = 0;
        bool exitOuterLoop = false;

        //Go through each letter of the shortest word. 
        for(int i = 0; i< shortestWordLength; i++){
            //Go through each word in the list. i is the letter in the word we are checking. c is the word
            for (int c= 0 ; c< wordsList.Count() -1; c++){
                if(wordsList[c][i] != wordsList[c + 1][i]){
                    Console.WriteLine("Break");
                    exitOuterLoop = true;
                    break;
                }
            }
            if(exitOuterLoop){break;}
            else{
              charMatchCount++;
            }
        }
        longestPrefix =  wordsList[0].Substring(0, charMatchCount);
        return longestPrefix;
    }

}


//Maybe look at doing a group by char and checking the count!
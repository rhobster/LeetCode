public class Solution {
    public int RomanToInt(string s) {
        var mapper = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int sum = 0;
        
        for(int i =0; i < s.Length -1; i++){
            if(mapper[s[i]] < mapper[s[i+1]]){
                sum -= mapper[s[i]];
            }
            else{
                sum += mapper[s[i]];
            }
        }
        //take care of the last one. Nothing will ever be after it so just add it.
        sum += mapper[s[s.Length - 1]];
        return sum;
    }
}
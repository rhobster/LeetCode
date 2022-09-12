public class Solution {
    public bool IsPalindrome(int x) {
        string xStr = x.ToString();
        int backIndex = xStr.Length - 1;
        
        for(int i =0; i < xStr.Length / 2; i++){
            if(xStr[i] != xStr[backIndex]){
                return false;
            }
            backIndex--;
        }
        return true;
    }
}
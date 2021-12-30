using System;

class Solution {
    public int solution(int N) {
        
        var number = N;
        var countModulo = 0;
        var maxModulo = 0;
        var gapCount = 0;

        while (number != 0) {
            var modulo = number%2;       
            if (modulo == 0) countModulo++;    
            if (modulo == 1) {
                gapCount++;
                if (countModulo > maxModulo && gapCount != 1){
                    maxModulo = countModulo;
                }
                countModulo = 0;
            }
            number = number / 2;
        }
        return maxModulo;
    }
}
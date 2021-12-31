using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        var numberOfZeros = 0;
        var numberOfOnes = 0;
        var numberOfZerosSmallerThanOnes = 0;

        foreach (var element in A){
            if(element == 0){
                numberOfZeros++;
                numberOfZerosSmallerThanOnes += numberOfOnes;
            }else if(element == 1){
                numberOfOnes++;
            }else {
                throw new Exception("Invalid number");
            }
        }

        long numberOfCombinations = Math.Abs((numberOfOnes * numberOfZeros) - numberOfZerosSmallerThanOnes);
        int result;

        if (numberOfCombinations > 1000000000){
            result = -1;            
        }else {
            result = (int) numberOfCombinations;
        }

        return result;
    }
}
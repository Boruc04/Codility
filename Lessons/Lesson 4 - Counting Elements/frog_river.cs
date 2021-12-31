using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        var theFurthestElement = 0; 

        for (int i = 0; i < X; i++ ){
            var wasFound = false;
            for (var j=0; j<A.Length; j++){
                if(i+1 == A[j]) {
                    theFurthestElement = j;
                    wasFound = true;
                    continue;
                }
            }
            if (!wasFound){
                return -1;
            }
        }
        return theFurthestElement;
    }
}
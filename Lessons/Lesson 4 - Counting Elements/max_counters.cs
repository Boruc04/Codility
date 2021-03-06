using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        var counters = new int[N];
        var highestCounter = 0;
        for (int i = 0; i < A.Length; i++){
            var value = A[i];
            
            if (value == N+1){
                for(int j=0; j<counters.Length;j++){        
                    counters[j]=highestCounter;
                }
            }else{
                counters[value-1]++;
                if (highestCounter < counters[value-1]){
                    highestCounter = counters[value-1];
                }
            }
        }
        return counters;
    }
}
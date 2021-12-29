using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        var max_value = 1000000; // 1 000 000
        var sortedA = new bool[max_value];
        
        for (int i = 0; i<A.Length; i++){
            var value = A[i];
            if(value <= 0) continue;
            sortedA[value] = true;     
        }

        for (int j = 1; j < sortedA.Length; j++){
            if (sortedA[j] == false) return j;
        }

        return 1;
    }
}

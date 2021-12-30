using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        var permutation = new bool[A.Length];
        for (int i = 0; i<A.Length; i++){
            var value = A[i];

            if(value <= A.Length && permutation[value-1] == false){
                permutation[value-1] = true;
            }else{
                return 0;
            }
        }
        return 1;
    }
}
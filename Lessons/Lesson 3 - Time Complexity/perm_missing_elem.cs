using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        var N = A.Length + 1;
        var expectedSum = N*(N+1)/2;
        var arrayElementsSum = 0;

        foreach (var element in A){
            arrayElementsSum += element;
        }

        return expectedSum - arrayElementsSum;
    }
}
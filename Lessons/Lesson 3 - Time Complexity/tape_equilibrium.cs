using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        int minimalDifference = Difference(A,1);

        for (int i = 1; i < A.Length; i++){
            var difference = Difference(A,i);
            if (minimalDifference > difference) minimalDifference = difference;
        }

        return minimalDifference;
    }

    private int Difference(int[] A, int P){
        int minuend = 0; //odjemna
        int subrahend = 0;  //odjemnik
        for (int i = 0; i<P; i++){
            minuend += A[i];
        }

        for (int i = P; i<A.Length; i++){
            subrahend += A[i];
        }

        return Math.Abs(minuend - subrahend);
    }
}
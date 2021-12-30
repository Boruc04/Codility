using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        var intDict = new Dictionary<int,int>();
        foreach (var number in A){
            
            if (intDict.ContainsKey(number)) {
                intDict[number]++;
            }
            else {
                intDict.Add(number,1);
            }           
        }

        foreach (var numberOfInts in intDict) {
            if (numberOfInts.Value % 2 == 1){
                return numberOfInts.Key;
            }
        }

        throw new Exception("This should never get here.");
    }
}
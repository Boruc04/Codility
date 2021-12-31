using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        var lightedBulbs = new bool[A.Length+1];
        var positionOfLastMoment = 1;
        var momentsCounter = 0;

        foreach (var bulb in A){
            lightedBulbs[bulb] = true;
            var allBulbsLighted = true;
            for (int j=positionOfLastMoment; j<bulb; j++){
                if (!lightedBulbs[j]){
                    allBulbsLighted = false;
                    break;
                } 
            }
            if (allBulbsLighted){
                momentsCounter++;
                positionOfLastMoment = bulb;
            }
        }

        return momentsCounter;
    }
}

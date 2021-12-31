using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        var intervals = new Tuple<int,int>[A.Length];
        
        for (int i = 0; i < A.Length; i++){
            intervals[i] = new Tuple<int, int>(A[i],B[i]);
        }

        // Chossing bubblesort over count sort because A anb B elements may have 2,000,000,000 combination that would require long array, where buble sort will have complexity O(n^2)= 1,000,000,000 but only as the worts scenario.
        var n = intervals.Length;
        do{
            for (int k=0; k<n-1; k++){
                if (intervals[k].Item1 > intervals[k+1].Item1){
                    var temp = intervals[k];
                    intervals[k] = intervals[k+1];
                    intervals[k+1] = temp; 
                }
            }
            n = n-1;
        }
        while (n > 1);


        var interval = intervals[0];
        var countIntervals = 1;
        for (var l = 1; l<intervals.Length; l++){
            if (interval.Item2 >= intervals[l].Item1){
                interval = new Tuple<int, int> (Math.Min(interval.Item1,intervals[l].Item1), Math.Max(interval.Item2,intervals[l].Item2));
            }else{
                interval = intervals[l];
                countIntervals++;
            }
        }
        return countIntervals;
    }
}

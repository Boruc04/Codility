using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        if (A.Length == K || K == 1 || K == 0) return A;
        
        var queue = new Queue<int>(A);
        while(--K != 0){
            queue.Enqueue(queue.Dequeue());
        }
        return queue.ToArray();
    }
}
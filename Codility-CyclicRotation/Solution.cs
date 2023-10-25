using System.Runtime.CompilerServices;

namespace Codility_CyclicRotation
{
    public class Solution
    {
        private const int RANGE_LOWEST_VALUE = 0;
        private const int RANGE_HIGHEST_VALUE = 100;
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int[] solution(int[] A, int K)
        {
            if (A.Length >= RANGE_LOWEST_VALUE && A.Length <= RANGE_HIGHEST_VALUE && K >= RANGE_LOWEST_VALUE && K <= RANGE_HIGHEST_VALUE) 
            {
                int N = A.Length;
                if (N == 0 || K % N == 0)
                    return A;  // No need to rotate if the array is empty or K is a multiple of N.

                int[] rotatedArray = new int[N];

                for (int i = 0; i < N; i++)
                {
                    int newPosition = (i + K) % N;  // Calculate the new position for the element.
                    rotatedArray[newPosition] = A[i];  // Copy the element to its new position.
                }

                return rotatedArray;
            }

            return Array.Empty<int>(); // return an empty array if the initial conditions are not met ; K>=0 && k<=100 ; A.Length>=0 && A.Length<=100
        }
    }
}

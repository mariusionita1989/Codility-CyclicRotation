using Codility_CyclicRotation;

namespace Codility_CyclicRotationTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 3, 8, 9, 7, 6 }, 3, new int[] { 9, 7, 6, 3, 8 })]
        [InlineData(new int[] { 0, 0, 0 }, 1, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 4, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 8, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { }, 2, new int[] { })]
        [InlineData(new int[] { 1 }, 0, new int[] { 1 })]
        public void Solution_RotatesArrayCorrectly(int[] inputArray, int rotations, int[] expectedArray)
        {
            Solution solution = new Solution();
            int[] result = solution.solution(inputArray, rotations);
            Assert.Equal(expectedArray, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, -1, new int[] { })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 101, new int[] { })]
        public void Solution_InvalidInput_ReturnsEmptyArray(int[] inputArray, int rotations, int[] expectedArray)
        {
            Solution solution = new Solution();
            int[] result = solution.solution(inputArray, rotations);
            Assert.Equal(expectedArray, result);
        }
    }
}
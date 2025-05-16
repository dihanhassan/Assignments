using Xunit;
using TwoSumLib;
namespace TwoSumTest
{
    public class TwoSumSolveTests
    {
        private readonly TwoSumSolve _solver = new();

        [Fact]
        public void NormalCase()
        {
            var result = _solver.TwoSum(new[] { 2, 7, 11, 15 }, 9);
            Assert.Equal(new[] { 0, 1 }, result);
        }

        [Fact]
        public void EdgeCase_MinInput()
        {
            var result = _solver.TwoSum(new[] { 1, 3 }, 4);
            Assert.Equal(new[] { 0, 1 }, result);
        }

        [Fact]
        public void DuplicateCase()
        {
            var result = _solver.TwoSum(new[] { 3, 3 }, 6);
            Assert.Equal(new[] { 0, 1 }, result);
        }

        [Fact]
        public void NoSolutionCase()
        {
            var result = _solver.TwoSum(new[] { 1, 2, 3 }, 10);
            Assert.Empty(result);
        }
    }
}
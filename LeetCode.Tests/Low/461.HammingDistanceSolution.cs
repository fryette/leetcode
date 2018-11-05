using System;
using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
	public class HammingDistanceTests
	{
		[Fact]
		public void Common_Test()
		{
			// Arrange
			var solution = new HammingDistanceSolution();

			//act
			var result = solution.HammingDistance(1, 4);

			//Assert
			Assert.Equal(2, result);
		}

		[Fact]
        public void Test_With_Max_Int()
        {
            // Arrange
            var solution = new HammingDistanceSolution();

            //act
			var result = solution.HammingDistance(4, 2147483647);

            //Assert
            Assert.Equal(30, result);
        }

		[Fact]
        public void Test_With_Identical_Values()
        {
            // Arrange
            var solution = new HammingDistanceSolution();

            //act
            var result = solution.HammingDistance(4, 4);
            
            //Assert
            Assert.Equal(0, result);
        }
	}
}

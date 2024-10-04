using NUnit.Framework;
using AtifAssignment2;

namespace AtifAssignment2Tests
{
    [TestFixture]
    public class TriangleTests
    {
        // Test for a valid equilateral triangle
        [Test]
        public void ValidTriangle_AllSidesEqual_ReturnsEquilateral()
        {
            // Arrange
            int firstAngle = 5;
            int secondAngle = 5;
            int thirdAngle = 5;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("Equilateral", result);
        }

    }
}
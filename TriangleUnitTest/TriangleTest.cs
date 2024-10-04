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

        // Tests for valid isosceles triangles
        [Test]
        public void ValidTriangle_FirstTwoSidesEqual_ReturnsIsosceles()
        {
            // Arrange
            int firstAngle = 5;
            int secondAngle = 5;
            int thirdAngle = 7;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("Isosceles", result);
        }

        [Test]
        public void ValidTriangle_LastTwoSidesEqual_ReturnsIsosceles()
        {
            // Arrange
            int firstAngle = 7;
            int secondAngle = 5;
            int thirdAngle = 5;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("Isosceles", result);
        }

        [Test]
        public void ValidTriangle_FirstAndLastSidesEqual_ReturnsIsosceles()
        {
            // Arrange
            int firstAngle = 6;
            int secondAngle = 8;
            int thirdAngle = 6;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("Isosceles", result);
        }

    }
}
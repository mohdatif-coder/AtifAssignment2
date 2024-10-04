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

        // Tests for valid scalene triangles
        [Test]
        public void ValidTriangle_AllSidesDifferent_ReturnsScalene()
        {
            // Arrange
            int firstAngle = 3;
            int secondAngle = 4;
            int thirdAngle = 5;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("Scalene", result);
        }

        [Test]
        public void ValidTriangle_AllSidesDifferentLargeNumbers_ReturnsScalene()
        {
            // Arrange
            int firstAngle = 100;
            int secondAngle = 101;
            int thirdAngle = 102;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("Scalene", result);
        }

        [Test]
        public void ValidTriangle_AllSidesDifferentSmallNumbers_ReturnsScalene()
        {
            // Arrange
            int firstAngle = 2;
            int secondAngle = 3;
            int thirdAngle = 4;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("Scalene", result);
        }

        [Test]
        public void ValidTriangle_AllSidesDifferentCloseValues_ReturnsScalene()
        {
            // Arrange
            int firstAngle = 10;
            int secondAngle = 11;
            int thirdAngle = 12;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("Scalene", result);
        }

        [Test]
        public void ValidTriangle_AllSidesDifferentPrimeNumbers_ReturnsScalene()
        {
            // Arrange
            int firstAngle = 11;
            int secondAngle = 13;
            int thirdAngle = 17;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("Scalene", result);
        }

        // Tests for verifying zero length for one or more sides
        [Test]
        public void ValidTriangle_FirstSideZero_ReturnsInvalid()
        {
            // Arrange
            int firstAngle = 0;
            int secondAngle = 5;
            int thirdAngle = 5;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("Invalid triangle: One or more sides have zero length", result);
        }

        [Test]
        public void ValidTriangle_SecondSideZero_ReturnsInvalid()
        {
            // Arrange
            int firstAngle = 5;
            int secondAngle = 0;
            int thirdAngle = 5;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("Invalid triangle: One or more sides have zero length", result);
        }

        [Test]
        public void ValidTriangle_ThirdSideZero_ReturnsInvalid()
        {
            // Arrange
            int firstAngle = 5;
            int secondAngle = 5;
            int thirdAngle = 0;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("Invalid triangle: One or more sides have zero length", result);
        }

        // Tests for verifying an invalid response (other than zero length)
        [Test]
        public void ValidTriangle_SumOfTwoSidesEqualToThird_ReturnsInvalid()
        {
            // Arrange
            int firstAngle = 3;
            int secondAngle = 4;
            int thirdAngle = 7;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("Invalid triangle: Sum of two sides must be greater than the third side", result);
        }

        [Test]
        public void ValidTriangle_SumOfTwoSidesLessThanThird_ReturnsInvalid()
        {
            // Arrange
            int firstAngle = 2;
            int secondAngle = 3;
            int thirdAngle = 6;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("Invalid triangle: Sum of two sides must be greater than the third side", result);
        }

        [Test]
        public void ValidTriangle_NegativeSide_ReturnsInvalid()
        {
            // Arrange
            int firstAngle = -1;
            int secondAngle = 5;
            int thirdAngle = 5;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("Invalid triangle: Sum of two sides must be greater than the third side", result);
        }

    }
}
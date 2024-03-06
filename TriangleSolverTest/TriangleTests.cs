using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;


namespace TriangleSolverTest

{
    public class TriangleSolverTest
    {

        [TestFixture]
        public class TriangleSolverTests1
        {
            // Equlilateral Triangle 
            [Test]
            public void AnalyzeTriangle_ValidEquilateral_ReturnsEquilateral()
            {
                // Arrange
                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 5;

                string expected = "It is Equilateral triangle";

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Equilateral triangle"));
            }
            // 
            [Test]
            public void AnalyzeTriangle_ValidIsosceles1_ReturnsIsosceles()
            {
                // Arrange
                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 7;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Isosceles triangle"));
            }

            [Test]
            public void AnalyzeTriangle_ValidIsosceles2_ReturnsIsosceles()
            {
                // Arrange
                int firstSide = 7;
                int secondSide = 5;
                int thirdSide = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Isosceles triangle"));
            }

            [Test]
            public void AnalyzeTriangle_ValidIsosceles3_ReturnsIsosceles()
            {
                // Arrange
                int firstSide = 5;
                int secondSide = 7;
                int thirdSide = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Isosceles triangle"));
            }

            [Test]
            public void AnalyzeTriangle_ValidScalene1_ReturnsScalene()
            {
                // Arrange
                int firstSide = 3;
                int secondSide = 4;
                int thirdSide = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Scalene triangle"));
            }

            [Test]
            public void AnalyzeTriangle_ValidScalene2_ReturnsScalene()
            {
                // Arrange
                int firstSide = 5;
                int secondSide = 12;
                int thirdSide = 13;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Scalene triangle"));
            }

            [Test]
            public void AnalyzeTriangle_ValidScalene3_ReturnsScalene()
            {
                // Arrange
                int firstSide = 8;
                int secondSide = 15;
                int thirdSide = 17;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Scalene triangle"));
            }

            [Test]
            public void AnalyzeTriangle_ValidScalene4_ReturnsScalene()
            {
                // Arrange
                int firstSide = 7;
                int secondSide = 10;
                int thirdSide = 12;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Scalene triangle"));
            }

            [Test]
            public void AnalyzeTriangle_ValidScalene5_ReturnsScalene()
            {
                // Arrange
                int firstSide = 9;
                int secondSide = 10;
                int thirdSide = 11;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Scalene triangle"));
            }

            [Test]
            public void AnalyzeTriangle_ZeroLengthSide1_ReturnsError()
            {
                // Arrange
                int firstSide = 0;
                int secondSide = 4;
                int thirdSide = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
            }

            [Test]
            public void AnalyzeTriangle_ZeroLengthSide2_ReturnsError()
            {
                // Arrange
                int firstSide = 3;
                int secondSide = 0;
                int thirdSide = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
            }

            [Test]
            public void AnalyzeTriangle_ZeroLengthSide3_ReturnsError()
            {
                // Arrange
                int firstSide = 3;
                int secondSide = 4;
                int thirdSide = 0;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
            }

            [Test]
            public void AnalyzeTriangle_InvalidResponse1_ReturnsError()
            {
                // Arrange
                int firstSide = 1;
                int secondSide = 2;
                int thirdSide = 10;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("INVALID!!"));
            }

            [Test]
            public void AnalyzeTriangle_InvalidResponse2_ReturnsError()
            {
                // Arrange
                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 12;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("INVALID!!"));
            }

            [Test]
            public void AnalyzeTriangle_InvalidResponse3_ReturnsError()
            {
                // Arrange
                int firstSide = 6;
                int secondSide = 10;
                int thirdSide = 25;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("INVALID!!"));
            }
        }
    }
}
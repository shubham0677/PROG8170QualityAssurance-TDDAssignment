using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CircleRadius;

namespace CircleRadiusTests
{
    [TestFixture]
    class CircleTests
    {
        Circle circle;

        [SetUp]
        public void Init()
        {
            circle = new Circle();
            circle.Radius = 5.0;
        }

        [Test]
        public void CreateCircleWithRadius()
        {
            Circle testCircle = new Circle(5.0);
            Assert.AreEqual(5.0, testCircle.Radius);
        } 

        [Test]
        public void AddToRadius()
        {
            double input = 2.5;
            circle.AddToRadius(input);
            Assert.AreEqual(7.5,circle.Radius);
        }

        [Test]
        public void AddNegativeValueToRadius()
        {
            double input = -4.6;
            circle.AddToRadius(input);
            Assert.AreEqual(5.0, circle.Radius);
        }

        [Test]
        public void SubtractFromRadius()
        {
            double input = 2.0;
            circle.SubtractFromRadius(input);
            Assert.AreEqual(3.0, circle.Radius);
        }

        [Test]
        public void SubtractFromRadiusConstraintCheck()
        {
            double input = 6.3;
            circle.SubtractFromRadius(input);
            Assert.AreEqual(5.0, circle.Radius);
        }

        [Test]
        public void GetCircumference()
        {
            double circumference = circle.GetCircumference();
            Assert.AreEqual(31.4, circumference);
        }
    }
}

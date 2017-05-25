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

        }
    }
}

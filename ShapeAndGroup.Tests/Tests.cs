using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeAndGroup.Measures;

namespace ShapeAndGroup.Tests
{
    [TestClass]
    public class Tests
    {
        private Random _rand = new Random();

        [TestMethod]
        public void CreateSquareAndFindMeasure()
        {
            var rand = _rand.Next(1,50) + _rand.NextDouble();
            var square = new Square(new Point(0, 0), rand, new Perimeter());
            Assert.AreEqual(rand * 4, square.GetMeasure());
            square = new Square(new Point(0, 0), rand, new Area());
            Assert.AreEqual((rand * rand), square.GetMeasure());
        }

        //может не пройти из-за PI
        [TestMethod]
        public void CreateCircleAndFindMeasure()
        {
            var rand = _rand.Next(1, 50);
            var rand2 = _rand.Next(1, 50);
            var ellipse = new Ellipse(new Point(0, 0), rand, rand2, new Perimeter());
            Assert.AreEqual((2 * Math.PI) * Math.Sqrt(((rand * rand2) * (rand * rand2)) / 2) , ellipse.GetMeasure());
            ellipse = new Ellipse(new Point(0, 0), rand, rand2, new Area());
            Assert.AreEqual(rand * rand2 * Math.PI, ellipse.GetMeasure());
        }

        [TestMethod]
        public void CreateTryangleAndFindMeasure()
        {
            var rand = _rand.Next(1,50) + _rand.NextDouble();
            var rand2 = _rand.Next(1,50) + _rand.NextDouble();
            var tryangle = new Tryangle(new Point(0, 0), rand, rand2, new Perimeter());
            Assert.AreEqual(rand + rand2+ tryangle.Hyppotenusa, tryangle.GetMeasure());
            tryangle = new Tryangle(new Point(0, 0), rand, rand2, new Area());
            Assert.AreEqual(rand*rand2/2, tryangle.GetMeasure());
        }

        [TestMethod]
        public void CreateGroupAndFindMeasure()
        {
            var rand = _rand.Next(1,50) + _rand.NextDouble();
            var rand2 = _rand.Next(1,50) + _rand.NextDouble();
            var ellipse = new Ellipse(new Point(0, 0), rand, rand2, new Perimeter());
            var tryangle = new Tryangle(new Point(0, 0), rand, rand2, new Perimeter());
            var square = new Square(new Point(0, 0), rand, new Perimeter());
            ShapeGroup<IMeasurable> sg = new ShapeGroup<IMeasurable>(new GroupMeasure(new AddOperator()));
            sg.Add(ellipse);
            sg.Add(tryangle);
            sg.Add(square);
            var groupMeasure = sg.GetMeasure();
            Assert.AreEqual(ellipse.GetMeasure() + tryangle.GetMeasure() + square.GetMeasure(), groupMeasure);
            var anotherGroup = new ShapeGroup<IMeasurable>(new GroupMeasure(new AddOperator()));
            anotherGroup.Add(ellipse);
            anotherGroup.Add(tryangle);
            anotherGroup.Add(square);
            sg.Add(anotherGroup);
            Assert.AreEqual(groupMeasure + anotherGroup.GetMeasure(), sg.GetMeasure());
        }
        
    }
}

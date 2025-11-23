using Tut2_s20123;

namespace ShapesTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestSphereCalculateArea()
        {
            var sphere = new Sphere(5);

            var area = sphere.CalculateArea();

            Assert.That(area, Is.EqualTo(100 * Math.PI).Within(0.00001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            var sphere = new Sphere(5);

            var volume = sphere.CalculateVolume();

            Assert.That(volume, Is.EqualTo((4.0 / 3.0) * Math.PI * 125).Within(0.00001));
        }

        [Test]
        public void TestCubeCalculateArea()
        {
            var cube = new Cube(5);

            var area = cube.CalculateArea();

            Assert.That(area, Is.EqualTo(6 * Math.Pow(5, 2)).Within(0.00001));
        }

        [Test]
        public void TestRectangleCalculateArea()
        {
            var rectangle = new Rectangle(5, 5);

            var area = rectangle.CalculateArea();

            Assert.That(area, Is.EqualTo(5 * 5).Within(0.00001));
        }

        [Test]
        public void RectangleVolumeReturnsZero()
        {
            var rect = new Rectangle(3, 4);

            var volume = rect.CalculateVolume();

            Assert.That(volume, Is.EqualTo(0).Within(0.00001));
        }


        [Test]
        public void CylinderCalculateArea()
        {
            var cylinder = new Cylinder(5, 5);

            var area = cylinder.CalculateArea();

            Assert.That(area, Is.EqualTo(2 * Math.PI * 5 * (5 + 5)).Within(0.00001));
        }

        [Test]
        public void CylinderCalculateVolume()
        {
            var cylinder = new Cylinder(5, 5);

            var volume = cylinder.CalculateVolume();

            Assert.That(volume, Is.EqualTo(Math.PI * Math.Pow(5, 2) * 5).Within(0.00001));
        }
    }
}
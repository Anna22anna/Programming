namespace Task16

{
    [TestFixture]
    public class RealPowerTests
    {

        [Test]
        public void ConstructorTest()
        {
            var power = new RealPower(2.0, 3.0);

            Assert.That(power.Basse, Is.EqualTo(2.0));
            Assert.That(power.Exponent, Is.EqualTo(3.0));
            Assert.That(power.Value, Is.EqualTo(8.0));
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void BasseSet_NegativeOrZeroValue_ArgumentOutOfRangeException(double val)
        {
            var realPower = new RealPower(1.0, 1.0);

            Assert.That(() => realPower.Basse = val, Throws.ArgumentException);
        }

        [Test]
        public void ValueTest()
        {
            var realPower = new RealPower(2.0, 3.0);

            Assert.That(realPower.Value, Is.EqualTo(8.0).Within(Math.Pow(10, -13)));
        }

        [TestCase(2.0, 3.0, 2.0, 3.0, true)]
        [TestCase(2.0, 3.0, 2.0, 4.0, false)]
        [TestCase(2.0, 3.0, 3.0, 3.0, false)]
        public void Equals_TwoRealPowers_ExpectedResult(double basse1, double exponent1, double basse2, double exponent2, bool expected)
        {
            var rp1 = new RealPower(basse1, exponent1);
            var rp2 = new RealPower(basse2, exponent2);

            Assert.That(rp1.Equals(rp2), Is.EqualTo(expected));
        }

        [Test]
        public void ToStringTest()
        {
            var realPower = new RealPower(2.0, 3.0);

            Assert.That(realPower.ToString(), Is.EqualTo("2E3"));
        }

        [Test]
        public void GetHashCodeTest()
        {
            var rp1 = new RealPower(2.0, 3.0);
            var rp2 = new RealPower(2.0, 3.0);

            Assert.That(rp1.GetHashCode(), Is.EqualTo(rp2.GetHashCode()));
        }

        [Test]
        public void MultiplyTest()
        {
            var rp1 = new RealPower(2.0, 3.0);
            var rp2 = new RealPower(2.0, 4.0);
            var result = rp1 * rp2;

            Assert.That(result.Basse, Is.EqualTo(2.0));
            Assert.That(result.Exponent, Is.EqualTo(7.0));
        }

        [Test]
        public void MultiplyDifferentBasses_ThrowsInvalidOperationException()
        {
            var rp1 = new RealPower(2.0, 3.0);
            var rp2 = new RealPower(3.0, 4.0);

            Assert.That(() => rp1 * rp2, Throws.InvalidOperationException.With.Message.EqualTo("Основания степени должны быть одинаковыми"));
        }

        [Test]
        public void DivideTest()
        {
            var rp1 = new RealPower(2.0, 4.0);
            var rp2 = new RealPower(2.0, 3.0);
            var result = rp1 / rp2;

            Assert.That(result.Basse, Is.EqualTo(2.0));
            Assert.That(result.Exponent, Is.EqualTo(1.0));
        }

        [Test]
        public void DivideDifferentBases_ThrowsInvalidOperationException()
        {
            var rp1 = new RealPower(2.0, 4.0);
            var rp2 = new RealPower(3.0, 3.0);

            Assert.That(() => rp1 / rp2, Throws.InvalidOperationException.With.Message.EqualTo("Основания степени должны быть одинаковыми"));
        }
    }
}
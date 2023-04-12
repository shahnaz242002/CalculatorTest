namespace ConsoleApp12.Test
{
   
    public class CalculatorTests
    {
        [TestCase(3,5,8)]
        public void Addtest(int a, int b,int expected)

       {

         int actual = Calculator.Add(a,b);
         Assert.AreEqual(expected, actual);

       }

        [TestCase(10, 6, 4)]
        public void subtracttest(int a, int b, int expected)

        {

            int actual = Calculator.subtract(a, b);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(12,6,2)]
        [TestCase(-6,2,-3)]
        [TestCase(0,5,0)]
        public void dividetest(int a, int b, double expected)

        {

            double actual = Calculator.divide(a,b);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void dividetest_WhenbIsZero_ShouldArgumentExaption()
        {
            int a = 100;
            int b=0;
            Assert.Throws<ArgumentException>(()=> Calculator.divide(a, b));

        }

        [TestCase(2,3,6)]
        public void multiplytest(int a, int b, int expected)

        {

            int actual = Calculator.multiply(a, b);
            Assert.AreEqual(expected, actual);

        }


    }
}
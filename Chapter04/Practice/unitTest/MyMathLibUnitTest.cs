using Mmath;
using Xunit;
namespace MyMathLibUnitTest{
    public class MyMathLibUnit{
        [Fact]
        public void factorsOfFour(){
            //arrange
            long n = 4;
            string answer="2*2";
            var test=new MyMath();
            //act
            string ts= test.CalculatePrimeFactors(n);
            //assert
            Assert.Equal(answer,ts);
        }
    }   
}
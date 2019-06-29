using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CheckValidations()
        {
            ConsoleCalculator.Validations x = new ConsoleCalculator.Validations();

            string test = "123";
            string[] testOut = {"123","digit"};
            Assert.Equal(testOut,x.Validate(test));

            string[] tests_optr = {"+","-","x","/"};
            foreach(string optr in tests_optr)
            {
                testOut[0] = optr;
                testOut[1] = "operator";
                Assert.Equal(testOut, x.Validate(optr));
            }

            string[] tests_special = { "s", "c", "="};
            foreach (string spcl in tests_special)
            {
                testOut[0] = spcl;
                testOut[1] = "special";
                Assert.Equal(testOut, x.Validate(spcl));
            }

        }
    }
}

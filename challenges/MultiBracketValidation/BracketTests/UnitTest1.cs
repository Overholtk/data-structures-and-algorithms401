using System;
using Xunit;
using MultiBracketValidations;

namespace BracketTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Expected_Outcome()
        {
            //????? cannot find method without going through this path
            bool test = MultiBracketValidations.Program.MultiBracketValidation("[fsds]");
            Assert.True(test);
        }

        [Fact]
        public void Test_Expected_Failiure()
        {
            bool test = MultiBracketValidations.Program.MultiBracketValidation("((sf)");
            Assert.False(test);
        }

        [Fact]
        public void Test_Empty_String()
        {
            bool test = MultiBracketValidations.Program.MultiBracketValidation("");
            Assert.False(test);
        }

        [Fact]
        public void Test_No_Brackets()
        {
            bool test = MultiBracketValidations.Program.MultiBracketValidation("fjdslf");
            Assert.False(test);
        }


    }
}

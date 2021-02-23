using Hashtable;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HashTests
{
    public class RepeatWordTests
    {

        [Fact]
        public void ExpectedOutcome()
        {
            string s = "Once upon a time, there was a brave princess who...";
            Assert.Equal("a", RepeatedWord.FirstRepeatedWord(s));
        }

        [Fact]
        public void ExpectedFail()
        {
            string s = "Read all of the following instructions carefeully.";
            Assert.Null(RepeatedWord.FirstRepeatedWord(s));
        }

        [Fact]
        public void EdgeCase()
        {
            string s = "";
            Assert.Null(RepeatedWord.FirstRepeatedWord(s));
        }
    }
}

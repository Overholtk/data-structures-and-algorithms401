using System;
using System.Collections.Generic;
using Xunit;

namespace Hashtable
{
    public class UnitTest1
    {
        [Fact]
        public void AddKeyValue()
        {
            Hashmap hash = new Hashmap(5);
            hash.Add("color", "red");
            Assert.True(hash.Contains("color"));
        }

        [Fact]
        public void RetrieveValue()
        {
            Hashmap hash = new Hashmap(5);
            hash.Add("color", "red");
            Assert.Equal("red", hash.Get("color"));
        }

        [Fact]
        public void CheckNonexistentValue()
        {
            Hashmap hash = new Hashmap(5);
            hash.Add("color", "red");
            Assert.Null(hash.Get("fruit"));
        }

        [Fact]
        public void HandleCollison()
        {
            Hashmap hash = new Hashmap(5);
            hash.Add("color", "red");
            hash.Add("color", "blue");
            int hashvalue = hash.Hash("color");
            LinkedList<KeyValuePair<string, string>> keyValues = hash.Map[hashvalue];
            int count = keyValues.Count;
            Assert.Equal(2, count);
        }

    }
}

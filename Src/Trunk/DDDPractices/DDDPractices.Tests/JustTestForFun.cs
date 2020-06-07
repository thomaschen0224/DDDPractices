using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace DDDPractices.Tests
{
    [TestFixture]
    public class JustTestForFun
    {



        

        [Test]
        public void TestDictionaryList()
        {

            var dictionary = new Dictionary<string, string>();
            dictionary.Add("test","123");
            dictionary.Add("TEST","223");
            

            var value = dictionary["test"];
            
            Console.WriteLine($"Value: {value}");





        }
        
        
        
    }
}
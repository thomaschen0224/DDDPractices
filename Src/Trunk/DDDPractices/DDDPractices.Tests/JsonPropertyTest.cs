using System;
using System.IO;
using DDDPractices.Tests.Models;
using Newtonsoft.Json;
using NUnit.Framework;

namespace DDDPractices.Tests
{
    [TestFixture]
    public class JsonPropertyTest
    {




        [Test]
        public void ShouldDeserializedObject()
        {
            var file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Samples", "failed-case.json");
            var json = File.ReadAllText(file);
            var model = JsonConvert.DeserializeObject<ReCaptchaModel>(json);
            
            Console.WriteLine($"{model.Action}");


        }
        
        
        
        
        
    }
}
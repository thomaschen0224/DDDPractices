using System;
using System.Threading.Tasks;
using DDDPractices.Services;
using NUnit.Framework;

namespace DDDPractices.Tests
{
    [TestFixture]
    public class DoSomethingServiceTest
    {

        private IDoSomethingService _doSomethingService;

        [SetUp]
        public void Initial()
        {
            _doSomethingService = InstanceFactory.GetInstance<IDoSomethingService>();
        }

        [Test]
        public async Task ShouldGetMessage()
        {
            var message = $"Hello Home!";
            var result = await _doSomethingService.GetMessageAsync(message);
            
            Console.WriteLine(result);



        }
        
        
        
        
        
    }
}
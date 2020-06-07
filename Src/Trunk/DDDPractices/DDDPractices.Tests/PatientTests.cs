using System;
using FluentAssertions;
using NUnit.Framework;

namespace DDDPractices.Tests
{
    [TestFixture]
    public class PatientTests
    {

        [SetUp]
        public void Initiate()
        {
            InstanceFactory.Initiate();
        }

        [Test]
        public void ShouldGetMessage()
        {
            var msgRepo = InstanceFactory.GetInstance<IMessageRepository>();
            var content = msgRepo.GetMessage("test");
            
            Console.WriteLine(content);

        }

        [Test]
        public void ShouldRaiseEvents()
        {
            
            InstanceFactory.Initiate();
            
            var patient = new Patient("Thomas", "Chen", "123-123-1234");
            
            patient.ChangeName("Sally", "Chen");
            patient.ChangePhone("222-333-5555");
            patient.SaveChanges();

            patient.LastName.Should().Be("Chen");


        }

        [Test]
        public void ShouldGetNameChangedEventHanlder()
        {
            
            var nameChangedEvent = new NameChangedEvent("test", "test2");
            var handler = InstanceFactory.GetInstance<IHandler<NameChangedEvent>>();
            handler.Handle(nameChangedEvent);
        }
        
        
        
    }
}
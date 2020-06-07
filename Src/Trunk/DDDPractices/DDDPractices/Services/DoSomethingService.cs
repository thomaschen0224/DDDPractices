using System;
using System.Threading;
using System.Threading.Tasks;

namespace DDDPractices.Services
{
    public class DoSomethingService : IDoSomethingService
    {




        public async Task<string> GetMessageAsync(string message)
        {

            return await Task<string>.Run(() =>
            {
                Thread.Sleep(2000);
                var s = $"New message:{DateTime.Now:d} - {message}";
                throw new Exception("I found some error!");
                return s;
            });


        }
        
        
        
        
    }
}
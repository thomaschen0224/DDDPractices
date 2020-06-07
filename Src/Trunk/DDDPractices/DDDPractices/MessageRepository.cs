using System;

namespace DDDPractices
{
    public class MessageRepository : IMessageRepository
    {


        public string GetMessage(string msg)
        {
            return $"{DateTime.Now:d} - {msg}";
        }
        
        
        
    }
}
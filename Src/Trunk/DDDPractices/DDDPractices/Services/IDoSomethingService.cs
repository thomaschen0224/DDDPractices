using System.Threading.Tasks;

namespace DDDPractices.Services
{
    public interface IDoSomethingService
    {
        Task<string> GetMessageAsync(string message);
    }
}
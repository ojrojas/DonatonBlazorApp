using System.Threading.Tasks;
using DonatonBlazor.Models;

namespace DonatonBlazor.Interfaces
{
    public interface ILoginService
    {
        Task<string> Login(ILoginModel model);
    }
}


using System;
using System.Threading.Tasks;
using HelloDotNet.ViewModels.System.Users;

namespace HelloDotNet.Application.System.Users
{
    public interface IUserService
    {
        Task<string> Authenticate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
    }
}

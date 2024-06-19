using OlimpiadasApi.Models;
namespace OlimpiadasApi.IServices;

public interface IJuezService
{
    public Task<Boolean> Login(string username, string password);
    public Task<Boolean> ForgotPassword(string username);
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OlimpiadasApi.Models;
using OlimpiadasApi.IServices;
namespace OlimpiadasApi.Services;

public class JuezService : IJuezService
{
    private readonly OlympicsContext _context;

    public JuezService(OlympicsContext context)
    {
        _context = context;
    }

    // A hash could be good 
    public async Task<Boolean> Login(string username, string password)
    {
        var judge = await _context.Jueces.FirstOrDefaultAsync(j => j.Usuario == username);

        if (judge == null)
        {
            return false;
        }

        if (password == judge.Contraseña)
        {
            return false;
        }

        return true;
    }

    // Needs implementation
    public async Task<Boolean> ForgotPassword(string username)
    {
        return true;
    }
}

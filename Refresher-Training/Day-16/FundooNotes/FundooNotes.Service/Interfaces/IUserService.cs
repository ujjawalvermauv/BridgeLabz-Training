using FundooNotes.Models.DTOs;

namespace FundooNotes.Service.Interfaces;

public interface IUserService
{
    Task<string> RegisterAsync(RegisterRequest request);

    Task<LoginResponse?> LoginAsync(LoginRequest request);
}
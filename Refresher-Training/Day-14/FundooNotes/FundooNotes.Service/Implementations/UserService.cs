using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BCrypt.Net;
using FundooNotes.Models.DTOs;
using FundooNotes.Models.Entities;
using FundooNotes.Repository.Interfaces;
using FundooNotes.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace FundooNotes.Service.Implementations;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IConfiguration _configuration;

    public UserService(
        IUserRepository userRepository,
        IConfiguration configuration)
    {
        _userRepository = userRepository;
        _configuration = configuration;
    }

    public async Task<string> RegisterAsync(RegisterRequest request)
    {
        var existingUser =
            await _userRepository.GetByEmailAsync(request.Email);

        if (existingUser != null)
        {
            return "Email already registered.";
        }

        var user = new User
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password)
        };

        await _userRepository.CreateAsync(user);

        return "User registered successfully.";
    }

    public async Task<LoginResponse?> LoginAsync(LoginRequest request)
    {
        var user =
            await _userRepository.GetByEmailAsync(request.Email);

        if (user == null)
        {
            return null;
        }

        bool passwordValid =
            BCrypt.Net.BCrypt.Verify(
                request.Password,
                user.PasswordHash);

        if (!passwordValid)
        {
            return null;
        }

        var token = GenerateJwtToken(user);

        return new LoginResponse
        {
            Token = token,
            Message = "Login successful."
        };
    }

    private string GenerateJwtToken(User user)
    {
        var jwtSettings = _configuration.GetSection("Jwt");

        var key = jwtSettings["Key"]
                  ?? throw new InvalidOperationException(
                      "JWT Key is missing.");

        var issuer = jwtSettings["Issuer"];

        var audience = jwtSettings["Audience"];

        var expiryMinutes =
            int.Parse(jwtSettings["ExpiryMinutes"] ?? "60");

        var claims = new List<Claim>
        {
            new Claim(
                ClaimTypes.NameIdentifier,
                user.Id.ToString()),

            new Claim(
                ClaimTypes.Email,
                user.Email),

            new Claim(
                ClaimTypes.Name,
                $"{user.FirstName} {user.LastName}")
        };

        var securityKey =
            new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(key));

        var credentials =
            new SigningCredentials(
                securityKey,
                SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: issuer,
            audience: audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(expiryMinutes),
            signingCredentials: credentials);

        return new JwtSecurityTokenHandler()
            .WriteToken(token);
    }
}
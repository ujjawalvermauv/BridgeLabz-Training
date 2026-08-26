using FundooNotes.Models.DTOs;
using FundooNotes.Models.Entities;
using FundooNotes.Repository.Interfaces;
using FundooNotes.Service.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Fundoo.Tests;

[TestClass]
public class UserServiceTests
{
    private Mock<IUserRepository> _userRepoMock;
    private Mock<IConfiguration> _configMock;
    private UserService _userService;

    [TestInitialize]
    public void Setup()
    {
        _userRepoMock = new Mock<IUserRepository>();
        _configMock = new Mock<IConfiguration>();

        // Setup mock config for JWT
        var configSectionMock = new Mock<IConfigurationSection>();
        configSectionMock.Setup(x => x["Key"]).Returns("ThisIsAVerySecretKeyForJwtAuthentication");
        configSectionMock.Setup(x => x["Issuer"]).Returns("TestIssuer");
        configSectionMock.Setup(x => x["Audience"]).Returns("TestAudience");
        configSectionMock.Setup(x => x["ExpiryMinutes"]).Returns("60");

        _configMock.Setup(x => x.GetSection("Jwt")).Returns(configSectionMock.Object);

        _userService = new UserService(_userRepoMock.Object, _configMock.Object);
    }

    [TestMethod]
    public async Task RegisterAsync_ShouldReturnError_WhenEmailExists()
    {
        var request = new RegisterRequest { Email = "test@test.com" };
        _userRepoMock.Setup(x => x.GetByEmailAsync(request.Email)).ReturnsAsync(new User());

        var result = await _userService.RegisterAsync(request);

        Assert.AreEqual("Email already registered.", result);
    }

    [TestMethod]
    public async Task RegisterAsync_ShouldRegister_WhenEmailIsNew()
    {
        var request = new RegisterRequest { Email = "new@test.com", Password = "Pass" };
        _userRepoMock.Setup(x => x.GetByEmailAsync(request.Email)).ReturnsAsync((User)null!);

        var result = await _userService.RegisterAsync(request);

        Assert.AreEqual("User registered successfully.", result);
        _userRepoMock.Verify(x => x.CreateAsync(It.IsAny<User>()), Times.Once);
    }

    [TestMethod]
    public async Task LoginAsync_ShouldReturnNull_WhenInvalidEmail()
    {
        var request = new LoginRequest { Email = "wrong@test.com" };
        _userRepoMock.Setup(x => x.GetByEmailAsync(request.Email)).ReturnsAsync((User)null!);

        var result = await _userService.LoginAsync(request);

        Assert.IsNull(result);
    }

    [TestMethod]
    public async Task LoginAsync_ShouldReturnNull_WhenInvalidPassword()
    {
        var request = new LoginRequest { Email = "test@test.com", Password = "wrong" };
        var user = new User { PasswordHash = BCrypt.Net.BCrypt.HashPassword("correct") };
        _userRepoMock.Setup(x => x.GetByEmailAsync(request.Email)).ReturnsAsync(user);

        var result = await _userService.LoginAsync(request);

        Assert.IsNull(result);
    }

    [TestMethod]
    public async Task LoginAsync_ShouldReturnToken_WhenCredentialsValid()
    {
        var request = new LoginRequest { Email = "test@test.com", Password = "correct" };
        var user = new User { Id = 1, Email = "test@test.com", PasswordHash = BCrypt.Net.BCrypt.HashPassword("correct") };
        _userRepoMock.Setup(x => x.GetByEmailAsync(request.Email)).ReturnsAsync(user);

        var result = await _userService.LoginAsync(request);

        Assert.IsNotNull(result);
        Assert.IsNotNull(result.Token);
    }
}

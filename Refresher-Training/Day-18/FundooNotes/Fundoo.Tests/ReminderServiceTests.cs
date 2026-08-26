using FundooNotes.Models.DTOs;
using FundooNotes.Models.Entities;
using FundooNotes.Repository.Interfaces;
using FundooNotes.Service.Implementations;
using FundooNotes.Service.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Fundoo.Tests;

[TestClass]
public class ReminderServiceTests
{
    private Mock<IReminderRepository> _reminderRepoMock;
    private Mock<INoteRepository> _noteRepoMock;
    private Mock<IUserRepository> _userRepoMock;
    private Mock<IRabbitMQService> _rabbitMQServiceMock;
    private ReminderService _reminderService;

    [TestInitialize]
    public void Setup()
    {
        _reminderRepoMock = new Mock<IReminderRepository>();
        _noteRepoMock = new Mock<INoteRepository>();
        _userRepoMock = new Mock<IUserRepository>();
        _rabbitMQServiceMock = new Mock<IRabbitMQService>();

        _reminderService = new ReminderService(
            _reminderRepoMock.Object,
            _noteRepoMock.Object,
            _userRepoMock.Object,
            _rabbitMQServiceMock.Object
        );
    }

    [TestMethod]
    public async Task CreateReminderAsync_ShouldReturnNull_WhenNoteNotFound()
    {
        _noteRepoMock.Setup(x => x.GetByIdAsync(1, 1)).ReturnsAsync((Note)null!);

        var request = new CreateReminderDto { NoteId = 1, ReminderTime = DateTime.UtcNow.AddDays(1) };
        var result = await _reminderService.CreateReminderAsync(request, 1);

        Assert.IsNull(result);
    }

    [TestMethod]
    public async Task CreateReminderAsync_ShouldCreate_WhenValid()
    {
        var note = new Note { Id = 1, UserId = 1 };
        _noteRepoMock.Setup(x => x.GetByIdAsync(1, 1)).ReturnsAsync(note);
        
        var user = new User { Id = 1, Email = "test@test.com" };
        _userRepoMock.Setup(x => x.GetByIdAsync(1)).ReturnsAsync(user);

        var reminder = new Reminder { Id = 1, NoteId = 1, UserId = 1 };
        _reminderRepoMock.Setup(x => x.CreateAsync(It.IsAny<Reminder>())).ReturnsAsync(reminder);

        var request = new CreateReminderDto { NoteId = 1, ReminderTime = DateTime.UtcNow.AddDays(1) };
        var result = await _reminderService.CreateReminderAsync(request, 1);

        Assert.IsNotNull(result);
        _rabbitMQServiceMock.Verify(x => x.PublishReminder(It.IsAny<ReminderMessage>()), Times.Once);
    }

    [TestMethod]
    public async Task GetByIdAsync_ShouldReturnNull_WhenNotOwned()
    {
        _reminderRepoMock.Setup(x => x.GetByIdAsync(1, 1)).ReturnsAsync((Reminder)null!);

        var result = await _reminderService.GetByIdAsync(1, 1);

        Assert.IsNull(result);
    }

    [TestMethod]
    public async Task DeleteAsync_ShouldReturnFalse_WhenNotOwned()
    {
        _reminderRepoMock.Setup(x => x.GetByIdAsync(1, 1)).ReturnsAsync((Reminder)null!);

        var result = await _reminderService.DeleteAsync(1, 1);

        Assert.IsFalse(result);
        _reminderRepoMock.Verify(x => x.DeleteAsync(It.IsAny<Reminder>()), Times.Never);
    }

    [TestMethod]
    public async Task DeleteAsync_ShouldDelete_WhenOwned()
    {
        var reminder = new Reminder { Id = 1, UserId = 1 };
        _reminderRepoMock.Setup(x => x.GetByIdAsync(1, 1)).ReturnsAsync(reminder);

        var result = await _reminderService.DeleteAsync(1, 1);

        Assert.IsTrue(result);
        _reminderRepoMock.Verify(x => x.DeleteAsync(reminder), Times.Once);
    }
}

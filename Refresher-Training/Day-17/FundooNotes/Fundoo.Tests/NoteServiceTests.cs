using FundooNotes.Models.DTOs;
using FundooNotes.Models.Entities;
using FundooNotes.Repository.Interfaces;
using FundooNotes.Service.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Fundoo.Tests;

[TestClass]
public class NoteServiceTests
{
    private Mock<INoteRepository> _noteRepoMock;
    private NoteService _noteService;

    [TestInitialize]
    public void Setup()
    {
        _noteRepoMock = new Mock<INoteRepository>();
        _noteService = new NoteService(_noteRepoMock.Object);
    }

    [TestMethod]
    public async Task CreateAsync_ShouldReturnNoteResponse()
    {
        var request = new NoteRequest { Title = "T", Description = "D" };
        var result = await _noteService.CreateAsync(request, 1);

        Assert.IsNotNull(result);
        Assert.AreEqual("T", result.Title);
        _noteRepoMock.Verify(x => x.CreateAsync(It.IsAny<Note>()), Times.Once);
    }

    [TestMethod]
    public async Task GetByIdAsync_ShouldReturnNull_WhenNoteNotFound()
    {
        _noteRepoMock.Setup(x => x.GetByIdAsync(1, 1)).ReturnsAsync((Note)null!);
        var result = await _noteService.GetByIdAsync(1, 1);
        Assert.IsNull(result);
    }

    [TestMethod]
    public async Task TogglePinAsync_ShouldToggle_WhenNoteExists()
    {
        var note = new Note { Id = 1, UserId = 1, IsPinned = false };
        _noteRepoMock.Setup(x => x.GetByIdAsync(1, 1)).ReturnsAsync(note);

        var result = await _noteService.TogglePinAsync(1, 1);

        Assert.IsTrue(result);
        Assert.IsTrue(note.IsPinned);
        _noteRepoMock.Verify(x => x.UpdateAsync(note), Times.Once);
    }

    [TestMethod]
    public async Task TogglePinAsync_ShouldFail_WhenNoteTrashed()
    {
        var note = new Note { Id = 1, UserId = 1, IsTrashed = true };
        _noteRepoMock.Setup(x => x.GetByIdAsync(1, 1)).ReturnsAsync(note);

        var result = await _noteService.TogglePinAsync(1, 1);

        Assert.IsFalse(result);
        _noteRepoMock.Verify(x => x.UpdateAsync(It.IsAny<Note>()), Times.Never);
    }

    [TestMethod]
    public async Task TrashAsync_ShouldTrashNote()
    {
        var note = new Note { Id = 1, UserId = 1 };
        _noteRepoMock.Setup(x => x.GetByIdAsync(1, 1)).ReturnsAsync(note);

        var result = await _noteService.TrashAsync(1, 1);

        Assert.IsTrue(result);
        Assert.IsTrue(note.IsTrashed);
        _noteRepoMock.Verify(x => x.UpdateAsync(note), Times.Once);
    }
    
    [TestMethod]
    public async Task RestoreAsync_ShouldRestoreNote()
    {
        var note = new Note { Id = 1, UserId = 1, IsTrashed = true };
        _noteRepoMock.Setup(x => x.GetByIdAsync(1, 1)).ReturnsAsync(note);

        var result = await _noteService.RestoreAsync(1, 1);

        Assert.IsTrue(result);
        Assert.IsFalse(note.IsTrashed);
        _noteRepoMock.Verify(x => x.UpdateAsync(note), Times.Once);
    }

    [TestMethod]
    public async Task SearchAsync_ShouldReturnNotes()
    {
        _noteRepoMock.Setup(x => x.SearchAsync(1, "test")).ReturnsAsync(new List<Note> { new Note() });

        var result = await _noteService.SearchAsync(1, "test");

        Assert.AreEqual(1, result.Count);
    }

    [TestMethod]
    public async Task AddLabelAsync_ShouldCallRepository()
    {
        _noteRepoMock.Setup(x => x.AddLabelAsync(1, 2, 3)).ReturnsAsync(true);
        var result = await _noteService.AddLabelAsync(1, 2, 3);
        Assert.IsTrue(result);
    }
    
    [TestMethod]
    public async Task RemoveLabelAsync_ShouldCallRepository()
    {
        _noteRepoMock.Setup(x => x.RemoveLabelAsync(1, 2, 3)).ReturnsAsync(true);
        var result = await _noteService.RemoveLabelAsync(1, 2, 3);
        Assert.IsTrue(result);
    }
}

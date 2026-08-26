using FundooNotes.Models.DTOs;
using FundooNotes.Models.Entities;
using FundooNotes.Repository.Interfaces;
using FundooNotes.Service.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Fundoo.Tests;

[TestClass]
public class LabelServiceTests
{
    private Mock<ILabelRepository> _labelRepoMock;
    private LabelService _labelService;

    [TestInitialize]
    public void Setup()
    {
        _labelRepoMock = new Mock<ILabelRepository>();
        _labelService = new LabelService(_labelRepoMock.Object);
    }

    [TestMethod]
    public async Task CreateAsync_ShouldReturnLabelResponse()
    {
        var request = new LabelRequest { Name = "Work" };
        var result = await _labelService.CreateAsync(request, 1);

        Assert.IsNotNull(result);
        Assert.AreEqual("Work", result.Name);
        _labelRepoMock.Verify(x => x.CreateAsync(It.IsAny<Label>()), Times.Once);
    }

    [TestMethod]
    public async Task GetByIdAsync_ShouldReturnLabel_WhenOwnedByUser()
    {
        var label = new Label { Id = 1, UserId = 1, Name = "Test" };
        _labelRepoMock.Setup(x => x.GetByIdAsync(1, 1)).ReturnsAsync(label);

        var result = await _labelService.GetByIdAsync(1, 1);

        Assert.IsNotNull(result);
        Assert.AreEqual("Test", result.Name);
    }

    [TestMethod]
    public async Task GetByIdAsync_ShouldReturnNull_WhenNotOwnedByUser()
    {
        _labelRepoMock.Setup(x => x.GetByIdAsync(1, 1)).ReturnsAsync((Label)null!);

        var result = await _labelService.GetByIdAsync(1, 1);

        Assert.IsNull(result);
    }

    [TestMethod]
    public async Task UpdateAsync_ShouldUpdate_WhenOwnedByUser()
    {
        var label = new Label { Id = 1, UserId = 1, Name = "Old" };
        _labelRepoMock.Setup(x => x.GetByIdAsync(1, 1)).ReturnsAsync(label);

        var request = new LabelRequest { Name = "New" };
        var result = await _labelService.UpdateAsync(1, request, 1);

        Assert.IsTrue(result);
        Assert.AreEqual("New", label.Name);
        _labelRepoMock.Verify(x => x.UpdateAsync(label), Times.Once);
    }

    [TestMethod]
    public async Task DeleteAsync_ShouldDelete_WhenOwnedByUser()
    {
        var label = new Label { Id = 1, UserId = 1 };
        _labelRepoMock.Setup(x => x.GetByIdAsync(1, 1)).ReturnsAsync(label);

        var result = await _labelService.DeleteAsync(1, 1);

        Assert.IsTrue(result);
        _labelRepoMock.Verify(x => x.DeleteAsync(label), Times.Once);
    }
}

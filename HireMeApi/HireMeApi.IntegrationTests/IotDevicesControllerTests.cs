using HireMeApi.Controllers;
using HireMeApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HireMeApi.IntegrationTests;

public class IotDevicesControllerTests : BaseTest
{
    private readonly IotDevicesController _controller;

    public IotDevicesControllerTests()
    {
        _controller = new IotDevicesController(DbContext);
    }

    [Fact]
    public async Task GetSingle_GetsCorrectDevice()
    {
        var expectedId = Guid.NewGuid();
        var expectedIotDevice = new IotDevice(expectedId, "Device 1");
        await DbContext.IotDevices.AddAsync(expectedIotDevice);
        await DbContext.SaveChangesAsync();

        var result = await _controller.GetSingle(expectedId);

        Assert.NotNull(result);
        var actual = result.Value;
        Assert.NotNull(actual);
        Assert.Equal(expectedIotDevice.Id, actual!.Id);
        Assert.Equal(expectedIotDevice.Name, actual.Name);
        Assert.Equal(expectedIotDevice.Description, actual.Description);
    }

    [Fact]
    public async Task DeleteSingle_DeletesCorrectDevice()
    {
        var expectedId = Guid.NewGuid();
        var expectedIotDevice = new IotDevice(expectedId, "Delete me");
        var otherIotDevices = new List<IotDevice>
        {
            new(Guid.NewGuid(), "Don't delete me 1"), new(Guid.NewGuid(), "Don't delete me 2")
        };
        await DbContext.IotDevices.AddAsync(expectedIotDevice);
        await DbContext.IotDevices.AddRangeAsync(otherIotDevices);
        await DbContext.SaveChangesAsync();

        var result = await _controller.DeleteSingle(expectedId);

        Assert.NotNull(result);
        Assert.IsType<NoContentResult>(result);
        var devicesLeft = await DbContext.IotDevices.ToListAsync();
        Assert.DoesNotContain(expectedIotDevice, devicesLeft);
        foreach (var otherIotDevice in otherIotDevices)
        {
            Assert.Contains(otherIotDevice, devicesLeft);
        }
    }
}

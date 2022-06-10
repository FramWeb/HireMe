using HireMeApi.Data;
using HireMeApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HireMeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class IotDeviceController : ControllerBase
{
    private readonly HireMeApiDbContext _dbContext;

    public IotDeviceController(HireMeApiDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    [HttpGet]
    public async Task<List<IotDevice>> GetAll()
    {
        return await _dbContext.IotDevices.ToListAsync();
    }
    
    // TODO: Implement getting a single device
    [HttpGet("{id:guid}")]
    public async Task<List<IotDevice>> GetSingle(Guid id)
    {
        throw new NotImplementedException();
    }
}

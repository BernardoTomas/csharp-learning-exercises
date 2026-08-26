using configuringConsoleLogger.Services;
using Microsoft.AspNetCore.Mvc;

namespace configuringConsoleLogger.Controllers;

[ApiController]
[Route("[controller]")]
public class CepController : ControllerBase
{
    private readonly ICepService _cepService;

    public CepController (ICepService cepService)
    {
        _cepService = cepService;
    }

    [HttpGet("{cep}")]
    public async Task<IActionResult> GetCepData (string cep)
    {
        var cepData = await _cepService.GetCep(cep);
        if (cepData is null) return NotFound();

        return Ok(cepData);
    }
}
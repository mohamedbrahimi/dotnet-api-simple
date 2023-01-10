using Microsoft.AspNetCore.Mvc;
using webapi_try.DTOs;

namespace webapi_try.Controllers;

[ApiController]
[Route("[controller]")]
public class PaperNamesController : Controller
{
    private readonly IPaperService _paperService;

    public PaperNamesController(IPaperService paperService)
    {
        _paperService = paperService;
    }

    [HttpGet("list")]
    public async Task<ActionResult<List<PaperDto>>> GetPapers()
    {
        return Ok(await _paperService.PapersList());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PaperDto>> SinglePaper(int id)
    {
        return Ok(await _paperService.SinglePaper(id));
    }

    [HttpPost()]
    public async Task<ActionResult<List<PaperDto>>> AddPaper([FromForm] PaperDto paper)
    {
        return Ok(await _paperService.AddSinglePaper(paper));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<bool>> UpdatePaper(int id, [FromForm] PaperDto paper)
    {
        return Ok(await _paperService.UpdateSinglePaper(id, paper));
    }
   
    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> DeletePaper(int id)
    {
        return Ok(await _paperService.RemoveSinglePaper(id));
    }
}
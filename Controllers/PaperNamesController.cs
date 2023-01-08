using Microsoft.AspNetCore.Mvc;
using webapi_try.Models;

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
    public ActionResult<List<Paper>> GetPapers()
    {
        return Ok(_paperService.PapersList());
    }

    [HttpGet("{id}")]
    public ActionResult<Paper> SinglePaper(int id)
    {
        return Ok(_paperService.SinglePaper(id));
    }

    [HttpPost()]
    public ActionResult<List<Paper>> AddPaper([FromForm] Paper paper)
    {
        return Ok(_paperService.AddSinglePaper(paper));
    }

    [HttpPut("{id}")]
    public ActionResult<bool> UpdatePaper(int id, [FromForm] Paper paper)
    {
        return Ok(_paperService.UpdateSinglePaper(id, paper));
    }
   
    [HttpDelete("{id}")]
    public ActionResult<bool> DeletePaper(int id)
    {
        return Ok(_paperService.RemoveSinglePaper(id));
    }
}
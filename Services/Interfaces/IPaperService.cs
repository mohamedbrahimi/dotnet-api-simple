using webapi_try.DTOs;
using webapi_try.Models;

namespace webapi_try;

public interface IPaperService
{
   public Task<List<Paper>> PapersList();
   public Task<Paper> SinglePaper(int id);
   public Task<List<Paper>> AddSinglePaper(PaperDto paper);
   public Task<bool> UpdateSinglePaper(int id, PaperDto paper);
   public Task<bool> RemoveSinglePaper(int id);
   
   
}
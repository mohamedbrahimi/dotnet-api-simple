using webapi_try.Models;

namespace webapi_try;

public interface IPaperService
{
   public List<Paper> PapersList();
   public Paper SinglePaper(int id);
   public List<Paper> AddSinglePaper(Paper paper);
   public bool UpdateSinglePaper(int id, Paper paper);
   public bool RemoveSinglePaper(int id);
   
   
}
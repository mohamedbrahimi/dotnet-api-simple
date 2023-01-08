using webapi_try.Models;

namespace webapi_try.Services;

public class PaperService: IPaperService
{
    private List<Paper> _papers = new List<Paper>
    {
        new Paper() { Id = 1, Path = "/etc/home/1.txt"},
        new Paper() { Id = 2, Path = "/etc/home/2.txt"},
        new Paper() { Id = 3, Path = "/etc/home/3.txt"},
        new Paper() { Id = 4, Path = "/etc/home/4.txt"},
       
    };
    public List<Paper> PapersList()
    {
        return _papers;
    }

    public Paper? SinglePaper(int id)
    {
        return _papers.Find(x => x.Id ==  id) ;
    }

    public List<Paper> AddSinglePaper(Paper paper)
    {
        _papers.Add(paper);
        return _papers;
    }

    public bool UpdateSinglePaper(int id, Paper paper)
    {
        var selectedPaper = this.SinglePaper(id);
        if (selectedPaper == null)
            return false;
        
        
    }

    public bool RemoveSinglePaper(int id)
    {
        throw new NotImplementedException();
    }
}
using Microsoft.EntityFrameworkCore;
using webapi_try.DTOs;
using webapi_try.Models;

namespace webapi_try.Services;

public class PaperService: IPaperService
{

    private readonly AppDbService _appDbService;

    public PaperService(AppDbService appDbService)
    {
        _appDbService = appDbService;
    }
    
    public async Task<List<Paper>> PapersList()
    {
        var papers = await _appDbService.Papers.ToListAsync();
        return papers;
    }

    public async Task<Paper?> SinglePaper(int id)
    {
        return await _appDbService.Papers.FindAsync(id);
    }

    public async Task<List<Paper>> AddSinglePaper(PaperDto paper)
    {
        Paper newPaper = new Paper()
        {
            Id = paper.Id,
            Path = paper.Path,
            Name = paper.Name,
            Dir = paper.Dir,
        };
        _appDbService.Papers.Add(newPaper);
        await _appDbService.SaveChangesAsync();
        return await _appDbService.Papers.ToListAsync();
    }

    public async Task<bool> UpdateSinglePaper(int id, PaperDto paper)
    {
        Paper? selectedPaper =  await _appDbService.Papers.FindAsync(id);
        if (selectedPaper == null)
            return false;

        selectedPaper.Path = paper.Path ?? selectedPaper.Path;
        selectedPaper.Name = paper.Name ?? selectedPaper.Name;
        selectedPaper.Dir = paper.Dir ?? selectedPaper.Dir;

        await _appDbService.SaveChangesAsync();
        return true;
    }

    public async Task<bool> RemoveSinglePaper(int id)
    {
       
        Paper? selectedPaper =  await _appDbService.Papers.FindAsync(id);
        if (selectedPaper == null)
            return false;

        _appDbService.Papers.Remove(selectedPaper);

        await _appDbService.SaveChangesAsync();
        return true;
    }
}
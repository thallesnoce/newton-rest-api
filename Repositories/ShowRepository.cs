using ShowsApi.Models;

namespace ShowsApi.Repositories;

public class ShowRepository
{
    private readonly List<Show> _shows = new()
    {
        new Show { Id = 1, Titulo = "Iron Maidem", Genero = "Rock",   Cidade = "Belo Horizonte"},
        new Show { Id = 2, Titulo = "Gueta Van Fleet", Genero = "Rock",  Cidade = "São Paulo"},
        new Show { Id = 3, Titulo = "Metállica", Genero = "Rock", Cidade = "Belo Horizonte"},
    };

    private int _nextId = 4;

    public List<Show> GetAll() => _shows;

    public Show? GetById(int id) => _shows.FirstOrDefault(s => s.Id == id);

    public Show Create(Show show)
    {
        show.Id = _nextId++;
        _shows.Add(show);
        return show;
    }

    public Show? Update(int id, Show updated)
    {
        var existing = GetById(id);
        if (existing is null) return null;

        existing.Titulo = updated.Titulo;
        existing.Genero = updated.Genero;
        existing.Cidade = updated.Cidade;

        return existing;
    }

    public bool Delete(int id)
    {
        var show = GetById(id);
        if (show is null) return false;

        _shows.Remove(show);
        return true;
    }
}

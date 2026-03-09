namespace ShowsApi.Models;

public class Show
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Genero { get; set; } = string.Empty;
    public string Cidade { get; set; }
}

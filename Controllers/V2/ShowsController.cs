using Microsoft.AspNetCore.Mvc;
using ShowsApi.Models;
using ShowsApi.Repositories;

namespace ShowsApi.Controllers.V2;

[ApiController]
[Route("api/v2/[controller]")]
public class ShowsController : ControllerBase
{
    private readonly ShowRepository _repository;

    public ShowsController(ShowRepository repository)
    {
        _repository = repository;
    }

    // GET api/v2/shows
    [HttpGet]
    public ActionResult<List<Show>> GetAll()
    {
        return Ok(_repository.GetAll());
    }

    // GET api/v2/shows/{id}
    [HttpGet("{id}")]
    public ActionResult<Show> GetById(int id)
    {
        var show = _repository.GetById(id);
        if (show is null) return NotFound();

        return Ok(show);
    }

    // POST api/v2/shows
    [HttpPost]
    public ActionResult<Show> Create(Show show)
    {
        var created = _repository.Create(show);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    // PUT api/v2/shows/{id}
    [HttpPut("{id}")]
    public ActionResult<Show> Update(int id, Show show)
    {
        var updated = _repository.Update(id, show);
        if (updated is null) return NotFound();

        return Ok(updated);
    }

    // DELETE api/v2/shows/{id}
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var deleted = _repository.Delete(id);
        if (!deleted) return NotFound();

        return NoContent();
    }

    // DELETE api/v2/shows
    [HttpDelete]
    public ActionResult DeleteAll()
    {
        _repository.DeleteAll();
        return NoContent();
    }

    // DELETE api/v2/shows/batch
    [HttpDelete("batch")]
    public ActionResult DeleteMany([FromBody] List<int> ids)
    {
        _repository.DeleteMany(ids);
        return NoContent();
    }
}
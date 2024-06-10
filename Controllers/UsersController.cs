using Microsoft.AspNetCore.Mvc;

[Route("users")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly ConjuntaDbSqliteContext _dbContext;

    public UsersController(ConjuntaDbSqliteContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("list-all")]
    public List<Usuario> ListAll()
    {
        return _dbContext.Usuarios.ToList();
    }

    [HttpPost("add")]
    public Usuario Add([FromBody] Usuario usuario)
    {
        _dbContext.Usuarios.Add(usuario);
        _dbContext.SaveChanges();
        return usuario;
    }
}
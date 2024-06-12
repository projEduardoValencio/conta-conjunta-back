using System.ComponentModel.DataAnnotations.Schema;

public class Conta
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int UsuarioAId { get; set; }
    public int UsuarioBId { get; set; }

    // Chaves estrangeiras
    [ForeignKey("UsuarioAId")]
    public virtual Usuario UsuarioA { get; set; } // virtual para permitir lazy load
    [ForeignKey("UsuarioBId")]
    public virtual Usuario UsuarioB { get; set; }
}
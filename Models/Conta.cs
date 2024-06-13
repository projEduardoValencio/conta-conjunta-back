using System.ComponentModel.DataAnnotations.Schema;

public class Conta
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public decimal limitePrevisto { get; set; }

    // Chaves estrangeiras
    [ForeignKey("UsuarioId")]
    public virtual Usuario Usuario { get; set; } // virtual para permitir lazy load
}
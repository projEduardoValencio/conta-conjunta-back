using System.ComponentModel.DataAnnotations.Schema;

public class ContaConjunta
{
    public int Id { get; set; }
    public int ContaAId { get; set; }
    public int ContaBId { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime DataFormacao { get; set; }

    [ForeignKey("ContaAId")]
    public Conta ContaA { get; set; }
    [ForeignKey("ContaBId")]
    public Conta ContaB { get; set; }
}
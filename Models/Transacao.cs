public class Transacao
{
    public int Id { get; set; }
    public decimal Valor { get; set; }
    public float ParteA { get; set; }
    public float ParteB { get; set; }
    public DateTime Data { get; set; }
    public int Parcelas { get; set; }
}
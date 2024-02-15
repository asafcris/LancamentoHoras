namespace LancamentoHoras.Domain.Models
{
    public class LancamentoDeHoras
    {
        public virtual int IdLancamento{ get; set; }
        public virtual string Nome { get; set; }
        public virtual DateTime Mes { get; set; }
        public virtual decimal Hora { get; set; }
        
    }
}

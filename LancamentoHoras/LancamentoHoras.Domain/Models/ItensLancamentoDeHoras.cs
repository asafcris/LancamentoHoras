namespace LancamentoHoras.Domain.Models
{
    public class ItensLancamentoDeHoras
    {
        public virtual int IdItem { get; set; }
        public virtual LancamentoDeHoras LancamentoDeHoras { get; set; }
        public virtual Projeto Projeto { get; set; }
        public virtual DateTime DataInicio { get; set; }
        public virtual DateTime DataFim { get; set; }
        public virtual string NumeroOs { get; set; }
        public virtual string AtividadeDescricao { get; set; }
        public virtual string Observacao { get; set; }

    }
}

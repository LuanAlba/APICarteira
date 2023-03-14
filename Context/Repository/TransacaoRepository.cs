

using APICarteira.Entities;
using APICarteira.Shared.Enums;

namespace APICarteira.Context.Repository;

public class TransacaoRepository : ITransacaoRepository
{
    private readonly APICarteiraContext context;

    public TransacaoRepository(APICarteiraContext context)
    {
        this.context = context;
    }

    public IEnumerable<Transacao> ObterTodas()
    {
        return context.Transacao.Where(o => o.Status != Status.Excluido).ToList();
    }

    public Transacao ObterPorId(int id)
    {
        return context.Transacao.SingleOrDefault(o => o.Id == id && o.Status != Status.Excluido);
    }

    public void Adicionar(Transacao transacao)
    {
        context.Transacao.Add(transacao);
        context.SaveChanges();  
    }

    public void Atualizar(Transacao transacao)
    {
        context.Transacao.Update(transacao);
        context.SaveChanges();
    }

    
}
using APICarteira.Entities;

namespace APICarteira.Context.Repository;

public interface ITransacaoRepository
{
    IEnumerable<Transacao> ObterTodas();
    Transacao ObterPorId(int id);
    void Adicionar(Transacao transacao);
    void Atualizar(Transacao transacao);
}
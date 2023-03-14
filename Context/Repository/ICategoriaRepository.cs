using APICarteira.Entities;
using EntityFrameworkCore.Repository.Interfaces;

namespace APICarteira.Context.Repository;

public interface ICategoriaRepository : IRepository<Categoria>
{
    IEnumerable<Categoria> ObterTodas();
    Categoria ObterPorId(int id);
    void Adicionar(Categoria categoria);
    void Excluir(Categoria categoria);
}
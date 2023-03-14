using APICarteira.Shared.Enums;
using EntityFrameworkCore.Repository;
using APICarteira.Entities;


namespace APICarteira.Context.Repository;

public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
{
    private readonly APICarteiraContext context;

    public CategoriaRepository(APICarteiraContext context) : base(context) 
    {
        this.context = context;
    }

    public IEnumerable<Categoria> ObterTodas()
    {
        return context.Categoria.ToList();
    }

    public Categoria ObterPorId(int id)
    {
        return context.Categoria.SingleOrDefault(o => o.Id == id);
    }

    public void Adicionar(Categoria categoria)
    {
        context.Categoria.Add(categoria);
        context.SaveChanges();  
    }

    public void Excluir(Categoria categoria)
    {
        context.Categoria.Remove(categoria);
        context.SaveChanges();  
    }

    
}
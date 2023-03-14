
using APICarteira.Shared.Enums;

namespace APICarteira.Entities;

public class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public Status Status { get; set; }

    public Categoria(string nome, Status status)
    {
        Nome = nome;
        Status = status;
    }

}
using APICarteira.Shared.Enums;

namespace APICarteira.Models
{
    public record AdicionarCategoriaModel(string nome, Status status = Status.Ativo)
    {     
    }
}
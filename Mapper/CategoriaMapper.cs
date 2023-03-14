using AutoMapper;
using APICarteira.Entities;
using APICarteira.Models;

namespace APICarteira.Mappers;

public class CategoriaMapper : Profile
{
    public CategoriaMapper()
    {
        CreateMap<AdicionarCategoriaModel, Categoria>();
    }
}

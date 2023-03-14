using AutoMapper;
using APICarteira.Entities;
using APICarteira.Models;

namespace APICarteira.Mappers;

public class TransacaoMapper : Profile
{
    public TransacaoMapper()
    {
        CreateMap<AdicionarTransacaoModel, Transacao>();
    }
}

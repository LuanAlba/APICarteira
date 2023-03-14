
using APICarteira.Shared.Enums;

namespace APICarteira.Entities;

public class Transacao
{
    public int Id { get; set; }
    public decimal Valor { get; set; }
    public int CategoriaId { get; set; }
    public string Descricao { get; set; }
    public DateTime Data { get; set; }
    public Status Status { get; set; }
    public TipoTransacao TipoTransacao { get; set; } 


    public Transacao( decimal valor, int categoriaId, string descricao, DateTime data, Status status, TipoTransacao tipoTransacao)
    {
        Valor = valor;
        CategoriaId = categoriaId;
        Descricao = descricao;
        Data = data;
        Status = status;
        TipoTransacao = tipoTransacao;
    }
    
        public void Atualizar(decimal valor, string descricao, DateTime data, int categoriaId)
        {
            Valor = valor;
            Descricao = descricao;
            CategoriaId = categoriaId;
            Data = data;
        }
}
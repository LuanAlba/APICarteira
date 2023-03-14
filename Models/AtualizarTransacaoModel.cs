namespace APICarteira.Models
{
    //record pois é mais leve e mais simples para aceitar o construtor
    public record AtualizarTransacaoModel(decimal valor, string descricao, DateTime data, int categoriaId, int tipoTransacao)
    {     
    }
}
namespace APICarteira.Models
{
    //record pois é mais leve e mais simples para aceitar o construtor
    public record AdicionarTransacaoModel(decimal valor, string descricao, DateTime data, int status, int categoriaId, int tipoTransacao)
    {     
    }
}
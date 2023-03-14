
using APICarteira.Shared.Enums;

namespace APICarteira.Entities;

public class Cartao
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Fatura { get; set; }
    public decimal ValorSaida { get; set; }
    public DateTime Data { get; set; }
    public string Descricao { get; set; }
    public Status Status { get; set; }

    public Cartao(int id, string nome, decimal fatura, decimal valorSaida, string descricao)
    {
        Id = id;
        Nome = nome;
        Fatura = fatura;
        ValorSaida = valorSaida;
        Descricao = descricao;
    }

    public void AtualizarNome(string nome) => Nome = nome;
    
    public void AtualizarFatura(decimal valorSaida)
    {
        ValorSaida = valorSaida;

        Fatura += valorSaida;
    }

    public void ExcluirCartao() => Status = Status.Excluido;

}
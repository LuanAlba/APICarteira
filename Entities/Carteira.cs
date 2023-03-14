
namespace APICarteira.Entities;

public class Carteira 
{
    public int Id { get; set; }
    public decimal Saldo { get; set; }
    public decimal EntradaTotal { get; set; }
    public decimal SaidaTotal { get; set; }


    public Carteira(int id, decimal saldo, decimal entradaTotal, decimal saidaTotal)
    {
        Id = id;
        Saldo = saldo;
        EntradaTotal = entradaTotal;
        SaidaTotal = saidaTotal;
    }

    public void AtualizarSaldo(decimal entradaTotal, decimal saidaTotal)
    {
        EntradaTotal = entradaTotal;
        SaidaTotal = saidaTotal;

        Saldo = EntradaTotal - SaidaTotal; 
    }

    public void AtualizarEntrada(decimal entradaTotal) => EntradaTotal = entradaTotal;

    public void AtualizarSaida(decimal saidaTotal) => SaidaTotal = saidaTotal;

}

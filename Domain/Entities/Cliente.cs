namespace Domain.Entities;

public class Cliente
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public bool ClienteAtivo { get; set; }

    public Cliente() { }
    public Cliente(int id, string? nome, DateTime datanascimento, bool clienteAtivo)
    {
        Id = id;
        Nome = nome;
        DataNascimento = datanascimento;
        ClienteAtivo = clienteAtivo;
    }
}
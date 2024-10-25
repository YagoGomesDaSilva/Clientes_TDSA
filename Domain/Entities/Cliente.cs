using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Cliente
{
    public int Id { get; set; }
    //[Required(ErrorMessage = "O nome é obrigatório.")]
    public string? Nome { get; set; }
    //[Required(ErrorMessage = "A data de nascimento é obrigatória.")]
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
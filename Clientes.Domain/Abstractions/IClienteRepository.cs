using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions;

public interface IClienteRepository
{
    Task<IEnumerable<Cliente>> ObterClientes();
    Task<Cliente?> ObterCliente(int id);
    Task<Cliente> AdicionarCliente(Cliente cliente);
    Task<Cliente> AtualizarCliente(Cliente cliente);
    Task<Cliente?> DeletarCliente(int id);

}

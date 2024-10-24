using Domain.Abstractions;
using Domain.Entities;
using Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly ApplicationDbContext? _context;

    public ClienteRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Cliente?> ObterCliente(int id)
    {
        if (_context?.Clientes == null )
            throw new InvalidOperationException("Contexto ou cliente inválido.");

        return await _context.Clientes.FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<IEnumerable<Cliente>> ObterClientes()
    {
        if (_context?.Clientes == null)
            throw new InvalidOperationException("Contexto ou cliente inválido.");

        return await _context.Clientes.ToListAsync();
    }

    public async Task<Cliente> AdicionarCliente(Cliente cliente)
    {
        if (_context?.Clientes == null || cliente == null)
            throw new InvalidOperationException("Contexto ou cliente inválido.");

        _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync();

        return cliente;
    }

    public async Task<Cliente> AtualizarCliente(Cliente cliente)
    {
        if (_context?.Clientes == null || cliente == null)
            throw new InvalidOperationException("Contexto ou cliente inválido.");

        _context.Entry(cliente).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return cliente;
    }

    public async Task<Cliente?> DeletarCliente(int id)
    {
        if (_context?.Clientes == null)
            throw new InvalidOperationException("Contexto ou cliente inválido.");

        var cliente = await ObterCliente(id) ?? throw new InvalidOperationException("Cliente não encontrado.");
        _context.Clientes.Remove(cliente);
        await _context.SaveChangesAsync();

        return cliente;
    }

}

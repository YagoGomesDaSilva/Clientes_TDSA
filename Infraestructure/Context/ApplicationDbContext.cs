using Domain.Entities;
using Infraestructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Cliente>? Clientes {  get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //obtem todas as configuraçoes do Assembly sem a necessidade de chamar uma por uma no modelBuilder
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(AplicationDbContext).Assembly);

        // Aplicar configurações via Fluent API para a entidade Cliente
        modelBuilder.ApplyConfiguration(new ClienteConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using LocadoraBack.Models;
using Microsoft.EntityFrameworkCore;

namespace LocadoraBack.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<PessoaModel> PESSOAS { get; set; }
        public DbSet<VeiculoModel> VEICULOS { get; set; }
        public DbSet<TelefoneEntidade> TELEFONES { get; set; }
        public DbSet<PedidoModel> PEDIDOS { get; set; }
        public DbSet<UserModel> USUARIOS { get; set; }

    }


}
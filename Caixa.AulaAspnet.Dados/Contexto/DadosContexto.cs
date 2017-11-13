using Caixa.AulaAspnet.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.AulaAspnet.Dados.Contexto
{
    public class DadosContexto : DbContext
    {
        public DadosContexto()
            : base("DefaultConnection")
        {

        }
        
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Telefone> Telefone { get; set; }

        public DbSet<TipoTelefone> TipoTelefone { get; set; }
    }
}

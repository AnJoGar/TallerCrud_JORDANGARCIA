using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerCRUD.Models
{
  public class ClienteContext:DbContext
  {
    public DbSet<Cliente> Clientes { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=LAPTOP-NJHB3QO3\\SQLEXPRESS;Database=Cliente;Integrated Security=true");
    }


  }
}

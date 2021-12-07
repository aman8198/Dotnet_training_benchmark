using Microsoft.EntityFrameworkCore;
using RestWebApi.Models;

namespace RestWebApi.Dat
{
    public class CommandContext : DbContext
    {
      public CommandContext(DbContextOptions<CommandContext> opt) : base(opt)
      {
          
      } 

      public DbSet<Command> Commands{get; set;}
    }

}
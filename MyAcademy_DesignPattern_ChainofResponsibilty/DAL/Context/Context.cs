using Microsoft.EntityFrameworkCore;
using MyAcademy_DesignPattern_ChainofResponsibilty.DAL.Entities;

namespace MyAcademy_DesignPattern_ChainofResponsibilty.DAL.Context
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2PU1K7L\\SQLEXPRESS; initial catalog=DBChainofRespon;integrated security=true;");
        }
        public DbSet<CustomerProcess> customerProcesses  { get; set; }
    }
}

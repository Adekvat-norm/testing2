using Content.DataSet.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.DataSet
{
    public class ContentDbContext: DbContext
    {
        public ContentDbContext(DbContextOptions<ContentDbContext> options) : base(options) { }

        public DbSet<AudiencesEntity> Audiences { get; set; }

        public DbSet<Component_movementsEntity> ComponentMovements { get; set; }

        public DbSet<ComponentsEntity> Components { get; set; }

        public DbSet<Equipment_movementsEntity> Equipment_Movements{ get; set; }

        public DbSet<EquipmentsEntity> Equipments{ get; set; }

        public DbSet<SuppliersEntity> Suppliers{ get; set; }

        public DbSet<UsersEntity> Users{ get; set; }

        public DbSet<WorkplacesEntity> Workplaces{ get; set; }
    }
}

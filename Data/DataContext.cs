using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace be_rpg.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, Name = "Fireball", Damage = 70 },
                new Skill { Id = 2, Name = "Arcane Shield", Damage = 30 },
                new Skill { Id = 3, Name = "Teleport", Damage = 40 },
                new Skill { Id = 4, Name = "Cleave", Damage = 85 },
                new Skill { Id = 5, Name = "Shield Bash", Damage = 50 },
                new Skill { Id = 6, Name = "Whirlwind Attack", Damage = 70 },
                new Skill { Id = 7, Name = "Backstab", Damage = 75 },
                new Skill { Id = 8, Name = "Evasion", Damage = 40 },
                new Skill { Id = 9, Name = "Shadowstep", Damage = 60 },
                new Skill { Id = 10, Name = "Raging Strike", Damage = 90 },
                new Skill { Id = 11, Name = "Holy Strike", Damage = 75 },
                new Skill { Id = 12, Name = "Assassinate", Damage = 95 },
                new Skill { Id = 13, Name = "Frenzy", Damage = 100 },
                new Skill { Id = 14, Name = "Bloodlust", Damage = 85 },
                new Skill { Id = 15, Name = "Telepathy", Damage = 45 }
                );
        }

        public DbSet<Character> Characters => Set<Character>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Weapon> Weapons => Set<Weapon>();
        public DbSet<Skill> Skills => Set<Skill>();
    }
}
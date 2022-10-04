using API;
using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAPI.DataBase
{
    public class DBHelper : DbContext
    {
        public DBHelper(DbContextOptions<DBHelper> options) : base(options) { }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Albums> Albums { get; set; }

    }



}

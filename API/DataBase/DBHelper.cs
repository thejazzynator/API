using API;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAPI.DataBase
{
    public class DBHelper : DbContext
    {
        string connection = "server=\\localhost;database=MyMusicDB;Trusted_Connection=true";
        public DBHelper(DbContextOptions<DBHelper> options) : base(options) {}
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Albums> Albums { get; set; }

    }



}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{

    public class Albums
    {
        [Key]
        public string AlbumOne { get; set; }
        public string AlbumTwo  { get; set; }
        public int Id { get; set; }
    }
}

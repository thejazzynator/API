using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MusicAPI.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Music : ControllerBase

    {

        public List<Artist> artist = new List<Artist>()
        {
            new Artist(1, "Chelsea Wolfe", 37, "Spun", "Atlanta"),
            new Artist(2, "Chelsea Wolfe and Converge", 38, "Flower Moon", "Los Angeles"),
            new Artist(3, "Emma Ruth Rundle", 37, "Dark Horse", "Baltimore"),

        };

        private readonly DBHelper _dbContext;

        public Music(DBHelper dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult<List<Artist>>> GetArtistDetails()
        {
            return Ok(artist);
        }

        //[HttpGet]
        //public async Task<ActionResult<List<Artist>>> GetArtistDetails()
        //{
        //    return Ok(await _dbContext.Artists.ToListAsync());
        //}


        [Route("[action]/{Id}")]
        [HttpGet("{id}", Name = "Get")]
        public Artist GetArtistByID(int id)
        {
            Artist value = artist.Find(f => f.Id == id);
            return value;
        }

        [Route("[action]")]
        [HttpGet]
        public Artist GetArtistByAge()
        {
            Artist value = artist.First(x => x.Age.Equals(37));
            return value;
        }

        [Route("[action]")]
        [HttpPost]
        public List<Artist> AddArtist([FromBody] Artist value)
        {
            artist.Add(value);
            return artist;
        }

        [Route("[action]/{Id}")]
        [HttpPut("{id}")]
        public List<Artist> UpdateArist(int id, [FromBody] Artist value)
        {
            Artist updatedValue = artist.Find(x => x.Id == id);
            int index = artist.IndexOf(updatedValue);

            artist[index].Age = value.Age;
            artist[index].Album = value.Album;
            artist[index].Singer = value.Singer;
            artist[index].Song = value.Song;

            return artist;
        }

        [Route("[action]/{Id}")]
        [HttpDelete("{id}")]

        public List<Artist> DeleteArtist(int id)
        {
            Artist value = artist.Find(f => f.Id == id);
            artist.Remove(value);
            return artist;
        }

    }
}

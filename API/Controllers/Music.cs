using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
            new Artist(2, "Chelsea Wolfe and Converge", 38, "Flower Moon", "Los Angeles")
        };

        [HttpGet]
        public List<Artist> GetArtistDetails()
        {
            return artist;
        }

        [HttpGet("{id}", Name = "Get")]
        public Artist GetArtistByID(int id)
        {
            Artist value = artist.Find(f => f.Id == id);
            return value;
        }

        [HttpGet]
        public Artist GetArtistByAge()
        {
            Artist value = artist.First(x => x.Age.Equals(37));
            return value;
        }

        [HttpPost]
        public List<Artist> AddArtist([FromBody] Artist value)
        {
            artist.Add(value);
            return artist;
        }

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

        [HttpDelete("{id}")]

        public List<Artist> DeleteArtist(int id)
        {
            Artist value = artist.Find(f => f.Id == id);
            artist.Remove(value);
            return artist;
        }

    }
}

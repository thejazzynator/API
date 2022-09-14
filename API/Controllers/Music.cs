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
            new Artist(1, "Chelsea Wolfe", 37, "Hiss Spun", "Spun"),
            new Artist(2, "Emma Ruth Rundle", 38, "Dark Horse", "Light Song")
        };

        [HttpGet]
        public List<Artist> Get()
        {
            return artist;
        }

        [HttpGet("{id}", Name = "Get")]
        public Artist Get(int id)
        {
            Artist value = artist.Find(f => f.Id == id);
            return value;
        }

        [HttpPost]
        public List<Artist> Post([FromBody] Artist value)
        {
            artist.Add(value);
            return artist;
        }

        [HttpPut("{id}")]
        public List<Artist> Put(int id, [FromBody] Artist value)
        {
            Artist updatedValue = artist.Find(x => x.Id == id);
            int index = artist.IndexOf(updatedValue);

            artist[index].Age = value.Age;
            artist[index].Album = value.Album;
            artist[index].Singer = value.Singer;
            artist[index].Song = value.Song;

            return artist;
        }

        [HttpDelete]

        public List<Artist> Delete(int id)
        {
            Artist value = artist.Find(f => f.Id == id);
            artist.Remove(value);
            return artist;
        }

    }
}

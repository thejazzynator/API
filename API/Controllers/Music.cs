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
            new Artist("Chelsea Wolfe", 37, "Hiss Spun", "Spun", 1),
            new Artist("Emma Ruth Rundle", 38, "Dark Horse", "Light Song", 2)
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

        //[HttpDelete]

    }
}

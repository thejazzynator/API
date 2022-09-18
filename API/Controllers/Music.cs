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
        public List<ChelseaWolfe> artist = new List<ChelseaWolfe>()
        {
            new ChelseaWolfe(1, "Chelsea Wolfe", 37, "Spun", "Atlanta"),
            new ChelseaWolfe(2, "Chelsea Wolfe and Converge", 37, "Flower Moon", "Los Angeles")
        };

        [HttpGet]
        public List<ChelseaWolfe> GetArtistDetails()
        {
            return artist;
        }

        [HttpGet("{id}", Name = "Get")]
        public ChelseaWolfe GetArtistByID(int id)
        {
            ChelseaWolfe value = artist.Find(f => f.Id == id);
            return value;
        }


        [HttpPost]
        public List<ChelseaWolfe> AddArtist([FromBody] ChelseaWolfe value)
        {
            artist.Add(value);
            return artist;
        }

        [HttpPut("{id}")]
        public List<ChelseaWolfe> UpdateArist(int id, [FromBody] ChelseaWolfe value)
        {
            ChelseaWolfe updatedValue = artist.Find(x => x.Id == id);
            int index = artist.IndexOf(updatedValue);

            artist[index].Age = value.Age;
            artist[index].Album = value.Album;
            artist[index].Singer = value.Singer;
            artist[index].Song = value.Song;

            return artist;
        }

        [HttpDelete("{id}")]

        public List<ChelseaWolfe> DeleteArtist(int id)
        {
            ChelseaWolfe value = artist.Find(f => f.Id == id);
            artist.Remove(value);
            return artist;
        }

    }
}

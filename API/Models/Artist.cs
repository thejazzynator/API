using API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API
{
    public class Artist
    {
        public string Singer { get; set; }
        public int Age { get; set; }
        public string Song { get; set; }
        public int Id { get; set; }
        public string Location { get; set; }
        public List<Albums> Album { get; set; }

        public Artist(int id, string singer, int age, string song, string location)
        {
            Id = id;
            Singer = singer;
            Age = age;
            Song = song;
            Location = location;

            Album = new List<Albums>()
            {
                new Albums
                {
                    AlbumOne = "Hiss Spun",
                    AlbumTwo = "Pain Is Beauty",
                    Id = id
                }
            };
           
        }
        
    }

}

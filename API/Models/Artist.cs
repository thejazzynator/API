using System;
using System.Collections.Generic;

namespace API
{
    public class Artist
    {
        public string Singer { get; set; }
        public int Age { get; set; }
        //public List<string> Albums { get; set; }
        public string Album { get; set; }
        public string Song { get; set; }
        public int Id { get; set; }



        public Artist(string singer, int age, string album, string song, int id)
        {
            Singer = singer;
            Age = age;
            Album = album;
            Song = song;
            Id = id;
        }


        //Artist happy = new Artist(); //instead of instantiating the class, use "this" keyword
    }

}

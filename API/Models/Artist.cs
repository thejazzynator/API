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



        public Artist(int id, string singer, int age, string album, string song)
        {
            Id = id;
            Singer = singer;
            Age = age;
            Album = album;
            Song = song;
           
        }


        //Artist happy = new Artist(); //instead of instantiating the class, use "this" keyword
    }

}
